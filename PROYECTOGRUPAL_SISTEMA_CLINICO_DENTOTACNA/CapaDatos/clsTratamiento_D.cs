using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsTratamiento_D
    {
        clsConexion conexion = new clsConexion();
        public DataTable mtdListarTratamientos()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer = null;
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = conexion.mtdAbrirConexion();
                cmd.CommandText = "USP_ListarTratamientos";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            finally
            {
                if(leer != null)
                {
                    leer.Close();
                }
                cmd.Dispose();
                conexion.mtdAbrirConexion();
            }
        }
        public void mtdRegistrarTratamiento(clsTratamiento tratamiento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conexion.mtdAbrirConexion();
                cmd.CommandText = "USP_RegistrarTratamiento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", tratamiento.nombre);
                cmd.Parameters.AddWithValue("@precio", tratamiento.precio);
                cmd.Parameters.AddWithValue("@duracion", tratamiento.duracionMin);
                cmd.Parameters.AddWithValue("@descripcion", tratamiento.descripcion);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conexion.mtdCerrarConexion();
            }
        }
        public void mtdActualizarTratamiento(clsTratamiento tratamiento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conexion.mtdAbrirConexion();
                cmd.CommandText = "USP_ActualizarTratamiento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTratamiento", tratamiento.idTratamiento);
                cmd.Parameters.AddWithValue("@nombre", tratamiento.nombre);
                cmd.Parameters.AddWithValue("@precio", tratamiento.precio);
                cmd.Parameters.AddWithValue("@duracion", tratamiento.duracionMin);
                cmd.Parameters.AddWithValue("@descripcion", tratamiento.descripcion);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conexion.mtdCerrarConexion();
            }
        }
        public void mtdEliminarTratamiento(int idTratamiento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conexion.mtdAbrirConexion();
                cmd.CommandText = "USP_EliminarTratamiento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTratamiento", idTratamiento);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conexion.mtdCerrarConexion();
            }
        }
    }
}
