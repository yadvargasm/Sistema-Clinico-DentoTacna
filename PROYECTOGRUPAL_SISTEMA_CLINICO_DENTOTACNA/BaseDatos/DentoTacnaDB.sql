/* =====================================================================
   DentoTacna Smart — Base de datos
   Motor: SQL Server / Azure SQL Database
   Versión del modelo: 2 (alineada con el prototipo DentoTacna v0.1)

   CÓMO USARLO
   - En Azure SQL: cree la base de datos desde el portal (ej. DentoTacnaDB),
     conéctese a ELLA y ejecute este script completo.
   - En SQL Server local: cree la base y selecciónela antes de ejecutar:
         CREATE DATABASE DentoTacnaDB;
         GO
         USE DentoTacnaDB;
         GO
   (No se usa USE aquí porque Azure SQL no permite cambiar de base con USE.)
   - Con sqlcmd agregue -I (QUOTED_IDENTIFIER, necesario por las columnas
     calculadas) y -f 65001 (para que las tildes se guarden bien).
   - El script crea las tablas desde cero: ejecútelo en una base VACÍA.

   ORGANIZACIÓN
   1.  Catálogos      -> listas fijas (roles, estados, métodos de pago...).
                         Para añadir una opción nueva basta un INSERT.
   2.  Seguridad      -> usuarios del sistema.
   3.  Mantenimiento  -> odontólogos y tratamientos.
   4.  Pacientes      -> datos personales, anamnesis, odontograma e imágenes.
   5.  Citas          -> agenda y recordatorios.
   6.  Historia clínica (evolución / atenciones).
   7.  Plan de tratamiento y consentimiento informado.
   8.  Pagos          -> recibos y a qué fila del plan se aplican.
   9.  Asistente IA   -> registro de consultas.
   10. Vistas         -> consultas listas para el panel, pagos y el asistente IA.
   11. Procedimientos -> USP_ (Odontólogo y Tratamiento).
   12. Datos iniciales.

   CONVENCIONES (para seguir añadiendo tablas)
   - Tablas en singular y PascalCase. Llave primaria: Id + NombreTabla.
   - Catálogos con Id TINYINT sin IDENTITY (los Id no cambian entre equipos,
     por eso algunas restricciones usan el Id directamente, ej. Efectivo = 1).
   - Columnas de auditoría: FechaRegistro, IdUsuarioRegistro.
   - Borrado lógico con la columna Activo (no se eliminan registros con historia).
   - Restricciones con nombre: PK_, FK_, UQ_, CK_, DF_, IX_.
   ===================================================================== */

SET NOCOUNT ON;
GO

/* =====================================================================
   1. CATÁLOGOS
   ===================================================================== */

CREATE TABLE dbo.Rol (
    IdRol           TINYINT       NOT NULL CONSTRAINT PK_Rol PRIMARY KEY,
    Nombre          NVARCHAR(50)  NOT NULL CONSTRAINT UQ_Rol_Nombre UNIQUE,
    Descripcion     NVARCHAR(200) NULL,
    Activo          BIT           NOT NULL CONSTRAINT DF_Rol_Activo DEFAULT (1)
);
GO

CREATE TABLE dbo.Especialidad (
    IdEspecialidad  TINYINT       NOT NULL CONSTRAINT PK_Especialidad PRIMARY KEY,
    Nombre          NVARCHAR(80)  NOT NULL CONSTRAINT UQ_Especialidad_Nombre UNIQUE,
    Activo          BIT           NOT NULL CONSTRAINT DF_Especialidad_Activo DEFAULT (1)
);
GO

CREATE TABLE dbo.EstadoCita (
    IdEstadoCita    TINYINT       NOT NULL CONSTRAINT PK_EstadoCita PRIMARY KEY,
    Nombre          NVARCHAR(30)  NOT NULL CONSTRAINT UQ_EstadoCita_Nombre UNIQUE,
    Orden           TINYINT       NOT NULL,
    OcupaHorario    BIT           NOT NULL CONSTRAINT DF_EstadoCita_OcupaHorario DEFAULT (1) -- 0 = la cita libera el horario (ej. Cancelada)
);
GO

CREATE TABLE dbo.EstadoPlan (
    IdEstadoPlan    TINYINT       NOT NULL CONSTRAINT PK_EstadoPlan PRIMARY KEY,
    Nombre          NVARCHAR(30)  NOT NULL CONSTRAINT UQ_EstadoPlan_Nombre UNIQUE,
    Orden           TINYINT       NOT NULL
);
GO

CREATE TABLE dbo.MetodoPago (
    IdMetodoPago      TINYINT      NOT NULL CONSTRAINT PK_MetodoPago PRIMARY KEY,
    Nombre            NVARCHAR(40) NOT NULL CONSTRAINT UQ_MetodoPago_Nombre UNIQUE,
    RequiereOperacion BIT          NOT NULL CONSTRAINT DF_MetodoPago_RequiereOperacion DEFAULT (1), -- pide N.° de operación / voucher
    Activo            BIT          NOT NULL CONSTRAINT DF_MetodoPago_Activo DEFAULT (1)
);
GO

-- DNI, RUT (Chile), Carnet de extranjería, Pasaporte.
CREATE TABLE dbo.TipoDocumento (
    IdTipoDocumento TINYINT       NOT NULL CONSTRAINT PK_TipoDocumento PRIMARY KEY,
    Codigo          VARCHAR(5)    NOT NULL CONSTRAINT UQ_TipoDocumento_Codigo UNIQUE,
    Nombre          NVARCHAR(40)  NOT NULL CONSTRAINT UQ_TipoDocumento_Nombre UNIQUE,
    LongitudMax     TINYINT       NOT NULL,
    Activo          BIT           NOT NULL CONSTRAINT DF_TipoDocumento_Activo DEFAULT (1)
);
GO

-- Programa del paciente: General, Ortodoncia, Implantes.
CREATE TABLE dbo.Programa (
    IdPrograma      TINYINT       NOT NULL CONSTRAINT PK_Programa PRIMARY KEY,
    Nombre          NVARCHAR(40)  NOT NULL CONSTRAINT UQ_Programa_Nombre UNIQUE,
    Activo          BIT           NOT NULL CONSTRAINT DF_Programa_Activo DEFAULT (1)
);
GO

