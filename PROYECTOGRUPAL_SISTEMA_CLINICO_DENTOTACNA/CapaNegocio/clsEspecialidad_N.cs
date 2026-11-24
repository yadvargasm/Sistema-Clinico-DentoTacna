using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsEspecialidad_N
    {
        clsEspecialidad_D objEspecialidad = new clsEspecialidad_D();
        public DataTable mtdListarEspecialidades()
        {
            return objEspecialidad.mtdListarEspecialidades();
        }
    }
}
