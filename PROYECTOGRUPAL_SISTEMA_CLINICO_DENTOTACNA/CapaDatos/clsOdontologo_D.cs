using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsOdontologo_D
    {
        clsConexion conexion = new clsConexion();
        public DataTable mtdListarOdontologos()
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader leer = null;
            try
            {
                cmd.Connection = conexion.mtdAbrirConexion();
                cmd.CommandText = "USP_ListarOdontologos";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }
                cmd.Dispose();
                conexion.mtdCerrarConexion();
            }
        }
    }
}
