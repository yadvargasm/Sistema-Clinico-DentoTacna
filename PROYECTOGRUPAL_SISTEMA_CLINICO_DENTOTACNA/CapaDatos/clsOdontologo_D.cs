using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    /// <summary>Acceso a dbo.Odontologo. Solo ejecuta procedimientos almacenados; las reglas van en CapaNegocio.</summary>
    public class clsOdontologo_D
    {
        private readonly clsConexion conexion = new clsConexion();

        public DataTable mtdListarOdontologos()
        {
            return Consultar("USP_ListarOdontologos");
        }

        public DataTable mtdListarEspecialidades()
        {
            return Consultar("USP_ListarEspecialidades");
        }

        /// <summary>True si el N.° COP ya pertenece a otro odontólogo (idExcluir = el que se edita, 0 si es nuevo).</summary>
        public bool mtdExisteNumeroCOP(string numeroCOP, int idExcluir)
        {
            using (SqlCommand cmd = CrearComando("USP_ExisteNumeroCOP"))
            {
                try
                {
                    cmd.Parameters.Add("@NumeroCOP", SqlDbType.VarChar, 10).Value = numeroCOP;
                    cmd.Parameters.Add("@IdOdontologo", SqlDbType.Int).Value = idExcluir > 0 ? (object)idExcluir : DBNull.Value;
                    cmd.Connection = conexion.mtdAbrirConexion();
                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        /// <summary>Inserta el odontólogo y devuelve el Id generado.</summary>
        public int mtdRegistrarOdontologo(clsOdontologo o)
        {
            using (SqlCommand cmd = CrearComando("USP_RegistrarOdontologo"))
            {
                try
                {
                    AgregarParametros(cmd, o);
                    SqlParameter id = cmd.Parameters.Add("@IdOdontologo", SqlDbType.Int);
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

        public void mtdActualizarOdontologo(clsOdontologo o)
        {
            using (SqlCommand cmd = CrearComando("USP_ActualizarOdontologo"))
            {
                try
                {
                    cmd.Parameters.Add("@IdOdontologo", SqlDbType.Int).Value = o.idOdontologo;
                    AgregarParametros(cmd, o);
                    cmd.Connection = conexion.mtdAbrirConexion();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conexion.mtdCerrarConexion();
                }
            }
        }

        public void mtdDesactivarOdontologo(int idOdontologo)
        {
            using (SqlCommand cmd = CrearComando("USP_DesactivarOdontologo"))
            {
                try
                {
                    cmd.Parameters.Add("@IdOdontologo", SqlDbType.Int).Value = idOdontologo;
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

        private DataTable Consultar(string procedimiento)
        {
            DataTable tabla = new DataTable();
            using (SqlCommand cmd = CrearComando(procedimiento))
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

        private static void AgregarParametros(SqlCommand cmd, clsOdontologo o)
        {
            cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar, 60).Value = o.nombres;
            cmd.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 60).Value = o.apellidos;
            cmd.Parameters.Add("@NumeroCOP", SqlDbType.VarChar, 10).Value = o.numeroCOP;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = Nulo(o.telefono);
            cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = Nulo(o.correo);
            cmd.Parameters.Add("@IdEspecialidad", SqlDbType.TinyInt).Value = o.idEspecialidad;
            cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = o.activo;
        }

        private static object Nulo(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? (object)DBNull.Value : valor;
        }
    }
}
