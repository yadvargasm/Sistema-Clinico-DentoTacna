using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsTratamiento_N
    {
        clsTratamiento_D objTratamiento = new clsTratamiento_D();
        public DataTable mtdListarTratamientos()
        {
            return objTratamiento.mtdListarTratamientos();
        }
        public void mtdActualizarTratamiento(clsTratamiento tratamiento)
        {
            objTratamiento.mtdActualizarTratamiento(tratamiento);
        }
        public void mtdRegistrarTratamiento(clsTratamiento tratamiento)
        {
            objTratamiento.mtdRegistrarTratamiento(tratamiento);
        }
        public void mtdEliminarTratamiento(int idTratamiento)
        {
            objTratamiento.mtdEliminarTratamiento(idTratamiento);
        }
    }
}
