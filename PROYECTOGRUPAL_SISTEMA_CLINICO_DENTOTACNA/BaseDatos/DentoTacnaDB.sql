/* =====================================================================
   DentoTacna Smart — Base de datos
   Motor: SQL Server / Azure SQL Database

   CÓMO USARLO
   - En Azure SQL: cree la base de datos desde el portal (ej. DentoTacnaDB),
     conéctese a ELLA y ejecute este script completo.
   - En SQL Server local: cree la base y selecciónela antes de ejecutar:
         CREATE DATABASE DentoTacnaDB;
         GO
         USE DentoTacnaDB;
         GO
   (No se usa USE aquí porque Azure SQL no permite cambiar de base con USE.)

   ORGANIZACIÓN
   1. Catálogos      -> listas fijas (roles, estados, métodos de pago...).
                        Para añadir una opción nueva basta un INSERT.
   2. Seguridad      -> usuarios del sistema.
   3. Mantenimiento  -> odontólogos y tratamientos.
   4. Pacientes      -> datos, antecedentes, historia clínica.
   5. Citas
   6. Plan de tratamiento
   7. Pagos          -> cargos, pagos y su detalle.
   8. Asistente IA   -> registro de consultas.
   9. Vistas         -> consultas listas para el panel, pagos y el asistente IA.
   10. Procedimientos -> USP_ (por ahora, Odontólogo).
   11. Datos iniciales

   CONVENCIONES (para seguir añadiendo tablas)
   - Tablas en singular y PascalCase. Llave primaria: Id + NombreTabla.
   - Catálogos con Id TINYINT sin IDENTITY (los Id no cambian entre equipos).
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
    IdMetodoPago    TINYINT       NOT NULL CONSTRAINT PK_MetodoPago PRIMARY KEY,
    Nombre          NVARCHAR(40)  NOT NULL CONSTRAINT UQ_MetodoPago_Nombre UNIQUE,
    Activo          BIT           NOT NULL CONSTRAINT DF_MetodoPago_Activo DEFAULT (1)
);
GO

CREATE TABLE dbo.Antecedente (
    IdAntecedente   TINYINT       NOT NULL CONSTRAINT PK_Antecedente PRIMARY KEY,
    Nombre          NVARCHAR(60)  NOT NULL CONSTRAINT UQ_Antecedente_Nombre UNIQUE,
    Activo          BIT           NOT NULL CONSTRAINT DF_Antecedente_Activo DEFAULT (1)
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
    IdOdontologo    INT           NULL,   -- se llena si el usuario es un odontólogo (FK más abajo)
    Activo          BIT           NOT NULL CONSTRAINT DF_Usuario_Activo DEFAULT (1),
    UltimoAcceso    DATETIME2(0)  NULL,
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

CREATE TABLE dbo.Paciente (
    IdPaciente          INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Paciente PRIMARY KEY,
    NumeroHistoria      AS ('HC-' + RIGHT('00000' + CONVERT(VARCHAR(10), IdPaciente), 5)) PERSISTED,
    Nombres             NVARCHAR(60)  NOT NULL,
    Apellidos           NVARCHAR(60)  NOT NULL,
    DNI                 CHAR(8)       NOT NULL CONSTRAINT UQ_Paciente_DNI UNIQUE
                                               CONSTRAINT CK_Paciente_DNI CHECK (DNI NOT LIKE '%[^0-9]%'),
    FechaNacimiento     DATE          NULL,
    Sexo                CHAR(1)       NULL CONSTRAINT CK_Paciente_Sexo CHECK (Sexo IN ('F', 'M')),
    Telefono            VARCHAR(15)   NOT NULL,
    Correo              NVARCHAR(100) NULL,
    Direccion           NVARCHAR(200) NULL,
    DetalleAntecedentes NVARCHAR(500) NULL,   -- texto libre del campo "Detalle"
    Activo              BIT           NOT NULL CONSTRAINT DF_Paciente_Activo DEFAULT (1),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_Paciente_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Paciente_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_Paciente_Apellidos ON dbo.Paciente (Apellidos, Nombres);
GO

-- Antecedentes marcados por paciente (Alergias, Diabetes, ...). Nuevos antecedentes = INSERT en el catálogo.
CREATE TABLE dbo.PacienteAntecedente (
    IdPaciente      INT           NOT NULL CONSTRAINT FK_PacienteAntecedente_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdAntecedente   TINYINT       NOT NULL CONSTRAINT FK_PacienteAntecedente_Antecedente REFERENCES dbo.Antecedente (IdAntecedente),
    Detalle         NVARCHAR(200) NULL,
    CONSTRAINT PK_PacienteAntecedente PRIMARY KEY (IdPaciente, IdAntecedente)
);
GO

/* =====================================================================
   5. CITAS
   ===================================================================== */

