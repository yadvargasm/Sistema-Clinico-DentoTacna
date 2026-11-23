using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    /// <summary>
    /// Abre y cierra la conexión a SQL Server.
    /// La cadena se lee de App.config (connectionStrings, nombre "DentoTacnaDB"),
    /// así cada integrante del grupo puede apuntar a su propio servidor sin tocar el código.
    /// </summary>
    public class clsConexion
    {
        private const string NombreCadena = "DentoTacnaDB";

        private readonly SqlConnection conexion = new SqlConnection(ObtenerCadena());

        private static string ObtenerCadena()
        {
            ConnectionStringSettings cadena = ConfigurationManager.ConnectionStrings[NombreCadena];
            if (cadena == null || string.IsNullOrWhiteSpace(cadena.ConnectionString))
                throw new InvalidOperationException(
                    "Falta la cadena de conexión \"" + NombreCadena + "\" en App.config.");
            return cadena.ConnectionString;
        }

        public SqlConnection mtdAbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
            return conexion;
        }

        public SqlConnection mtdCerrarConexion()
        {
            if (conexion.State != ConnectionState.Closed)
                conexion.Close();
            return conexion;
        }
    }
}
