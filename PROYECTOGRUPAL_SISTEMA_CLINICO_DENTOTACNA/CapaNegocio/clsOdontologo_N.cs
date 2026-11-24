using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsOdontologo_N
    {
        clsOdontologo_D objOdontologo = new clsOdontologo_D();
        public DataTable mtdListarOdontologos()
        {
            return objOdontologo.mtdListarOdontologos();
        }
        public void mtdRegistrarOdontologo(clsOdontologo odontologo)
        {
            objOdontologo.mtdRegistrarOdontologo(odontologo);
        }
        public void mtdActualizarOdontologo(clsOdontologo odontologo)
        {
            objOdontologo.mtdActualizarOdontologo(odontologo);
        }
        public void mtdEliminarOdontologo(int idOdontologo)
        {
            objOdontologo.mtdEliminarOdontologo(idOdontologo);
        }
    }
}
