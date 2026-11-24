using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    /// <summary>Acceso a dbo.Tratamiento. Solo ejecuta procedimientos almacenados; las reglas van en CapaNegocio.</summary>
    public class clsTratamiento_D
    {
        private readonly clsConexion conexion = new clsConexion();

        /// <summary>Columnas: IdTratamiento, Codigo, Nombre, Descripcion, Precio, DuracionMin, Activo (solo activos).</summary>
        public DataTable mtdListarTratamientos()
        {
            DataTable tabla = new DataTable();
            using (SqlCommand cmd = CrearComando("USP_ListarTratamientos"))
            {
                try
                {
                    cmd.Connection = conexion.mtdAbrirConexion();
                    using (SqlDataReader leer = cmd.ExecuteReader())
                    {
                        tabla.Load(leer);
                    }
                    return tabla;
                }
                finally
                {
                    // En la versión original aquí se llamaba a mtdAbrirConexion() y la conexión nunca se cerraba.
                    conexion.mtdCerrarConexion();
                }
            }
        }

        /// <summary>True si el nombre ya lo usa OTRO tratamiento (idExcluir = el que se edita, 0 si es nuevo).</summary>
        public bool mtdExisteNombre(string nombre, int idExcluir)
        {
            using (SqlCommand cmd = CrearComando("USP_ExisteNombreTratamiento"))
            {
                try
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = nombre;
                    cmd.Parameters.Add("@IdTratamiento", SqlDbType.Int).Value = idExcluir > 0 ? (object)idExcluir : DBNull.Value;
                    cmd.Connection = conexion.mtdAbrirConexion();
                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        /// <summary>Inserta el tratamiento y devuelve el Id generado.</summary>
        public int mtdRegistrarTratamiento(clsTratamiento t)
        {
            using (SqlCommand cmd = CrearComando("USP_RegistrarTratamiento"))
            {
                try
                {
                    AgregarParametros(cmd, t);
                    SqlParameter id = cmd.Parameters.Add("@IdTratamiento", SqlDbType.Int);
                    id.Direction = ParameterDirection.Output;
                    cmd.Connection = conexion.mtdAbrirConexion();
                    cmd.ExecuteNonQuery();
                    return Convert.ToInt32(id.Value);
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        public void mtdActualizarTratamiento(clsTratamiento t)
        {
            using (SqlCommand cmd = CrearComando("USP_ActualizarTratamiento"))
            {
                try
                {
                    cmd.Parameters.Add("@IdTratamiento", SqlDbType.Int).Value = t.idTratamiento;
                    AgregarParametros(cmd, t);
                    cmd.Connection = conexion.mtdAbrirConexion();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        /// <summary>Borrado lógico (Activo = 0): las citas y planes guardan referencia al tratamiento.</summary>
        public void mtdDesactivarTratamiento(int idTratamiento)
        {
            using (SqlCommand cmd = CrearComando("USP_DesactivarTratamiento"))
            {
                try
                {
                    cmd.Parameters.Add("@IdTratamiento", SqlDbType.Int).Value = idTratamiento;
                    cmd.Connection = conexion.mtdAbrirConexion();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        // ------------------------------------------------------------ Auxiliares

        private static SqlCommand CrearComando(string procedimiento)
        {
            return new SqlCommand(procedimiento) { CommandType = CommandType.StoredProcedure };
        }

        private static void AgregarParametros(SqlCommand cmd, clsTratamiento t)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = t.nombre;
            cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 300).Value =
                string.IsNullOrWhiteSpace(t.descripcion) ? (object)DBNull.Value : t.descripcion;
            SqlParameter precio = cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
            precio.Precision = 10;
            precio.Scale = 2;
            precio.Value = t.precio;
            cmd.Parameters.Add("@DuracionMin", SqlDbType.SmallInt).Value = t.duracionMin;
        }
    }
}
