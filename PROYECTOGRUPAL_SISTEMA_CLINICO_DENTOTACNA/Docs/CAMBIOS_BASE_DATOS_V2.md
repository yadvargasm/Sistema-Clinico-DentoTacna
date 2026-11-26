# Base de datos v2 (alineada con el prototipo DentoTacna v0.1)

**Fecha:** 26/11/2026
**Rama:** `integracion-tratamientos`
**Archivo:** `BaseDatos/DentoTacnaDB.sql`
**Referencia:** prototipo `DentoTacna_v0.1.html` (22/11/2026)

El script se reescribió completo para que cada pantalla del prototipo tenga dónde guardar sus datos.
Como la base todavía es local y no tiene datos reales, **hay que borrar la base y crearla de nuevo**
con el script completo (no es una migración sobre la base anterior).

```sql
-- En SSMS, conectado a la instancia:
DROP DATABASE IF EXISTS DentoTacnaDB;
CREATE DATABASE DentoTacnaDB;
GO
USE DentoTacnaDB;
GO
-- y ejecutar DentoTacnaDB.sql
```

Con `sqlcmd`: `sqlcmd -S "(localdb)\MSSQLLocalDB" -d DentoTacnaDB -I -f 65001 -i DentoTacnaDB.sql`

---

## 1. Tablas nuevas

| Tabla | Pantalla | Qué guarda |
|---|---|---|
| `TipoDocumento` | Pacientes › Datos personales | DNI, RUT (Chile), Carnet de extranjería, Pasaporte, con su longitud máxima |
| `Programa` | Pacientes | General, Ortodoncia, Implantes |
| `PreguntaAnamnesis` | Pacientes › Anamnesis | Las 12 preguntas SÍ/NO. `TextoAlerta` es lo que sale en la alerta; `RequiereDetalle` + `TextoAyuda` para "¿A qué medicamento?" |
| `PacienteAnamnesis` | Pacientes › Anamnesis | Respuesta SÍ/NO de cada pregunta y su detalle (reemplaza a `PacienteAntecedente`) |
| `EstadoPieza` | Pacientes › Odontograma | Sano, Caries, Restaurado, Endodoncia, Corona, Implante, Bracket, Extracción indicada, Ausente |
| `Odontograma` | Pacientes › Odontograma | Uno **inicial (I)** y uno **final (F)** por paciente, con fecha, odontólogo y observaciones |
| `OdontogramaPieza` | Pacientes › Odontograma | Estado de cada pieza en notación FDI. Solo se guardan las que **no** están sanas |
| `TipoArchivo` | Pacientes › Imágenes | Radiografía, Foto, Documento |
| `PacienteArchivo` | Pacientes › Imágenes | El archivo (JPG, PNG o PDF, máx. 10 MB) guardado **dentro de la base** en `VARBINARY(MAX)` |
| `Consentimiento` | Pacientes › Consentimiento | Diagnóstico, procedimiento, riesgos, alternativas, consecuencias, las 4 declaraciones, lugar, fecha y firmado |

## 2. Tablas modificadas

### Paciente
| Antes | Ahora |
|---|---|
| `DNI CHAR(8)` único | `IdTipoDocumento` + `NumeroDocumento VARCHAR(12)`, únicos los dos juntos. Si es DNI (Id 1) se exige 8 dígitos |
| `Telefono VARCHAR(15)` | `VARCHAR(20)` (ej. `+56 9 8123 4567`) |
| `DetalleAntecedentes` | Se quitó. Ahora `AnamnesisOtros` (pregunta 13 "Otros") |
| — | `FechaVerificacionReniec`, `MotivoConsulta`, `IdPrograma`, `NombreResponsable`, `DNIResponsable`, `FechaAnamnesis`, `IdOdontologoAnamnesis` |

El N.° de historia sigue siendo `HC-00001`, correlativo, y no cambia si el paciente cambia de programa.

### Cita
- `PiezaDental` (ej. "Endodoncia **pieza 36**").
- Recordatorio: `RecordarDiaAntes`, `MostrarEnPanel`, `FechaRecordatorio` (NULL = pendiente) y
  `RecordatorioEnviado` (calculada).
- Estados: se agregó **Sin confirmar**. Los Id quedan: 1 Programada, 2 Sin confirmar, 3 Confirmada,
  4 En consulta, 5 Atendida, 6 Cancelada.

