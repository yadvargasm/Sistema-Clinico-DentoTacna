using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsOdontologo
    {
        public int idOdontologo { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string numeroCOP { get; set; }
        public string telefono { get; set; }
        public int idEspecialidad { get; set; }
        public bool activo { get; set; }
    }
}
