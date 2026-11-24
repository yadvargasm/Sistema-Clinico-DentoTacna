using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    /// <summary>Reglas de negocio de los tratamientos. El formulario solo habla con esta clase.</summary>
    public class clsTratamiento_N
    {
        private readonly clsTratamiento_D objTratamiento = new clsTratamiento_D();

        public List<clsTratamiento> mtdListarTratamientos()
        {
            List<clsTratamiento> lista = new List<clsTratamiento>();
            foreach (DataRow f in objTratamiento.mtdListarTratamientos().Rows)
            {
                lista.Add(new clsTratamiento
                {
                    idTratamiento = Convert.ToInt32(f["IdTratamiento"]),
                    codigo = Convert.ToString(f["Codigo"]),
                    nombre = Convert.ToString(f["Nombre"]),
                    descripcion = Convert.ToString(f["Descripcion"]),
                    precio = Convert.ToDecimal(f["Precio"]),
                    duracionMin = Convert.ToInt32(f["DuracionMin"]),
                    activo = Convert.ToBoolean(f["Activo"]),
                });
            }
            return lista;
        }

        /// <summary>
        /// Valida y guarda (registra si idTratamiento = 0, si no actualiza).
        /// Devuelve false con el motivo en <paramref name="mensaje"/> si algún dato no es válido.
        /// </summary>
        public bool mtdGuardarTratamiento(clsTratamiento t, out string mensaje)
        {
            t.nombre = (t.nombre ?? "").Trim();
            t.descripcion = (t.descripcion ?? "").Trim();

            mensaje = Validar(t);
            if (mensaje != null) return false;

            if (objTratamiento.mtdExisteNombre(t.nombre, t.idTratamiento))
            {
                mensaje = "Ya existe otro tratamiento llamado \"" + t.nombre + "\".";
                return false;
            }

            if (t.idTratamiento == 0)
                t.idTratamiento = objTratamiento.mtdRegistrarTratamiento(t);
            else
                objTratamiento.mtdActualizarTratamiento(t);

            mensaje = "";
            return true;
        }

        public void mtdDesactivarTratamiento(int idTratamiento)
        {
            objTratamiento.mtdDesactivarTratamiento(idTratamiento);
        }

        // Los límites coinciden con las columnas y CHECK de dbo.Tratamiento.
        private static string Validar(clsTratamiento t)
        {
            if (t.nombre == "")
                return "Ingrese el nombre del tratamiento.";
            if (t.nombre.Length > 100)
                return "El nombre admite como máximo 100 caracteres.";
            if (t.descripcion.Length > 300)
                return "La descripción admite como máximo 300 caracteres.";
            if (t.precio <= 0 || t.precio > 99999999.99m)
                return "Ingrese un precio mayor a 0.";
            if (decimal.Round(t.precio, 2) != t.precio)
                return "El precio admite como máximo 2 decimales.";
            if (t.duracionMin <= 0 || t.duracionMin > short.MaxValue)
                return "La duración debe ser mayor a 0 minutos.";
            return null;
        }
    }
}
