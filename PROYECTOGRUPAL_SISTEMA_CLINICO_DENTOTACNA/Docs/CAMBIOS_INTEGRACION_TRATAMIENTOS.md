# Integración de Tratamientos (rama `integracion-tratamientos`)

**Fecha:** 23/11/2026
**Rama base:** `gustavo` (commit `c8334ff`)
**Se tomó código de:** `origin/jesus` (commit `ffffb74`, Jesus Orbegozo)

No se hizo `git merge` de la rama de Jesús: habría dado conflictos en 6 archivos y en casi todos
convenía quedarse con la versión de `gustavo`. Se trajeron a mano solo las partes que faltaban.

---

## 1. Qué se tomó de cada rama

| Parte | Origen | Nota |
|---|---|---|
| Conexión (`clsConexion`, `App.config`) | gustavo | La de Jesús no tenía cadena de conexión |
| Script de BD (`BaseDatos/DentoTacnaDB.sql`) | gustavo + procedimientos nuevos | Jesús no tenía script |
| Odontólogo (entidad, datos, negocio) | gustavo | Ya tenía validaciones, COP duplicado y borrado lógico |
| Diseño de `frmMantenimiento` | gustavo | No se tocó el `.Designer.cs` |
| **Especialidades** (`clsEspecialidad_D/_N`) | **Jesús** | Pasadas al estilo de gustavo (`using`) |
| **Entidad Tratamiento** (`clsTratamiento`) | **Jesús** | Se agregaron `codigo` y `activo` |
| **Datos y Negocio Tratamiento** | **Jesús** | Corregido el bug y mejorado (ver punto 3) |
| **Filtros de teclado** (`KeyPress`) | **Jesús** | Ajustados (ver punto 5) |
| `Program.cs`, `.github/copilot-instructions.md` | — | Descartados (prueba local y archivo ajeno al proyecto) |

---

## 2. Archivos

### Nuevos
- `CapaEntidad/clsTratamiento.cs`
- `CapaDatos/clsEspecialidad_D.cs`
- `CapaDatos/clsTratamiento_D.cs`
- `CapaNegocio/clsEspecialidad_N.cs`
- `CapaNegocio/clsTratamiento_N.cs`
- `Docs/CAMBIOS_INTEGRACION_TRATAMIENTOS.md` (este archivo)

### Modificados
- `CapaEntidad/CapaEntidad.csproj`, `CapaDatos/CapaDatos.csproj`, `CapaNegocio/CapaNegocio.csproj`: registran las clases nuevas.
- `CapaDatos/clsOdontologo_D.cs` y `CapaNegocio/clsOdontologo_N.cs`: se quitó `mtdListarEspecialidades()`. Ahora está solo en `clsEspecialidad_*`, sin duplicar.
- `BaseDatos/DentoTacnaDB.sql`: 5 procedimientos de tratamiento.
- `frmMantenimiento.cs`: pestaña Tratamientos conectada a la BD y filtros de teclado.

---

## 3. Tratamiento: cambios respecto a la versión de Jesús

1. **Bug corregido:** en `mtdListarTratamientos()` el `finally` llamaba a `mtdAbrirConexion()` en vez de
   `mtdCerrarConexion()`, así que la conexión nunca se cerraba.
2. **Borrado lógico en vez de `DELETE`:** `dbo.Cita` y `dbo.PlanTratamiento` tienen llave foránea a
   `dbo.Tratamiento`, así que un `DELETE` fallaría si el tratamiento ya se usó. Ahora
   `mtdDesactivarTratamiento()` pone `Activo = 0` y la lista muestra solo los activos.
3. **Validaciones en Capa de Negocio** (`clsTratamiento_N.mtdGuardarTratamiento`), con los mismos límites que la tabla:
   - nombre obligatorio, máx. 100 caracteres;
   - descripción máx. 300 caracteres;
   - precio mayor a 0, con máximo 2 decimales;
   - duración mayor a 0 minutos;
   - **nombre no repetido** (la columna `Nombre` es `UNIQUE`). Se avisa con un mensaje claro en vez del error de SQL.
4. **Un solo método `mtdGuardarTratamiento`**, igual que en odontólogos: registra si `idTratamiento = 0` y,
   si no, actualiza. Registrar devuelve el Id nuevo para dejarlo seleccionado en la grilla.