-- Preguntas SÍ/NO de la anamnesis. TextoAlerta es lo que se muestra en la
-- ficha y en el panel cuando la respuesta es SÍ.
CREATE TABLE dbo.PreguntaAnamnesis (
    IdPregunta      TINYINT       NOT NULL CONSTRAINT PK_PreguntaAnamnesis PRIMARY KEY,
    Orden           TINYINT       NOT NULL,
    Pregunta        NVARCHAR(100) NOT NULL CONSTRAINT UQ_PreguntaAnamnesis_Pregunta UNIQUE,
    TextoAlerta     NVARCHAR(60)  NOT NULL,
    RequiereDetalle BIT           NOT NULL CONSTRAINT DF_PreguntaAnamnesis_RequiereDetalle DEFAULT (0),
    TextoAyuda      NVARCHAR(60)  NULL,   -- placeholder del detalle, ej. "¿A qué medicamento?"
    Activo          BIT           NOT NULL CONSTRAINT DF_PreguntaAnamnesis_Activo DEFAULT (1)
);
GO

-- Estados de una pieza en el odontograma.
CREATE TABLE dbo.EstadoPieza (
    IdEstadoPieza   TINYINT       NOT NULL CONSTRAINT PK_EstadoPieza PRIMARY KEY,
    Codigo          VARCHAR(20)   NOT NULL CONSTRAINT UQ_EstadoPieza_Codigo UNIQUE,
    Nombre          NVARCHAR(40)  NOT NULL CONSTRAINT UQ_EstadoPieza_Nombre UNIQUE,
    Orden           TINYINT       NOT NULL
);
GO

-- Radiografía, Foto, Documento.
CREATE TABLE dbo.TipoArchivo (
    IdTipoArchivo   TINYINT       NOT NULL CONSTRAINT PK_TipoArchivo PRIMARY KEY,
    Nombre          NVARCHAR(40)  NOT NULL CONSTRAINT UQ_TipoArchivo_Nombre UNIQUE
);
GO

/* =====================================================================
   2. SEGURIDAD
   ===================================================================== */

CREATE TABLE dbo.Usuario (
    IdUsuario       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Usuario PRIMARY KEY,
    IdRol           TINYINT       NOT NULL CONSTRAINT FK_Usuario_Rol REFERENCES dbo.Rol (IdRol),
    NombreUsuario   NVARCHAR(50)  NOT NULL CONSTRAINT UQ_Usuario_NombreUsuario UNIQUE,
    NombreCompleto  NVARCHAR(120) NOT NULL,
    -- Clave guardada como SHA-256 de (Sal + clave en UTF-16). Nunca en texto plano.
    -- En C#: SHA256(Sal || Encoding.Unicode.GetBytes(clave))
    ClaveHash       VARBINARY(32) NOT NULL,
    Sal             VARBINARY(16) NOT NULL,
    IdOdontologo    INT           NULL,   -- "Odontólogo vinculado" (FK más abajo)
    Activo          BIT           NOT NULL CONSTRAINT DF_Usuario_Activo DEFAULT (1),
    UltimoAcceso    DATETIME2(0)  NULL,   -- "Último ingreso"
    FechaRegistro   DATETIME2(0)  NOT NULL CONSTRAINT DF_Usuario_FechaRegistro DEFAULT (SYSDATETIME())
);
GO

/* =====================================================================
   3. MANTENIMIENTO
   ===================================================================== */

CREATE TABLE dbo.Odontologo (
    IdOdontologo    INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Odontologo PRIMARY KEY,
    Codigo          AS ('OD-' + RIGHT('00' + CONVERT(VARCHAR(10), IdOdontologo), 2)) PERSISTED,
    Nombres         NVARCHAR(60)  NOT NULL,
    Apellidos       NVARCHAR(60)  NOT NULL,
    NumeroCOP       VARCHAR(10)   NOT NULL CONSTRAINT UQ_Odontologo_NumeroCOP UNIQUE,
    Telefono        VARCHAR(15)   NULL,
    Correo          NVARCHAR(100) NULL,
    IdEspecialidad  TINYINT       NOT NULL CONSTRAINT FK_Odontologo_Especialidad REFERENCES dbo.Especialidad (IdEspecialidad),
    Activo          BIT           NOT NULL CONSTRAINT DF_Odontologo_Activo DEFAULT (1),
    FechaRegistro   DATETIME2(0)  NOT NULL CONSTRAINT DF_Odontologo_FechaRegistro DEFAULT (SYSDATETIME())
);
GO

ALTER TABLE dbo.Usuario
    ADD CONSTRAINT FK_Usuario_Odontologo FOREIGN KEY (IdOdontologo) REFERENCES dbo.Odontologo (IdOdontologo);
GO

CREATE TABLE dbo.Tratamiento (
    IdTratamiento   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Tratamiento PRIMARY KEY,
    Codigo          AS ('TR-' + RIGHT('00' + CONVERT(VARCHAR(10), IdTratamiento), 2)) PERSISTED,
    Nombre          NVARCHAR(100) NOT NULL CONSTRAINT UQ_Tratamiento_Nombre UNIQUE,
    Descripcion     NVARCHAR(300) NULL,
    Precio          DECIMAL(10,2) NOT NULL CONSTRAINT CK_Tratamiento_Precio CHECK (Precio >= 0),
    DuracionMin     SMALLINT      NOT NULL CONSTRAINT DF_Tratamiento_DuracionMin DEFAULT (30)
                                           CONSTRAINT CK_Tratamiento_DuracionMin CHECK (DuracionMin > 0),
    Activo          BIT           NOT NULL CONSTRAINT DF_Tratamiento_Activo DEFAULT (1),
    FechaRegistro   DATETIME2(0)  NOT NULL CONSTRAINT DF_Tratamiento_FechaRegistro DEFAULT (SYSDATETIME())
);
GO

/* =====================================================================
   4. PACIENTES
   ===================================================================== */