### PlanTratamientoDetalle
- Cada fila tiene su propio `IdOdontologo` (Doctor), `Fecha` (NULL = "—") y `FirmaPaciente`.
- `Precio` es el **Total**. "A cuenta" y "Saldo" no se guardan: se calculan en `vw_PlanSaldo`.

### Pago y PagoDetalle — se quitó la tabla `Cargo`
- Antes: Plan → **Cargo** → PagoDetalle → Pago. Ahora: Plan → PagoDetalle → Pago.
  Un pago se aplica directo a una o varias filas del plan, igual que en la pantalla "Saldos del plan".
  Una limpieza suelta también se registra como fila del plan.
- `Pago.TipoPago`: `T` = Pago total, `C` = A cuenta.
- `Pago.NumeroOperacion`: Yape, Plin, transferencia, o voucher / últimos 4 dígitos de tarjeta.
- Reglas en la tabla: solo **Efectivo** (Id 1) puede dar vuelto y no necesita N.° de operación.
- Pendiente para la Capa de Negocio: que la suma de `PagoDetalle.Monto` sea igual a `Pago.Total`
  y que no se pague más que el saldo de cada fila.

## 3. Catálogos (datos iniciales)

| Catálogo | Cambio |
|---|---|
| `Rol` | "Recepcionista" → **"Recepción"** |
| `Especialidad` | Se agregó **Implantología** (Id 7). Los Id anteriores no cambian |
| `MetodoPago` | **Yape y Plin por separado**: 1 Efectivo, 2 Tarjeta, 3 Yape, 4 Plin, 5 Transferencia. Columna nueva `RequiereOperacion` |
| `Tratamiento` | TR-01 a TR-10 en el mismo orden del prototipo (se agregaron Instalación de brackets, Implante dental y Blanqueamiento). Luego TR-11 Primera consulta, TR-12 Sellantes, TR-13 Control de implante (precio referencial S/ 100) |

## 4. Vistas

| Vista | Uso |
|---|---|
| `vw_AlertasPaciente` | **Nueva.** Texto de alertas, ej. "hipertensión arterial · alergia a medicamento (Penicilina)" |
| `vw_Citas` | Agrega Programa, pieza en el tratamiento, duración y estado del recordatorio (Pendiente / Enviado / No aplica) |
| `vw_PlanSaldo` | **Nueva** (reemplaza a `vw_CargoSaldo`). Cada fila del plan con Total, A cuenta y Saldo |
| `vw_SaldoPaciente` | Ahora suma desde `vw_PlanSaldo` |
| `vw_Pagos` | Agrega Hora, Tipo (Total / A cuenta) y N.° de operación; el concepto sale del tratamiento y la pieza |
| `vw_Atenciones` | Sin cambios |

El usuario de solo lectura del asistente IA ahora también tiene acceso a `vw_PlanSaldo` y `vw_AlertasPaciente`.

## 5. Qué no cambia

- Tablas `Usuario`, `Odontologo`, `Tratamiento`, `Atencion`, `PlanTratamiento`, `ConsultaAsistente`.
- Los 11 procedimientos `USP_` de Odontólogos y Tratamientos (ahora en la **sección 11**).
  Por eso las capas de Odontólogo y Tratamiento siguen funcionando sin tocar el código C#.

## 6. Verificación

- El script completo se ejecutó en una base temporal de LocalDB sin errores. La base se borró después.
- Se cargó el caso de María Elena Castillo del prototipo (anamnesis, odontograma, cita, plan con 4 filas,
  consentimiento y 2 pagos) y las vistas devolvieron los saldos correctos.
- Se comprobó que la base **rechaza**: DNI de 7 dígitos, documento repetido, piezas 19 y 56,
  dos odontogramas iniciales, Yape sin N.° de operación, vuelto con tarjeta y archivos GIF.
- La solución compila sin errores (MSBuild, Debug).

## 7. Pendientes

- Crear las clases de las 3 capas para Pacientes, Anamnesis, Odontograma, Consentimiento, Imágenes,
  Citas, Plan y Pagos (hoy esos formularios usan `DatosDemo`).
- Avisar al equipo que deben **recrear su base local** con el script nuevo.
