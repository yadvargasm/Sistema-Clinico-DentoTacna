namespace CapaEntidad
{
    /// <summary>Un odontólogo de la clínica (tabla dbo.Odontologo).</summary>
    public class clsOdontologo
    {
        public int idOdontologo { get; set; }
        /// <summary>Código calculado por la BD (OD-01, OD-02...). Solo lectura.</summary>
        public string codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string numeroCOP { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int idEspecialidad { get; set; }
        /// <summary>Nombre de la especialidad (viene del JOIN al listar). Solo lectura.</summary>
        public string especialidad { get; set; }
        public bool activo { get; set; }

        public string NombreCompleto
        {
            get { return (nombres + " " + apellidos).Trim(); }
        }
    }
}
