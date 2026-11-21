using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsOdontologo_N
    {
        clsOdontologo_N objOdontologo = new clsOdontologo_N();
        public DataTable mtdListarOdontologos()
        {
            return objOdontologo.mtdListarOdontologos();
        }
    }
}
