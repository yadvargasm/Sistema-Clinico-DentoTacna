using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    /// <summary>Catálogo de especialidades (para llenar ComboBox).</summary>
    public class clsEspecialidad_N
    {
        private readonly clsEspecialidad_D objEspecialidad = new clsEspecialidad_D();

        /// <summary>Columnas: IdEspecialidad, Nombre. Lista para usar como DataSource de un ComboBox.</summary>
        public DataTable mtdListarEspecialidades()
        {
            return objEspecialidad.mtdListarEspecialidades();
        }
    }
}
