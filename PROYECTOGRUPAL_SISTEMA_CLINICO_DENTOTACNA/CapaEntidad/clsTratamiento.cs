namespace CapaEntidad
{
    /// <summary>Un tratamiento del catálogo de la clínica (tabla dbo.Tratamiento).</summary>
    public class clsTratamiento
    {
        public int idTratamiento { get; set; }
        /// <summary>Código calculado por la BD (TR-01, TR-02...). Solo lectura.</summary>
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int duracionMin { get; set; }
        public bool activo { get; set; }
    }
}
