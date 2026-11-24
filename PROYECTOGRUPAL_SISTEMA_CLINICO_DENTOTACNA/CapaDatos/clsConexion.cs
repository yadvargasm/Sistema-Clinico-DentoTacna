using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class clsConexion
    {
        //modificar segun la base de datos de cada usuario
        SqlConnection conexion = new SqlConnection();
        //modificar segun la base de datos de cada usuario
        public SqlConnection mtdAbrirConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection mtdCerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
