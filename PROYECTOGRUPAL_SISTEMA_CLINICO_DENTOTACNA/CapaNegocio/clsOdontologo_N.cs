using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    /// <summary>Reglas de negocio de los odontólogos. El formulario solo habla con esta clase.</summary>
    public class clsOdontologo_N
    {
        // Antes: "new clsOdontologo_N()" -> la clase se creaba a sí misma sin fin (StackOverflowException).
        private readonly clsOdontologo_D objOdontologo = new clsOdontologo_D();

        public List<clsOdontologo> mtdListarOdontologos()
        {
            List<clsOdontologo> lista = new List<clsOdontologo>();
            foreach (DataRow f in objOdontologo.mtdListarOdontologos().Rows)
            {
                lista.Add(new clsOdontologo
                {
                    idOdontologo = Convert.ToInt32(f["IdOdontologo"]),
                    codigo = Convert.ToString(f["Codigo"]),
                    nombres = Convert.ToString(f["Nombres"]),
                    apellidos = Convert.ToString(f["Apellidos"]),
                    numeroCOP = Convert.ToString(f["NumeroCOP"]),
                    telefono = Convert.ToString(f["Telefono"]),
                    correo = Convert.ToString(f["Correo"]),
                    idEspecialidad = Convert.ToInt32(f["IdEspecialidad"]),
                    especialidad = Convert.ToString(f["Especialidad"]),
                    activo = Convert.ToBoolean(f["Activo"]),
                });
            }
            return lista;
        }

        /// <summary>Columnas: IdEspecialidad, Nombre. Lista para usar como DataSource de un ComboBox.</summary>
        public DataTable mtdListarEspecialidades()
        {
            return objOdontologo.mtdListarEspecialidades();
        }

        /// <summary>
        /// Valida y guarda (registra si idOdontologo = 0, si no actualiza).
        /// Devuelve false con el motivo en <paramref name="mensaje"/> si algún dato no es válido.
        /// </summary>
        public bool mtdGuardarOdontologo(clsOdontologo o, out string mensaje)
        {
            o.nombres = (o.nombres ?? "").Trim();
            o.apellidos = (o.apellidos ?? "").Trim();
            o.numeroCOP = (o.numeroCOP ?? "").Trim();
            o.telefono = (o.telefono ?? "").Trim();
            o.correo = (o.correo ?? "").Trim();

            mensaje = Validar(o);
            if (mensaje != null) return false;

            if (objOdontologo.mtdExisteNumeroCOP(o.numeroCOP, o.idOdontologo))
            {
                mensaje = "Ya existe otro odontólogo con el N.° COP " + o.numeroCOP + ".";
                return false;
            }

            if (o.idOdontologo == 0)
                o.idOdontologo = objOdontologo.mtdRegistrarOdontologo(o);
            else
                objOdontologo.mtdActualizarOdontologo(o);

            mensaje = "";
            return true;
        }

        public void mtdDesactivarOdontologo(int idOdontologo)
        {
            objOdontologo.mtdDesactivarOdontologo(idOdontologo);
        }

        private static string Validar(clsOdontologo o)
        {
            if (o.nombres == "" || o.apellidos == "")
                return "Ingrese nombres y apellidos.";
            if (o.nombres.Length > 60 || o.apellidos.Length > 60)
                return "Nombres y apellidos admiten como máximo 60 caracteres cada uno.";
            if (o.numeroCOP == "" || o.numeroCOP.Length > 10 || !o.numeroCOP.All(char.IsDigit))
                return "El N.° COP debe tener solo números (máximo 10).";
            if (o.telefono.Length > 15 || !o.telefono.All(c => char.IsDigit(c) || c == ' ' || c == '+' || c == '-'))
                return "El teléfono solo admite números, espacios, + y - (máximo 15).";
            if (o.correo.Length > 100 || (o.correo != "" && !o.correo.Contains("@")))
                return "El correo no es válido.";
            if (o.idEspecialidad <= 0)
                return "Seleccione una especialidad.";
            return null;
        }
    }
}