CREATE TABLE dbo.Cita (
    IdCita              INT IDENTITY(10000,1) NOT NULL CONSTRAINT PK_Cita PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Cita_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdOdontologo        INT           NOT NULL CONSTRAINT FK_Cita_Odontologo REFERENCES dbo.Odontologo (IdOdontologo),
    IdTratamiento       INT           NOT NULL CONSTRAINT FK_Cita_Tratamiento REFERENCES dbo.Tratamiento (IdTratamiento),
    Fecha               DATE          NOT NULL,
    Hora                TIME(0)       NOT NULL,
    IdEstadoCita        TINYINT       NOT NULL CONSTRAINT FK_Cita_EstadoCita REFERENCES dbo.EstadoCita (IdEstadoCita)
                                               CONSTRAINT DF_Cita_IdEstadoCita DEFAULT (1),
    Observaciones       NVARCHAR(500) NULL,
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
   HISTORIA CLÍNICA (ATENCIONES)
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
   6. PLAN DE TRATAMIENTO
   ===================================================================== */

-- Cabecera: un paciente puede tener varios planes en el tiempo.
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

-- Detalle: cada fila de la pestaña "Plan de tratamiento" (pieza, tratamiento, precio, estado).
CREATE TABLE dbo.PlanTratamientoDetalle (
    IdPlanDetalle       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PlanTratamientoDetalle PRIMARY KEY,
    IdPlan              INT           NOT NULL CONSTRAINT FK_PlanDetalle_Plan REFERENCES dbo.PlanTratamiento (IdPlan),
    IdTratamiento       INT           NOT NULL CONSTRAINT FK_PlanDetalle_Tratamiento REFERENCES dbo.Tratamiento (IdTratamiento),
    PiezaDental         VARCHAR(10)   NULL,
    Precio              DECIMAL(10,2) NOT NULL CONSTRAINT CK_PlanDetalle_Precio CHECK (Precio >= 0), -- precio al momento de agregarlo
    IdEstadoPlan        TINYINT       NOT NULL CONSTRAINT FK_PlanDetalle_EstadoPlan REFERENCES dbo.EstadoPlan (IdEstadoPlan)
                                               CONSTRAINT DF_PlanDetalle_IdEstadoPlan DEFAULT (1),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_PlanDetalle_FechaRegistro DEFAULT (SYSDATETIME())
);
GO

CREATE INDEX IX_PlanDetalle_Plan ON dbo.PlanTratamientoDetalle (IdPlan);
GO

/* =====================================================================
   7. PAGOS
   ===================================================================== */

-- Cargo: lo que el paciente debe. Normalmente nace de un ítem del plan o de una atención.
CREATE TABLE dbo.Cargo (
    IdCargo             INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Cargo PRIMARY KEY,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Cargo_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdPlanDetalle       INT           NULL CONSTRAINT FK_Cargo_PlanDetalle REFERENCES dbo.PlanTratamientoDetalle (IdPlanDetalle),
    IdAtencion          INT           NULL CONSTRAINT FK_Cargo_Atencion REFERENCES dbo.Atencion (IdAtencion),
    Concepto            NVARCHAR(150) NOT NULL,
    PiezaDental         VARCHAR(10)   NULL,
    Fecha               DATE          NOT NULL CONSTRAINT DF_Cargo_Fecha DEFAULT (CONVERT(DATE, SYSDATETIME())),
    Importe             DECIMAL(10,2) NOT NULL CONSTRAINT CK_Cargo_Importe CHECK (Importe > 0),
    Anulado             BIT           NOT NULL CONSTRAINT DF_Cargo_Anulado DEFAULT (0),
    FechaRegistro       DATETIME2(0)  NOT NULL CONSTRAINT DF_Cargo_FechaRegistro DEFAULT (SYSDATETIME()),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Cargo_Usuario REFERENCES dbo.Usuario (IdUsuario)
);
GO

CREATE INDEX IX_Cargo_Paciente ON dbo.Cargo (IdPaciente) INCLUDE (Importe, Anulado);
GO

-- Pago: el recibo. Un pago puede cubrir varios cargos (ver PagoDetalle).
CREATE TABLE dbo.Pago (
    IdPago              INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Pago PRIMARY KEY,
    NumeroRecibo        AS ('R-' + RIGHT('000000' + CONVERT(VARCHAR(10), IdPago), 6)) PERSISTED,
    IdPaciente          INT           NOT NULL CONSTRAINT FK_Pago_Paciente REFERENCES dbo.Paciente (IdPaciente),
    IdMetodoPago        TINYINT       NOT NULL CONSTRAINT FK_Pago_MetodoPago REFERENCES dbo.MetodoPago (IdMetodoPago),
    FechaHora           DATETIME2(0)  NOT NULL CONSTRAINT DF_Pago_FechaHora DEFAULT (SYSDATETIME()),
    Total               DECIMAL(10,2) NOT NULL CONSTRAINT CK_Pago_Total CHECK (Total > 0),
    MontoRecibido       DECIMAL(10,2) NOT NULL,
    Vuelto              AS (MontoRecibido - Total) PERSISTED,
    Anulado             BIT           NOT NULL CONSTRAINT DF_Pago_Anulado DEFAULT (0),
    IdUsuarioRegistro   INT           NULL CONSTRAINT FK_Pago_Usuario REFERENCES dbo.Usuario (IdUsuario),
    CONSTRAINT CK_Pago_MontoRecibido CHECK (MontoRecibido >= Total)
);
GO

CREATE UNIQUE INDEX UQ_Pago_NumeroRecibo ON dbo.Pago (NumeroRecibo);
CREATE INDEX IX_Pago_FechaHora ON dbo.Pago (FechaHora) INCLUDE (Total, Anulado);
CREATE INDEX IX_Pago_Paciente ON dbo.Pago (IdPaciente);
GO

-- Cuánto de cada cargo se pagó en cada recibo (permite pagos parciales).
CREATE TABLE dbo.PagoDetalle (
    IdPago              INT           NOT NULL CONSTRAINT FK_PagoDetalle_Pago REFERENCES dbo.Pago (IdPago),
    IdCargo             INT           NOT NULL CONSTRAINT FK_PagoDetalle_Cargo REFERENCES dbo.Cargo (IdCargo),
    Monto               DECIMAL(10,2) NOT NULL CONSTRAINT CK_PagoDetalle_Monto CHECK (Monto > 0),
    CONSTRAINT PK_PagoDetalle PRIMARY KEY (IdPago, IdCargo)
);
GO

CREATE INDEX IX_PagoDetalle_Cargo ON dbo.PagoDetalle (IdCargo) INCLUDE (Monto);
GO

/* =====================================================================
   8. ASISTENTE IA
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
   9. VISTAS
   Consultas ya armadas para el panel principal, pagos y el asistente IA.
   El asistente IA debería leer SOLO de estas vistas (ver sección final).
   ===================================================================== */

CREATE VIEW dbo.vw_Citas
AS
SELECT  c.IdCita,
        c.Fecha,
        c.Hora,
        p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos       AS Paciente,
        p.DNI,
        p.Telefono,
        t.Nombre                              AS Tratamiento,
        o.IdOdontologo,
        o.Nombres + N' ' + o.Apellidos       AS Odontologo,
        e.IdEstadoCita,
        e.Nombre                              AS Estado,
        c.Observaciones
FROM    dbo.Cita c
JOIN    dbo.Paciente    p ON p.IdPaciente    = c.IdPaciente
JOIN    dbo.Odontologo  o ON o.IdOdontologo  = c.IdOdontologo
JOIN    dbo.Tratamiento t ON t.IdTratamiento = c.IdTratamiento
JOIN    dbo.EstadoCita  e ON e.IdEstadoCita  = c.IdEstadoCita;
GO

-- Cada cargo con lo pagado y lo que falta.
CREATE VIEW dbo.vw_CargoSaldo
AS
SELECT  ca.IdCargo,
        ca.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos            AS Paciente,
        ca.Concepto,
        ca.PiezaDental,
        ca.Fecha,
        ca.Importe,
        ISNULL(pg.Pagado, 0)                       AS Pagado,
        ca.Importe - ISNULL(pg.Pagado, 0)          AS Saldo
FROM    dbo.Cargo ca
JOIN    dbo.Paciente p ON p.IdPaciente = ca.IdPaciente
OUTER APPLY (
        SELECT SUM(d.Monto) AS Pagado
        FROM   dbo.PagoDetalle d
        JOIN   dbo.Pago pa ON pa.IdPago = d.IdPago
        WHERE  d.IdCargo = ca.IdCargo AND pa.Anulado = 0
) pg
WHERE   ca.Anulado = 0;
GO

-- Saldo total por paciente (solo los que deben algo).
CREATE VIEW dbo.vw_SaldoPaciente
AS
SELECT  IdPaciente,
        NumeroHistoria,
        Paciente,
        SUM(Importe) AS TotalCargos,
        SUM(Pagado)  AS TotalPagado,
        SUM(Saldo)   AS Saldo
FROM    dbo.vw_CargoSaldo
GROUP BY IdPaciente, NumeroHistoria, Paciente
HAVING  SUM(Saldo) > 0;
GO

CREATE VIEW dbo.vw_Pagos
AS
SELECT  pa.IdPago,
        pa.NumeroRecibo,
        pa.FechaHora,
        CONVERT(DATE, pa.FechaHora)          AS Fecha,
        p.IdPaciente,
        p.NumeroHistoria,
        p.Nombres + N' ' + p.Apellidos       AS Paciente,
        m.Nombre                              AS Metodo,
        pa.Total,
        pa.MontoRecibido,
        pa.Vuelto,
        STUFF((SELECT N', ' + ca.Concepto
               FROM   dbo.PagoDetalle d
               JOIN   dbo.Cargo ca ON ca.IdCargo = d.IdCargo
               WHERE  d.IdPago = pa.IdPago
               FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, N'') AS Concepto
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
   10. PROCEDIMIENTOS ALMACENADOS
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

/* =====================================================================
   11. DATOS INICIALES
   ===================================================================== */

INSERT INTO dbo.Rol (IdRol, Nombre, Descripcion) VALUES
    (1, N'Administrador', N'Acceso total, incluido Mantenimiento'),
    (2, N'Recepcionista', N'Citas, pacientes y pagos'),
    (3, N'Odontólogo',    N'Agenda propia, atenciones y planes de tratamiento');

INSERT INTO dbo.Especialidad (IdEspecialidad, Nombre) VALUES
    (1, N'Odontología general'), (2, N'Ortodoncia'), (3, N'Endodoncia'),
    (4, N'Odontopediatría'), (5, N'Periodoncia'), (6, N'Cirugía oral');

INSERT INTO dbo.EstadoCita (IdEstadoCita, Nombre, Orden, OcupaHorario) VALUES
    (1, N'Programada',  1, 1),
    (2, N'Confirmada',  2, 1),
    (3, N'En consulta', 3, 1),
    (4, N'Atendida',    4, 1),
    (5, N'Cancelada',   5, 0);

INSERT INTO dbo.EstadoPlan (IdEstadoPlan, Nombre, Orden) VALUES
    (1, N'Pendiente', 1), (2, N'En curso', 2), (3, N'Terminado', 3), (4, N'Cancelado', 4);

INSERT INTO dbo.MetodoPago (IdMetodoPago, Nombre) VALUES
    (1, N'Efectivo'), (2, N'Tarjeta'), (3, N'Yape / Plin'), (4, N'Transferencia');

INSERT INTO dbo.Antecedente (IdAntecedente, Nombre) VALUES
    (1, N'Alergias'), (2, N'Diabetes'), (3, N'Hipertensión'), (4, N'Embarazo');

INSERT INTO dbo.Tratamiento (Nombre, Descripcion, Precio, DuracionMin) VALUES
    (N'Limpieza y profilaxis',  N'Limpieza dental profesional',             120.00, 30),
    (N'Resina compuesta',       N'Restauración estética de una pieza dental', 180.00, 45),
    (N'Radiografía periapical', N'Radiografía de una pieza dental',          35.00, 15),
    (N'Endodoncia molar',       N'Tratamiento de conducto en molar',         450.00, 90),
    (N'Extracción simple',      N'Extracción de pieza dental',               150.00, 30),
    (N'Corona de porcelana',    N'Corona estética de porcelana',             950.00, 60),
    (N'Control de ortodoncia',  N'Control y ajuste mensual de brackets',     250.00, 30),
    (N'Primera consulta',       N'Evaluación inicial del paciente',          50.00,  30);
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
   GRANT SELECT ON dbo.vw_Citas         TO asistente_ia;
   GRANT SELECT ON dbo.vw_CargoSaldo    TO asistente_ia;
   GRANT SELECT ON dbo.vw_SaldoPaciente TO asistente_ia;
   GRANT SELECT ON dbo.vw_Pagos         TO asistente_ia;
   GRANT SELECT ON dbo.vw_Atenciones    TO asistente_ia;

   (En SQL Server local primero se crea el LOGIN en master y luego
    CREATE USER asistente_ia FOR LOGIN asistente_ia;)
   ===================================================================== */
