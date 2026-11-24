using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    /// <summary>Acceso a dbo.Especialidad (catálogo de solo lectura).</summary>
    public class clsEspecialidad_D
    {
        private readonly clsConexion conexion = new clsConexion();

        /// <summary>Columnas: IdEspecialidad, Nombre (solo activas).</summary>
        public DataTable mtdListarEspecialidades()
        {
            DataTable tabla = new DataTable();
            using (SqlCommand cmd = new SqlCommand("USP_ListarEspecialidades") { CommandType = CommandType.StoredProcedure })
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
                    conexion.mtdCerrarConexion();
                }
            }
        }
    }
}
