using System;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    /// <summary>
    /// Datos de ejemplo de la versión 0.1 (los mismos del prototipo acordado con el doctor).
    /// SOLO para mostrar la interfaz mientras no exista la conexión a la base de datos.
    /// Cuando las capas estén listas, cada formulario debe leer de la Capa de Negocio y esta clase se elimina.
    /// </summary>
    internal static class DatosDemo
    {
        /// <summary>Fecha "de hoy" del prototipo.</summary>
        public static readonly DateTime Hoy = new DateTime(2026, 11, 22);

        /// <summary>Usuarios de prueba: usuario, nombre, rol, iniciales.</summary>
        public static readonly string[][] Usuarios =
        {
            new[] { "rtorres", "Rosa Torres", "Recepción", "RT" },
            new[] { "mquispe", "Dr. Martín Quispe", "Odontólogo", "MQ" },
            new[] { "admin", "Administrador", "Administrador", "AD" },
        };

        /// <summary>Código, nombre completo, N.° COP, especialidad, teléfono, estado.</summary>
        public static readonly object[][] Odontologos =
        {
            new object[] { "OD-01", "Dr. Martín Quispe Rojas", "24518", "Implantología", "987 220 145", "Activo" },
            new object[] { "OD-02", "Dra. Lucía Paredes Gil", "19876", "Ortodoncia", "952 301 774", "Activo" },
            new object[] { "OD-03", "Dra. Andrea Salazar Meza", "31204", "Odontopediatría", "945 662 018", "Activo" },
        };

        public static readonly string[] OdontologosCorto = { "Dr. M. Quispe", "Dra. L. Paredes", "Dra. A. Salazar" };
        public static readonly string[] OdontologosLargo = { "Dr. Martín Quispe", "Dra. Lucía Paredes", "Dra. Andrea Salazar" };
        public static readonly string[] OdontologosCop = { "Dr. Martín Quispe (COP 24518)", "Dra. Lucía Paredes (COP 19876)", "Dra. Andrea Salazar (COP 31204)" };

        public static readonly string[] Especialidades = { "Odontología general", "Ortodoncia", "Implantología", "Endodoncia", "Odontopediatría" };

        /// <summary>Código, tratamiento, duración (min), precio.</summary>
        public static readonly object[][] Tratamientos =
        {
            new object[] { "TR-01", "Limpieza y profilaxis", 30, 120m },
            new object[] { "TR-02", "Resina compuesta", 45, 180m },
            new object[] { "TR-03", "Radiografía periapical", 15, 35m },
            new object[] { "TR-04", "Endodoncia molar", 90, 450m },
            new object[] { "TR-05", "Extracción simple", 30, 150m },
            new object[] { "TR-06", "Corona de porcelana", 60, 950m },
            new object[] { "TR-07", "Control de ortodoncia", 30, 250m },
            new object[] { "TR-08", "Instalación de brackets", 90, 1800m },
            new object[] { "TR-09", "Implante dental", 120, 3500m },
            new object[] { "TR-10", "Blanqueamiento", 60, 380m },
        };

        public static readonly string[] EstadosCita = { "Programada", "Sin confirmar", "Confirmada", "En consulta", "Atendida", "Cancelada" };
        public static readonly string[] Programas = { "General", "Ortodoncia", "Implantes" };
        public static readonly string[] MetodosPago = { "Efectivo", "Tarjeta", "Yape", "Plin", "Transferencia" };
        public static readonly string[] Roles = { "Recepción", "Odontólogo", "Administrador" };

        /// <summary>Historia, paciente (Apellidos, Nombres), programa.</summary>
        public static readonly object[][] Pacientes =
        {
            new object[] { "HC-00015", "Huamán Ríos, Carmen", "General" },
            new object[] { "HC-00076", "Gutiérrez Paz, Ricardo", "Implantes" },
            new object[] { "HC-00137", "Chávez Romero, Sofía", "General" },
            new object[] { "HC-00229", "Salinas Mori, Diego", "Ortodoncia" },
            new object[] { "HC-00298", "Fernández Soto, Luis", "Ortodoncia" },
            new object[] { "HC-00360", "Mendoza Lazo, Jorge", "General" },
            new object[] { "HC-00402", "Pérez, Ana Lucía", "General" },
            new object[] { "HC-00482", "Castillo Ugarte, María Elena", "General" },
            new object[] { "HC-00511", "Castillo Vera, Pedro", "General" },
            new object[] { "HC-00517", "Muñoz Araya, Joaquín", "Implantes" },
            new object[] { "HC-00518", "Soto Fuentes, Camila", "General" },
        };

        /// <summary>Panel principal — hora, paciente, tratamiento, odontólogo, estado.</summary>
        public static readonly object[][] CitasHoy =
        {
            new object[] { "09:00", "Carmen Huamán Ríos", "Limpieza y profilaxis", "Dra. L. Paredes", "Atendida" },
            new object[] { "10:00", "Jorge Mendoza Lazo", "Endodoncia pieza 36", "Dr. M. Quispe", "Atendida" },
            new object[] { "11:30", "Valentina Rojas", "Sellantes", "Dra. A. Salazar", "Atendida" },
            new object[] { "15:00", "Luis Fernández Soto", "Control de ortodoncia", "Dra. L. Paredes", "En consulta" },
            new object[] { "16:00", "María Elena Castillo", "Resina pieza 14", "Dr. M. Quispe", "Confirmada" },
            new object[] { "17:00", "Ricardo Gutiérrez Paz", "Evaluación de implante", "Dr. M. Quispe", "Confirmada" },
            new object[] { "17:00", "Camila Soto Fuentes", "Primera consulta", "Dra. L. Paredes", "Sin confirmar" },
            new object[] { "18:00", "Ana Lucía Pérez", "Extracción pieza 48", "Dr. M. Quispe", "Sin confirmar" },
        };

        /// <summary>Panel principal — hora, paciente, teléfono, tratamiento, recordatorio.</summary>
        public static readonly object[][] RecordatoriosManana =
        {
            new object[] { "09:00", "Patricia Núñez Vela", "952 410 337", "Control de blanqueamiento", "Enviado" },
            new object[] { "10:30", "Diego Salinas Mori", "933 870 125", "Ajuste de brackets", "Enviado" },
            new object[] { "12:00", "Sofía Chávez Romero", "945 118 672", "Blanqueamiento", "Pendiente" },
            new object[] { "16:00", "Mateo Vargas", "998 230 441", "Sellantes", "Pendiente" },
            new object[] { "17:30", "Joaquín Muñoz Araya", "+56 9 8123 4567", "Control de implante", "Pendiente" },
        };

        /// <summary>Citas — N.°, fecha, hora, paciente, teléfono, tratamiento, odontólogo, estado, recordatorio.</summary>
        public static readonly object[][] Citas =
        {
            new object[] { "10231", "22/11/2026", "15:00", "Luis Fernández Soto", "987 451 220", "Control de ortodoncia", "Dra. L. Paredes", "En consulta", "Enviado" },
            new object[] { "10232", "22/11/2026", "16:00", "María Elena Castillo", "956 302 118", "Resina pieza 14", "Dr. M. Quispe", "Confirmada", "Enviado" },
            new object[] { "10233", "22/11/2026", "17:00", "Ricardo Gutiérrez Paz", "912 774 503", "Evaluación de implante", "Dr. M. Quispe", "Confirmada", "Enviado" },
            new object[] { "10234", "22/11/2026", "17:00", "Camila Soto Fuentes", "+56 9 7654 3210", "Primera consulta", "Dra. L. Paredes", "Sin confirmar", "Enviado" },
            new object[] { "10235", "22/11/2026", "18:00", "Ana Lucía Pérez", "961 554 307", "Extracción pieza 48", "Dr. M. Quispe", "Sin confirmar", "Enviado" },
            new object[] { "10236", "23/11/2026", "12:00", "Sofía Chávez Romero", "945 118 672", "Blanqueamiento", "Dra. L. Paredes", "Programada", "Pendiente" },
            new object[] { "10237", "23/11/2026", "17:30", "Joaquín Muñoz Araya", "+56 9 8123 4567", "Control de implante", "Dr. M. Quispe", "Programada", "Pendiente" },
        };

        /// <summary>Pacientes → Evolución — fecha, odontólogo, motivo, diagnóstico, procedimiento.</summary>
        public static readonly object[][] Evolucion =
        {
            new object[] { "05/11/2026", "Dr. M. Quispe", "Dolor al masticar", "Caries pieza 14", "Evaluación y radiografía" },
            new object[] { "12/09/2026", "Dr. M. Quispe", "Control", "Pulpitis irreversible 36", "Endodoncia 36" },
            new object[] { "03/04/2026", "Dra. L. Paredes", "Limpieza", "Gingivitis leve", "Profilaxis" },
        };

        /// <summary>Pagos — saldos del plan: tratamiento, pieza, fecha, total, a cuenta, saldo, seleccionado.</summary>
        public static readonly object[][] SaldosPlan =
        {
            new object[] { true, "Resina compuesta", "14", "22/11/2026", 180m, 0m },
            new object[] { true, "Radiografía periapical", "14", "05/11/2026", 35m, 0m },
            new object[] { false, "Corona de porcelana", "36", "—", 950m, 0m },
        };

        /// <summary>Pagos de hoy — hora, recibo, paciente, concepto, tipo, método, N.° operación, importe.</summary>
        public static readonly object[][] PagosHoy =
        {
            new object[] { "15:42", "R-004518", "Luis Fernández Soto", "Cuota ortodoncia", "A cuenta", "Yape", "08841523", 250m },
            new object[] { "12:10", "R-004517", "Valentina Rojas", "Sellantes", "Total", "Tarjeta", "VISA ···4417", 160m },
            new object[] { "11:05", "R-004516", "Jorge Mendoza Lazo", "Endodoncia 36", "Total", "Transferencia", "BCP 552301", 450m },
            new object[] { "10:30", "R-004515", "Carmen Huamán Ríos", "Limpieza", "Total", "Efectivo", "—", 120m },
            new object[] { "09:50", "R-004514", "Ricardo Gutiérrez Paz", "Implante pieza 46", "A cuenta", "Tarjeta", "MC ···2290", 1500m },
            new object[] { "09:15", "R-004513", "Patricia Núñez Vela", "Blanqueamiento", "Total", "Plin", "30019876", 380m },
        };

        /// <summary>Mantenimiento → Usuarios — usuario, nombre, rol, último ingreso, estado.</summary>
        public static readonly object[][] UsuariosTabla =
        {
            new object[] { "admin", "Administrador del sistema", "Administrador", "20/11/2026 12:44", "Activo" },
            new object[] { "mquispe", "Dr. Martín Quispe Rojas", "Odontólogo", "21/11/2026 18:10", "Activo" },
            new object[] { "rtorres", "Rosa Torres Lazo", "Recepción", "22/11/2026 08:00", "Activo" },
        };

        /// <summary>Las 12 preguntas de la anamnesis (hoja 1 de la ficha física).</summary>
        public static readonly string[] Anamnesis =
        {
            "Hipertensión arterial",
            "Antecedentes hemorrágicos",
            "Embarazo",
            "Antecedentes de síncope o desmayo",
            "Diabetes",
            "Enfermedades hepáticas",
            "Enfermedad renal",
            "Antecedentes cardiacos",
            "Angina de pecho",
            "Antecedentes de fiebre reumática",
            "¿Alergia a algún medicamento?",
            "¿Actualmente está tomando algún medicamento?",
        };
    }
}