-- Pestaña "Datos personales".
-- El N.° de historia es correlativo y NO cambia aunque el paciente cambie de programa.
CREATE TABLE dbo.Paciente (
    IdPaciente              INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Paciente PRIMARY KEY,
    NumeroHistoria          AS ('HC-' + RIGHT('00000' + CONVERT(VARCHAR(10), IdPaciente), 5)) PERSISTED,
    IdTipoDocumento         TINYINT       NOT NULL CONSTRAINT FK_Paciente_TipoDocumento REFERENCES dbo.TipoDocumento (IdTipoDocumento)
                                                   CONSTRAINT DF_Paciente_IdTipoDocumento DEFAULT (1),
    NumeroDocumento         VARCHAR(12)   NOT NULL,
    FechaVerificacionReniec DATE          NULL,   -- "Datos verificados con RENIEC el ..."
    Nombres                 NVARCHAR(60)  NOT NULL,
    Apellidos               NVARCHAR(60)  NOT NULL,
    FechaNacimiento         DATE          NULL,   -- la edad se calcula, no se guarda
    Sexo                    CHAR(1)       NULL CONSTRAINT CK_Paciente_Sexo CHECK (Sexo IN ('F', 'M')),
    Telefono                VARCHAR(20)   NOT NULL,   -- admite +56 9 8123 4567
    Correo                  NVARCHAR(100) NULL,       -- "Dirección electrónica"
    Direccion               NVARCHAR(200) NULL,       -- "Domicilio"
    MotivoConsulta          NVARCHAR(300) NULL,
    IdPrograma              TINYINT       NOT NULL CONSTRAINT FK_Paciente_Programa REFERENCES dbo.Programa (IdPrograma)
                                                   CONSTRAINT DF_Paciente_IdPrograma DEFAULT (1),
    -- Responsable legal (solo para menores de edad).
    NombreResponsable       NVARCHAR(120) NULL,
    DNIResponsable          CHAR(8)       NULL CONSTRAINT CK_Paciente_DNIResponsable CHECK (DNIResponsable NOT LIKE '%[^0-9]%'),
    -- Anamnesis: pregunta 13 "Otros" (texto libre) y última actualización.
    AnamnesisOtros          NVARCHAR(500) NULL,
    FechaAnamnesis          DATETIME2(0)  NULL,
    IdOdontologoAnamnesis   INT           NULL CONSTRAINT FK_Paciente_OdontologoAnamnesis REFERENCES dbo.Odontologo (IdOdontologo),
    Activo                  BIT           NOT NULL CONSTRAINT DF_Paciente_Activo DEFAULT (1),
    FechaRegistro           DATETIME2(0)  NOT NULL CONSTRAINT DF_Paciente_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro       INT           NULL CONSTRAINT FK_Paciente_Usuario REFERENCES dbo.Usuario (IdUsuario),
    CONSTRAINT UQ_Paciente_Documento UNIQUE (IdTipoDocumento, NumeroDocumento),
    -- El DNI peruano (Id 1) son exactamente 8 dígitos.
    CONSTRAINT CK_Paciente_DNI CHECK (IdTipoDocumento <> 1
                                      OR (LEN(NumeroDocumento) = 8 AND NumeroDocumento NOT LIKE '%[^0-9]%'))
);
GO

CREATE INDEX IX_Paciente_Apellidos ON dbo.Paciente (Apellidos, Nombres);
GO

-- Pestaña "Anamnesis": una fila por pregunta respondida (SÍ o NO).
CREATE TABLE dbo.PacienteAnamnesis (
    IdPaciente      INT           NOT NULL CONSTRAINT FK_PacienteAnamnesis_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdPregunta      TINYINT       NOT NULL CONSTRAINT FK_PacienteAnamnesis_Pregunta REFERENCES dbo.PreguntaAnamnesis (IdPregunta),
    Respuesta       BIT           NOT NULL,   -- 1 = SÍ, 0 = NO
    Detalle         NVARCHAR(200) NULL,       -- ej. "Penicilina"
    CONSTRAINT PK_PacienteAnamnesis PRIMARY KEY (IdPaciente, IdPregunta)
);
GO

-- Pestaña "Odontograma": uno inicial (I) y uno final (F) por paciente.
CREATE TABLE dbo.Odontograma (
    IdOdontograma       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Odontograma PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Odontograma_Paciente REFERENCES dbo.Paciente (IdPaciente),
    Tipo                CHAR(1)       NOT NULL CONSTRAINT CK_Odontograma_Tipo CHECK (Tipo IN ('I', 'F')),
    Fecha               DATE          NOT NULL CONSTRAINT DF_Odontograma_Fecha DEFAULT (CONVERT(DATE, SYSDATETIME())),
    IdOdontologo        INT           NULL CONSTRAINT FK_Odontograma_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    Observaciones       NVARCHAR(500) NULL,
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_Odontograma_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Odontograma_Usuario REFERENCES dbo.Usuario (IdUsuario),
    CONSTRAINT UQ_Odontograma_PacienteTipo UNIQUE (IdPaciente, Tipo)
);
GO

-- Estado de cada pieza (notación FDI). Las piezas que no aparecen están sanas.
--   Permanentes: 11-18, 21-28, 31-38, 41-48.  Temporales: 51-55, 61-65, 71-75, 81-85.
CREATE TABLE dbo.OdontogramaPieza (
    IdOdontograma   INT           NOT NULL CONSTRAINT FK_OdontogramaPieza_Odontograma REFERENCES dbo.Odontograma (IdOdontograma),
    Pieza           TINYINT       NOT NULL,
    IdEstadoPieza   TINYINT       NOT NULL CONSTRAINT FK_OdontogramaPieza_EstadoPieza REFERENCES dbo.EstadoPieza (IdEstadoPieza),
    CONSTRAINT PK_OdontogramaPieza PRIMARY KEY (IdOdontograma, Pieza),
    CONSTRAINT CK_OdontogramaPieza_Pieza CHECK (
           (Pieza / 10 BETWEEN 1 AND 4 AND Pieza % 10 BETWEEN 1 AND 8)
        OR (Pieza / 10 BETWEEN 5 AND 8 AND Pieza % 10 BETWEEN 1 AND 5))
);
GO

-- Pestaña "Imágenes": radiografías, fotos y documentos guardados en la misma base
-- (así funciona igual en cualquier PC y en Azure, sin carpetas compartidas).
CREATE TABLE dbo.PacienteArchivo (
    IdArchivo           INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PacienteArchivo PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_PacienteArchivo_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdTipoArchivo       TINYINT       NOT NULL CONSTRAINT FK_PacienteArchivo_TipoArchivo REFERENCES dbo.TipoArchivo (IdTipoArchivo),
    Descripcion         NVARCHAR(150) NOT NULL,   -- ej. "Periapical pieza 14"
    Fecha               DATE          NOT NULL CONSTRAINT DF_PacienteArchivo_Fecha DEFAULT (CONVERT(DATE, SYSDATETIME())),
    NombreArchivo       NVARCHAR(200) NOT NULL,
    TipoContenido       VARCHAR(50)   NOT NULL CONSTRAINT CK_PacienteArchivo_TipoContenido
                                               CHECK (TipoContenido IN ('image/jpeg', 'image/png', 'application/pdf')),
    Contenido           VARBINARY(MAX) NOT NULL,
    Activo              BIT           NOT NULL CONSTRAINT DF_PacienteArchivo_Activo DEFAULT (1),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_PacienteArchivo_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_PacienteArchivo_Usuario REFERENCES dbo.Usuario (IdUsuario),
    CONSTRAINT CK_PacienteArchivo_Tamano CHECK (DATALENGTH(Contenido) <= 10485760)   -- máx. 10 MB
);
GO