5. **Parámetros tipados** (`SqlDbType` + tamaño) en lugar de `AddWithValue`, y nombres que coinciden con los
   procedimientos (`@Nombre`, `@Precio`, `@DuracionMin`...).
6. `mtdListarTratamientos()` en Negocio devuelve `List<clsTratamiento>` (como odontólogos), no `DataTable`.

---

## 4. Procedimientos nuevos en `DentoTacnaDB.sql` (sección 10)

| Procedimiento | Qué hace |
|---|---|
| `USP_ListarTratamientos` | Lista los tratamientos con `Activo = 1` |
| `USP_ExisteNombreTratamiento` | Devuelve 1 si el nombre ya lo usa **otro** tratamiento |
| `USP_RegistrarTratamiento` | Inserta y devuelve `@IdTratamiento` (OUTPUT) |
| `USP_ActualizarTratamiento` | Actualiza nombre, descripción, precio y duración |
| `USP_DesactivarTratamiento` | Borrado lógico (`Activo = 0`) |

Usan `CREATE OR ALTER`, así que **si ya tienen la base creada** basta con ejecutar de nuevo la
sección 10 del script (o el script completo en una base vacía).

> Si ejecutan el script con `sqlcmd`, agreguen `-I` (activa `QUOTED_IDENTIFIER`, necesario por las
> columnas calculadas) y `-f 65001` para que las tildes se guarden bien. En SSMS no hace falta nada.

---

## 5. Formulario `frmMantenimiento` (pestaña Tratamientos)

- **Diseño sin cambios** (mismo `.Designer.cs` de gustavo).
- Al abrir, carga los tratamientos desde la BD (`CargarTratamientos`) en vez de `DatosDemo.Tratamientos`.
- Cada fila guarda su `clsTratamiento` en `Row.Tag`. Al seleccionarla se llenan nombre, precio,
  duración y la **descripción real** (antes estaba fija en el código).
- **Guardar** → `clsTratamiento_N.mtdGuardarTratamiento`. Si falla la validación, muestra el motivo; si
  falla la BD, muestra el error y recuerda revisar `App.config`.
- **Eliminar** → pide confirmación y desactiva el tratamiento.
- El combo de especialidades ahora usa `clsEspecialidad_N`.

### Filtros de teclado
Se conectan por código en `ConectarFiltrosTeclado()` (sin tocar el Designer):

| Caja | Permite |
|---|---|
| `txtNombres`, `txtApellidos`, `txtNombreCompleto` | Letras (con tildes y ñ), espacio, `'` y `-` |
| `txtCop` | Solo dígitos |
| `txtTelefono` | Dígitos, espacio, `+` y `-` (lo mismo que valida `clsOdontologo_N`) |
| `txtPrecio` | Dígitos y **un** separador decimal (`.` o `,`) |

Diferencias con la versión de Jesús:
- Teléfono acepta `+`, espacio y `-`, porque la validación de negocio ya los permitía.
- Precio acepta también coma.
- Al nombre del tratamiento **no** se le puso filtro de "solo letras", porque bloquearía nombres como
  "Corona 3/4" o "Radiografía (2 piezas)". Se valida al guardar.
- Los filtros solo evitan teclas; la validación completa sigue en la Capa de Negocio (por si se pega texto).

---

## 6. Verificación

- La solución **compila sin errores** (MSBuild, Debug).
- El script completo se ejecutó en una base temporal de LocalDB y se probaron los 5 procedimientos:
  registrar, nombre duplicado (1 / 0), actualizar, desactivar y listar solo activos. La base temporal se borró.
- **Pendiente:** probar la pestaña Tratamientos abriendo el formulario con la base local creada.

---

## 7. Pendientes

- **Citas** (`frmCitas`) y **Pacientes → Plan de tratamiento** (`frmPacientes`) siguen leyendo los
  tratamientos de `DatosDemo.Tratamientos`. El siguiente paso es usar `clsTratamiento_N.mtdListarTratamientos()` ahí también.
- La pestaña **Usuarios** sigue con datos de demostración.
- Migración a **Azure SQL**: por ahora todo es local. Para Azure basta con crear la base, ejecutar el
  script y cambiar la cadena `DentoTacnaDB` en `App.config`.
- Avisar a Jesús: la conexión se configura en `App.config`, **no** en `clsConexion.cs`.