CREATE INDEX IX_PacienteArchivo_Paciente ON dbo.PacienteArchivo (IdPaciente, Fecha DESC);
GO

/* =====================================================================
   5. CITAS
   ===================================================================== */

CREATE TABLE dbo.Cita (
    IdCita              INT IDENTITY(10000,1) NOT NULL CONSTRAINT PK_Cita PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Cita_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdOdontologo        INT           NOT NULL CONSTRAINT FK_Cita_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    IdTratamiento       INT           NOT NULL CONSTRAINT FK_Cita_Tratamiento REFERENCES dbo.Tratamiento (IdTratamiento),
    PiezaDental         VARCHAR(10)   NULL,   -- ej. "Endodoncia pieza 36"
    Fecha               DATE          NOT NULL,
    Hora                TIME(0)       NOT NULL,
    IdEstadoCita        TINYINT       NOT NULL CONSTRAINT FK_Cita_EstadoCita REFERENCES dbo.EstadoCita (IdEstadoCita)
                                               CONSTRAINT DF_Cita_IdEstadoCita DEFAULT (1),
    Observaciones       NVARCHAR(500) NULL,
    -- Recordatorio
    RecordarDiaAntes    BIT           NOT NULL CONSTRAINT DF_Cita_RecordarDiaAntes DEFAULT (1),
    MostrarEnPanel      BIT           NOT NULL CONSTRAINT DF_Cita_MostrarEnPanel DEFAULT (1),
    FechaRecordatorio   DATETIME2(0)  NULL,   -- cuándo se envió; NULL = pendiente
    RecordatorioEnviado AS (CONVERT(BIT, CASE WHEN FechaRecordatorio IS NULL THEN 0 ELSE 1 END)),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_Cita_FechaRegistro DEFAULT (SYSDATETIME()),
    FechaModificacion   DATETIME2(0)  NULL,
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Cita_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_Cita_Fecha ON dbo.Cita (Fecha, Hora) INCLUDE (IdPaciente, IdOdontologo, IdEstadoCita);
CREATE INDEX IX_Cita_Odontologo ON dbo.Cita (IdOdontologo, Fecha, Hora);
CREATE INDEX IX_Cita_Paciente ON dbo.Cita (IdPaciente, Fecha);
GO
-- Nota: evitar dos citas del mismo odontólogo a la misma hora se valida en la Capa de Negocio
-- usando EstadoCita.OcupaHorario (una cita cancelada libera el horario).

/* =====================================================================
   6. HISTORIA CLÍNICA (pestaña "Evolución")
   ===================================================================== */

CREATE TABLE dbo.Atencion (
    IdAtencion          INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Atencion PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Atencion_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdOdontologo        INT           NOT NULL CONSTRAINT FK_Atencion_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    IdCita              INT           NULL CONSTRAINT FK_Atencion_Cita REFERENCES dbo.Cita (IdCita),
    Fecha               DATE          NOT NULL CONSTRAINT DF_Atencion_Fecha DEFAULT (CONVERT(DATE, SYSDATETIME())),
    PiezaDental         VARCHAR(10)   NULL,
    Motivo              NVARCHAR(200) NOT NULL,
    Diagnostico         NVARCHAR(300) NOT NULL,
    Procedimiento       NVARCHAR(1000) NULL,
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_Atencion_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Atencion_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_Atencion_Paciente ON dbo.Atencion (IdPaciente, Fecha DESC);
CREATE INDEX IX_Atencion_Fecha ON dbo.Atencion (Fecha);
GO

/* =====================================================================
   7. PLAN DE TRATAMIENTO Y CONSENTIMIENTO
   ===================================================================== */

-- Cabecera: un paciente puede tener varios planes en el tiempo.
-- Observaciones = el texto del plan, ej. "1) Resina en pieza 14. 2) Corona..."
CREATE TABLE dbo.PlanTratamiento (
    IdPlan              INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PlanTratamiento PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_PlanTratamiento_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdOdontologo        INT           NULL CONSTRAINT FK_PlanTratamiento_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    FechaCreacion       DATE          NOT NULL CONSTRAINT DF_PlanTratamiento_FechaCreacion DEFAULT (CONVERT(DATE, SYSDATETIME())),
    Observaciones       NVARCHAR(500) NULL,
    Activo              BIT           NOT NULL CONSTRAINT DF_PlanTratamiento_Activo DEFAULT (1),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_PlanTratamiento_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_PlanTratamiento_Paciente ON dbo.PlanTratamiento (IdPaciente);
GO

-- Detalle: cada fila de la tabla del plan
-- (Fecha | Doctor | Tratamiento | Pieza | Total | A cuenta | Saldo | Firma).
-- "A cuenta" y "Saldo" NO se guardan: salen de los pagos (vista vw_PlanSaldo).
-- Todo lo que se cobra es una fila del plan, incluso una limpieza suelta.
CREATE TABLE dbo.PlanTratamientoDetalle (
    IdPlanDetalle       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PlanTratamientoDetalle PRIMARY KEY,
    IdPlan              INT           NOT NULL CONSTRAINT FK_PlanDetalle_Plan REFERENCES dbo.PlanTratamiento (IdPlan),
    IdTratamiento       INT           NOT NULL CONSTRAINT FK_PlanDetalle_Tratamiento REFERENCES dbo.Tratamiento (IdTratamiento),
    IdOdontologo        INT           NULL CONSTRAINT FK_PlanDetalle_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    Fecha               DATE          NULL,   -- NULL = aún sin fecha ("—")
    PiezaDental         VARCHAR(10)   NULL,
    Precio              DECIMAL(10,2) NOT NULL CONSTRAINT CK_PlanDetalle_Precio CHECK (Precio > 0), -- "Total": precio al momento de agregarlo
    FirmaPaciente       BIT           NOT NULL CONSTRAINT DF_PlanDetalle_FirmaPaciente DEFAULT (0),   -- "Paciente conforme"
    IdEstadoPlan        TINYINT       NOT NULL CONSTRAINT FK_PlanDetalle_EstadoPlan REFERENCES dbo.EstadoPlan (IdEstadoPlan)
                                               CONSTRAINT DF_PlanDetalle_IdEstadoPlan DEFAULT (1),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_PlanDetalle_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_PlanDetalle_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_PlanDetalle_Plan ON dbo.PlanTratamientoDetalle (IdPlan);
GO

-- Pestaña "Consentimiento": igual a la hoja física de la clínica.
CREATE TABLE dbo.Consentimiento (
    IdConsentimiento            INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Consentimiento PRIMARY KEY,
    IdPaciente                  INT            NOT NULL CONSTRAINT FK_Consentimiento_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdOdontologo                INT            NOT NULL CONSTRAINT FK_Consentimiento_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    IdPlan                      INT            NULL CONSTRAINT FK_Consentimiento_Plan REFERENCES dbo.PlanTratamiento (IdPlan),
    Diagnostico                 NVARCHAR(300)  NULL,
    Procedimiento               NVARCHAR(500)  NOT NULL,   -- en términos sencillos
    Riesgos                     NVARCHAR(500)  NULL,       -- riesgos, ventajas y beneficios
    Alternativas                NVARCHAR(300)  NULL,
    ConsecuenciasNoTratamiento  NVARCHAR(300)  NULL,
    -- Declaraciones del paciente
    ExplicacionClara            BIT            NOT NULL CONSTRAINT DF_Consentimiento_ExplicacionClara  DEFAULT (0),
    AutorizaRegistros           BIT            NOT NULL CONSTRAINT DF_Consentimiento_AutorizaRegistros DEFAULT (0), -- fotos, videos
    AceptaPresupuesto           BIT            NOT NULL CONSTRAINT DF_Consentimiento_AceptaPresupuesto DEFAULT (0),
    Firmado                     BIT            NOT NULL CONSTRAINT DF_Consentimiento_Firmado           DEFAULT (0),
    Lugar                       NVARCHAR(100)  NOT NULL CONSTRAINT DF_Consentimiento_Lugar DEFAULT (N'Tacna'),
    Fecha                       DATE           NOT NULL CONSTRAINT DF_Consentimiento_Fecha DEFAULT (CONVERT(DATE, SYSDATETIME())),
    FechaRegistro               DATETIME2(0)   NOT NULL CONSTRAINT DF_Consentimiento_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro           INT            NULL CONSTRAINT FK_Consentimiento_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_Consentimiento_Paciente ON dbo.Consentimiento (IdPaciente, Fecha DESC);
GO

/* =====================================================================
   8. PAGOS
   ===================================================================== */

-- Pago: el recibo. Puede cubrir varias filas del plan (ver PagoDetalle).
CREATE TABLE dbo.Pago (
    IdPago              INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Pago PRIMARY KEY,
    NumeroRecibo        AS ('R-' + RIGHT('000000' + CONVERT(VARCHAR(10), IdPago), 6)) PERSISTED,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Pago_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdMetodoPago        TINYINT       NOT NULL CONSTRAINT FK_Pago_MetodoPago REFERENCES dbo.MetodoPago (IdMetodoPago),
    TipoPago            CHAR(1)       NOT NULL CONSTRAINT CK_Pago_TipoPago CHECK (TipoPago IN ('T', 'C')), -- T = Pago total, C = A cuenta (parcial)
    NumeroOperacion     VARCHAR(30)   NULL,   -- Yape/Plin/transferencia, o voucher / últimos 4 dígitos de la tarjeta
    FechaHora           DATETIME2(0)  NOT NULL CONSTRAINT DF_Pago_FechaHora DEFAULT (SYSDATETIME()),
    Total               DECIMAL(10,2) NOT NULL CONSTRAINT CK_Pago_Total CHECK (Total > 0),   -- lo que se aplica al plan
    MontoRecibido       DECIMAL(10,2) NOT NULL,
    Vuelto              AS (MontoRecibido - Total) PERSISTED,
    Anulado             BIT           NOT NULL CONSTRAINT DF_Pago_Anulado DEFAULT (0),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Pago_Usuario REFERENCES dbo.Usuario (IdUsuario),
    CONSTRAINT CK_Pago_MontoRecibido CHECK (MontoRecibido >= Total),
    -- Solo el efectivo (Id 1) puede dar vuelto y no lleva N.° de operación.
    CONSTRAINT CK_Pago_Vuelto     CHECK (IdMetodoPago = 1 OR MontoRecibido = Total),
    CONSTRAINT CK_Pago_Operacion  CHECK (IdMetodoPago = 1 OR NumeroOperacion IS NOT NULL)
);
GO

CREATE UNIQUE INDEX UQ_Pago_NumeroRecibo ON dbo.Pago (NumeroRecibo);
CREATE INDEX IX_Pago_FechaHora ON dbo.Pago (FechaHora) INCLUDE (Total, Anulado);
CREATE INDEX IX_Pago_Paciente ON dbo.Pago (IdPaciente);
GO

-- Cuánto de cada fila del plan se pagó en cada recibo (permite pagos a cuenta).
-- La suma de PagoDetalle.Monto de un pago debe ser igual a Pago.Total (se valida en la Capa de Negocio).
CREATE TABLE dbo.PagoDetalle (
    IdPago              INT           NOT NULL CONSTRAINT FK_PagoDetalle_Pago REFERENCES dbo.Pago (IdPago),
    IdPlanDetalle       INT           NOT NULL CONSTRAINT FK_PagoDetalle_PlanDetalle REFERENCES dbo.PlanTratamientoDetalle (IdPlanDetalle),
    Monto               DECIMAL(10,2) NOT NULL CONSTRAINT CK_PagoDetalle_Monto CHECK (Monto > 0),
    CONSTRAINT PK_PagoDetalle PRIMARY KEY (IdPago, IdPlanDetalle)
);
GO

CREATE INDEX IX_PagoDetalle_PlanDetalle ON dbo.PagoDetalle (IdPlanDetalle) INCLUDE (Monto);
GO

/* =====================================================================
   9. ASISTENTE IA
   ===================================================================== */

-- Registro de preguntas y respuestas (historial y auditoría del asistente).
CREATE TABLE dbo.ConsultaAsistente (
    IdConsulta          INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ConsultaAsistente PRIMARY KEY,
    IdUsuario           INT           NOT NULL CONSTRAINT FK_ConsultaAsistente_Usuario REFERENCES dbo.Usuario (IdUsuario),
    Pregunta            NVARCHAR(1000) NOT NULL,
    Respuesta           NVARCHAR(MAX) NULL,
    FechaHora           DATETIME2(0)  NOT NULL CONSTRAINT DF_ConsultaAsistente_FechaHora DEFAULT (SYSDATETIME())
);
GO

CREATE INDEX IX_ConsultaAsistente_Usuario ON dbo.ConsultaAsistente (IdUsuario, FechaHora DESC);
GO

/* =====================================================================
   10. VISTAS
   Consultas ya armadas para el panel principal, pagos y el asistente IA.
   El asistente IA debería leer SOLO de estas vistas (ver sección final).
   ===================================================================== */

-- Alertas de la anamnesis por paciente, ej. "alergia a medicamento (Penicilina) · hipertensión arterial".
CREATE VIEW dbo.vw_AlertasPaciente
AS
SELECT  p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos AS Paciente,
        STUFF((SELECT N' · ' + q.TextoAlerta + ISNULL(N' (' + a.Detalle + N')', N'')
               FROM   dbo.PacienteAnamnesis a
               JOIN   dbo.PreguntaAnamnesis q ON q.IdPregunta = a.IdPregunta
               WHERE  a.IdPaciente = p.IdPaciente AND a.Respuesta = 1
               ORDER BY q.Orden
               FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 3, N'') AS Alertas
FROM    dbo.Paciente p
WHERE   EXISTS (SELECT 1 FROM dbo.PacienteAnamnesis a
                WHERE a.IdPaciente = p.IdPaciente AND a.Respuesta = 1);
GO

CREATE VIEW dbo.vw_Citas
AS
SELECT  c.IdCita,
        c.Fecha,
        c.Hora,
        p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos       AS Paciente,
        p.NumeroDocumento,
        p.Telefono,
        pr.Nombre                             AS Programa,
        t.IdTratamiento,
        t.Nombre + ISNULL(N' pieza ' + c.PiezaDental, N'') AS Tratamiento,
        t.DuracionMin,
        o.IdOdontologo,
        o.Nombres + N' ' + o.Apellidos       AS Odontologo,
        e.IdEstadoCita,
        e.Nombre                              AS Estado,
        c.Observaciones,
        c.RecordarDiaAntes,
        c.MostrarEnPanel,
        c.FechaRecordatorio,
        CASE WHEN c.RecordarDiaAntes = 0     THEN N'No aplica'
             WHEN c.FechaRecordatorio IS NULL THEN N'Pendiente'
             ELSE N'Enviado' END              AS Recordatorio
FROM    dbo.Cita c
JOIN    dbo.Paciente    p  ON p.IdPaciente    = c.IdPaciente
JOIN    dbo.Programa    pr ON pr.IdPrograma   = p.IdPrograma
JOIN    dbo.Odontologo  o  ON o.IdOdontologo  = c.IdOdontologo
JOIN    dbo.Tratamiento t  ON t.IdTratamiento = c.IdTratamiento
JOIN    dbo.EstadoCita  e  ON e.IdEstadoCita  = c.IdEstadoCita;
GO

-- Cada fila del plan con lo pagado (A cuenta) y lo que falta (Saldo).
-- No incluye las filas canceladas (IdEstadoPlan = 4) ni los planes inactivos.
CREATE VIEW dbo.vw_PlanSaldo
AS
SELECT  d.IdPlanDetalle,
        d.IdPlan,
        pl.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos            AS Paciente,
        d.Fecha,
        o.Nombres + N' ' + o.Apellidos            AS Odontologo,
        t.Nombre                                   AS Tratamiento,
        d.PiezaDental,
        d.Precio                                   AS Total,
        ISNULL(pg.Pagado, 0)                       AS ACuenta,
        d.Precio - ISNULL(pg.Pagado, 0)            AS Saldo,
        d.FirmaPaciente,
        ep.Nombre                                  AS Estado
FROM    dbo.PlanTratamientoDetalle d
JOIN    dbo.PlanTratamiento pl ON pl.IdPlan        = d.IdPlan
JOIN    dbo.Paciente        p  ON p.IdPaciente     = pl.IdPaciente
JOIN    dbo.Tratamiento     t  ON t.IdTratamiento  = d.IdTratamiento
JOIN    dbo.EstadoPlan      ep ON ep.IdEstadoPlan  = d.IdEstadoPlan
LEFT JOIN dbo.Odontologo    o  ON o.IdOdontologo   = d.IdOdontologo
OUTER APPLY (
        SELECT SUM(x.Monto) AS Pagado
        FROM   dbo.PagoDetalle x
        JOIN   dbo.Pago pa ON pa.IdPago = x.IdPago
        WHERE  x.IdPlanDetalle = d.IdPlanDetalle AND pa.Anulado = 0
) pg
WHERE   pl.Activo = 1
  AND   d.IdEstadoPlan <> 4;
GO

-- Saldo total por paciente (solo los que deben algo).
CREATE VIEW dbo.vw_SaldoPaciente
AS
SELECT  IdPaciente,
        NumeroHistoria,
        Paciente,
        SUM(Total)   AS Total,
        SUM(ACuenta) AS TotalPagado,
        SUM(Saldo)   AS Saldo
FROM    dbo.vw_PlanSaldo
GROUP BY IdPaciente, NumeroHistoria, Paciente
HAVING  SUM(Saldo) > 0;
GO

CREATE VIEW dbo.vw_Pagos
AS
SELECT  pa.IdPago,
        pa.NumeroRecibo,
        pa.FechaHora,
        CONVERT(DATE, pa.FechaHora)          AS Fecha,
        CONVERT(TIME(0), pa.FechaHora)       AS Hora,
        p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos       AS Paciente,
        STUFF((SELECT N', ' + t.Nombre + ISNULL(N' ' + d.PiezaDental, N'')
               FROM   dbo.PagoDetalle x
               JOIN   dbo.PlanTratamientoDetalle d ON d.IdPlanDetalle = x.IdPlanDetalle
               JOIN   dbo.Tratamiento t ON t.IdTratamiento = d.IdTratamiento
               WHERE  x.IdPago = pa.IdPago
               FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, N'') AS Concepto,
        CASE pa.TipoPago WHEN 'T' THEN N'Total' ELSE N'A cuenta' END AS Tipo,
        m.Nombre                              AS Metodo,
        pa.NumeroOperacion,
        pa.Total                              AS Importe,
        pa.MontoRecibido,
        pa.Vuelto
FROM    dbo.Pago pa
JOIN    dbo.Paciente   p ON p.IdPaciente   = pa.IdPaciente
JOIN    dbo.MetodoPago m ON m.IdMetodoPago = pa.IdMetodoPago
WHERE   pa.Anulado = 0;
GO

CREATE VIEW dbo.vw_Atenciones
AS
SELECT  a.IdAtencion,
        a.Fecha,
        p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos       AS Paciente,
        o.Nombres + N' ' + o.Apellidos       AS Odontologo,
        a.PiezaDental,
        a.Motivo,
        a.Diagnostico,
        a.Procedimiento,
        a.IdCita
FROM    dbo.Atencion a
JOIN    dbo.Paciente   p ON p.IdPaciente   = a.IdPaciente
JOIN    dbo.Odontologo o ON o.IdOdontologo = a.IdOdontologo;
GO

/* =====================================================================
   11. PROCEDIMIENTOS ALMACENADOS
   Se usa CREATE OR ALTER: si ya tienen la base creada, pueden ejecutar
   solo esta sección para agregar o actualizar los procedimientos.
   ===================================================================== */

-- ---------------------------------------------------------- Odontólogos

CREATE OR ALTER PROCEDURE dbo.USP_ListarEspecialidades
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdEspecialidad, Nombre
    FROM   dbo.Especialidad
    WHERE  Activo = 1
    ORDER BY Nombre;
END
GO

CREATE OR ALTER PROCEDURE dbo.USP_ListarOdontologos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT  o.IdOdontologo, o.Codigo, o.Nombres, o.Apellidos, o.NumeroCOP,
            o.Telefono, o.Correo, o.IdEspecialidad, e.Nombre AS Especialidad, o.Activo
    FROM    dbo.Odontologo o
    JOIN    dbo.Especialidad e ON e.IdEspecialidad = o.IdEspecialidad
    ORDER BY o.IdOdontologo;
END
GO

-- Devuelve 1 si el N.° COP ya lo usa OTRO odontólogo (@IdOdontologo = el que se edita, o NULL si es nuevo).
CREATE OR ALTER PROCEDURE dbo.USP_ExisteNumeroCOP
    @NumeroCOP     VARCHAR(10),
    @IdOdontologo  INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CASE WHEN EXISTS (SELECT 1 FROM dbo.Odontologo
                             WHERE NumeroCOP = @NumeroCOP
                               AND (@IdOdontologo IS NULL OR IdOdontologo <> @IdOdontologo))
                THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END;
END
GO

CREATE OR ALTER PROCEDURE dbo.USP_RegistrarOdontologo
    @Nombres         NVARCHAR(60),
    @Apellidos       NVARCHAR(60),
    @NumeroCOP       VARCHAR(10),
    @Telefono        VARCHAR(15)   = NULL,
    @Correo          NVARCHAR(100) = NULL,
    @IdEspecialidad  TINYINT,
    @Activo          BIT = 1,
    @IdOdontologo    INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Odontologo (Nombres, Apellidos, NumeroCOP, Telefono, Correo, IdEspecialidad, Activo)
    VALUES (@Nombres, @Apellidos, @NumeroCOP, @Telefono, @Correo, @IdEspecialidad, @Activo);
    SET @IdOdontologo = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE dbo.USP_ActualizarOdontologo
    @IdOdontologo    INT,
    @Nombres         NVARCHAR(60),
    @Apellidos       NVARCHAR(60),
    @NumeroCOP       VARCHAR(10),
    @Telefono        VARCHAR(15)   = NULL,
    @Correo          NVARCHAR(100) = NULL,
    @IdEspecialidad  TINYINT,
    @Activo          BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Odontologo
    SET    Nombres = @Nombres, Apellidos = @Apellidos, NumeroCOP = @NumeroCOP,
           Telefono = @Telefono, Correo = @Correo, IdEspecialidad = @IdEspecialidad, Activo = @Activo
    WHERE  IdOdontologo = @IdOdontologo;
END
GO

-- Borrado lógico: el odontólogo tiene citas y atenciones asociadas, no se elimina.
CREATE OR ALTER PROCEDURE dbo.USP_DesactivarOdontologo
    @IdOdontologo INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Odontologo SET Activo = 0 WHERE IdOdontologo = @IdOdontologo;
END
GO

-- --------------------------------------------------------- Tratamientos

-- Solo los activos: los desactivados ya no se ofrecen en citas ni planes.
CREATE OR ALTER PROCEDURE dbo.USP_ListarTratamientos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT  IdTratamiento, Codigo, Nombre, Descripcion, Precio, DuracionMin, Activo
    FROM    dbo.Tratamiento
    WHERE   Activo = 1
    ORDER BY IdTratamiento;
END
GO

-- Devuelve 1 si el nombre ya lo usa OTRO tratamiento (@IdTratamiento = el que se edita, o NULL si es nuevo).
-- Incluye los inactivos porque la columna Nombre es UNIQUE en toda la tabla.
CREATE OR ALTER PROCEDURE dbo.USP_ExisteNombreTratamiento
    @Nombre         NVARCHAR(100),
    @IdTratamiento  INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CASE WHEN EXISTS (SELECT 1 FROM dbo.Tratamiento
                             WHERE Nombre = @Nombre
                               AND (@IdTratamiento IS NULL OR IdTratamiento <> @IdTratamiento))
                THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END;
END
GO

CREATE OR ALTER PROCEDURE dbo.USP_RegistrarTratamiento
    @Nombre         NVARCHAR(100),
    @Descripcion    NVARCHAR(300) = NULL,
    @Precio         DECIMAL(10,2),
    @DuracionMin    SMALLINT,
    @IdTratamiento  INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Tratamiento (Nombre, Descripcion, Precio, DuracionMin)
    VALUES (@Nombre, @Descripcion, @Precio, @DuracionMin);
    SET @IdTratamiento = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE dbo.USP_ActualizarTratamiento
    @IdTratamiento  INT,
    @Nombre         NVARCHAR(100),
    @Descripcion    NVARCHAR(300) = NULL,
    @Precio         DECIMAL(10,2),
    @DuracionMin    SMALLINT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Tratamiento
    SET    Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, DuracionMin = @DuracionMin
    WHERE  IdTratamiento = @IdTratamiento;
END
GO

-- Borrado lógico: las citas y planes de tratamiento lo referencian, no se elimina.
CREATE OR ALTER PROCEDURE dbo.USP_DesactivarTratamiento
    @IdTratamiento INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Tratamiento SET Activo = 0 WHERE IdTratamiento = @IdTratamiento;
END
GO

/* =====================================================================
   12. DATOS INICIALES
   ===================================================================== */

INSERT INTO dbo.Rol (IdRol, Nombre, Descripcion) VALUES
    (1, N'Administrador', N'Acceso total, incluido Mantenimiento'),
    (2, N'Recepción',     N'Citas, pacientes y pagos'),
    (3, N'Odontólogo',    N'Agenda propia, atenciones y planes de tratamiento');

INSERT INTO dbo.Especialidad (IdEspecialidad, Nombre) VALUES
    (1, N'Odontología general'), (2, N'Ortodoncia'), (3, N'Endodoncia'),
    (4, N'Odontopediatría'), (5, N'Periodoncia'), (6, N'Cirugía oral'),
    (7, N'Implantología');

INSERT INTO dbo.EstadoCita (IdEstadoCita, Nombre, Orden, OcupaHorario) VALUES
    (1, N'Programada',    1, 1),
    (2, N'Sin confirmar', 2, 1),
    (3, N'Confirmada',    3, 1),
    (4, N'En consulta',   4, 1),
    (5, N'Atendida',      5, 1),
    (6, N'Cancelada',     6, 0);

INSERT INTO dbo.EstadoPlan (IdEstadoPlan, Nombre, Orden) VALUES
    (1, N'Pendiente', 1), (2, N'En curso', 2), (3, N'Terminado', 3), (4, N'Cancelado', 4);

-- Efectivo debe ser el Id 1 (lo usan CK_Pago_Vuelto y CK_Pago_Operacion).
INSERT INTO dbo.MetodoPago (IdMetodoPago, Nombre, RequiereOperacion) VALUES
    (1, N'Efectivo', 0), (2, N'Tarjeta', 1), (3, N'Yape', 1), (4, N'Plin', 1), (5, N'Transferencia', 1);

-- DNI debe ser el Id 1 (lo usa CK_Paciente_DNI).
INSERT INTO dbo.TipoDocumento (IdTipoDocumento, Codigo, Nombre, LongitudMax) VALUES
    (1, 'DNI', N'DNI',                   8),
    (2, 'RUT', N'RUT (Chile)',          12),
    (3, 'CE',  N'Carnet de extranjería', 12),
    (4, 'PAS', N'Pasaporte',            12);

INSERT INTO dbo.Programa (IdPrograma, Nombre) VALUES
    (1, N'General'), (2, N'Ortodoncia'), (3, N'Implantes');

INSERT INTO dbo.PreguntaAnamnesis (IdPregunta, Orden, Pregunta, TextoAlerta, RequiereDetalle, TextoAyuda) VALUES
    ( 1,  1, N'Hipertensión arterial',                         N'hipertensión arterial',    0, NULL),
    ( 2,  2, N'Antecedentes hemorrágicos',                     N'antecedentes hemorrágicos', 0, NULL),
    ( 3,  3, N'Embarazo',                                      N'embarazo',                 0, NULL),
    ( 4,  4, N'Antecedentes de síncope o desmayo',             N'síncope o desmayos',       0, NULL),
    ( 5,  5, N'Diabetes',                                      N'diabetes',                 0, NULL),
    ( 6,  6, N'Enfermedades hepáticas',                        N'enfermedad hepática',      0, NULL),
    ( 7,  7, N'Enfermedad renal',                              N'enfermedad renal',         0, NULL),
    ( 8,  8, N'Antecedentes cardiacos',                        N'antecedentes cardiacos',   0, NULL),
    ( 9,  9, N'Angina de pecho',                               N'angina de pecho',          0, NULL),
    (10, 10, N'Antecedentes de fiebre reumática',              N'fiebre reumática',         0, NULL),
    (11, 11, N'¿Alergia a algún medicamento?',                 N'alergia a medicamento',    1, N'¿A qué medicamento?'),
    (12, 12, N'¿Actualmente está tomando algún medicamento?',  N'toma medicamento',         1, N'¿Qué medicamento y dosis?');

INSERT INTO dbo.EstadoPieza (IdEstadoPieza, Codigo, Nombre, Orden) VALUES
    (1, 'sano',       N'Sano',                1),
    (2, 'caries',     N'Caries',              2),
    (3, 'restaurado', N'Restaurado',          3),
    (4, 'endodoncia', N'Endodoncia',          4),
    (5, 'corona',     N'Corona',              5),
    (6, 'implante',   N'Implante',            6),
    (7, 'brackets',   N'Bracket',             7),
    (8, 'extraccion', N'Extracción indicada', 8),
    (9, 'ausente',    N'Ausente',             9);

INSERT INTO dbo.TipoArchivo (IdTipoArchivo, Nombre) VALUES
    (1, N'Radiografía'), (2, N'Foto'), (3, N'Documento');

-- Mismo orden que el catálogo del prototipo: TR-01 a TR-10.
INSERT INTO dbo.Tratamiento (Nombre, Descripcion, Precio, DuracionMin) VALUES
    (N'Limpieza y profilaxis',   N'Limpieza dental profesional',               120.00,  30),
    (N'Resina compuesta',        N'Restauración estética de una pieza dental',  180.00,  45),
    (N'Radiografía periapical',  N'Radiografía de una pieza dental',             35.00,  15),
    (N'Endodoncia molar',        N'Tratamiento de conducto en molar',           450.00,  90),
    (N'Extracción simple',       N'Extracción de pieza dental',                 150.00,  30),
    (N'Corona de porcelana',     N'Corona estética de porcelana',               950.00,  60),
    (N'Control de ortodoncia',   N'Control y ajuste mensual de brackets',       250.00,  30),
    (N'Instalación de brackets', N'Colocación de brackets superiores e inferiores', 1800.00, 90),
    (N'Implante dental',         N'Colocación de implante de titanio',         3500.00, 120),
    (N'Blanqueamiento',          N'Blanqueamiento dental en consultorio',       380.00,  60),
    -- Usados en citas y pagos del prototipo (precios de Control de implante: referencial).
    (N'Primera consulta',        N'Evaluación inicial del paciente',             50.00,  30),
    (N'Sellantes',               N'Sellado de fosas y fisuras',                 160.00,  30),
    (N'Control de implante',     N'Control posterior a la colocación del implante', 100.00, 30);
GO

-- Usuario administrador inicial (SOLO PARA DESARROLLO).
--   Usuario: admin    Clave: Admin123*
--   Cámbienla en cuanto el login funcione.
DECLARE @sal VARBINARY(16) = CRYPT_GEN_RANDOM(16);
INSERT INTO dbo.Usuario (IdRol, NombreUsuario, NombreCompleto, ClaveHash, Sal)
VALUES (1, N'admin', N'Administrador del sistema',
        HASHBYTES('SHA2_256', @sal + CONVERT(VARBINARY(MAX), N'Admin123*')), @sal);
GO

/* =====================================================================
   USUARIO DE SOLO LECTURA PARA EL ASISTENTE IA (opcional)
   Así el asistente nunca puede modificar datos. Ejecutar aparte,
   cambiando la clave. En Azure SQL, conectado a ESTA base de datos:

   CREATE USER asistente_ia WITH PASSWORD = '<<clave segura>>';
   GRANT SELECT ON dbo.vw_Citas           TO asistente_ia;
   GRANT SELECT ON dbo.vw_PlanSaldo       TO asistente_ia;
   GRANT SELECT ON dbo.vw_SaldoPaciente   TO asistente_ia;
   GRANT SELECT ON dbo.vw_Pagos           TO asistente_ia;
   GRANT SELECT ON dbo.vw_Atenciones      TO asistente_ia;
   GRANT SELECT ON dbo.vw_AlertasPaciente TO asistente_ia;

   (En SQL Server local primero se crea el LOGIN en master y luego
    CREATE USER asistente_ia FOR LOGIN asistente_ia;)
   ===================================================================== */
