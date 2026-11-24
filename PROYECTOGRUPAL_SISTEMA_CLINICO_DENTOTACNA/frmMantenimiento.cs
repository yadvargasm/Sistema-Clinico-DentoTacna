using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmMantenimiento : Form
    {
        private readonly clsOdontologo_N negocioOdontologo = new clsOdontologo_N();
        private readonly clsEspecialidad_N negocioEspecialidad = new clsEspecialidad_N();
        private readonly clsTratamiento_N negocioTratamiento = new clsTratamiento_N();

        public frmMantenimiento()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            Tema.PintarEtiquetas(dgvOdontologos, "colEstado");
            Tema.PintarEtiquetas(dgvUsuarios, "colEstadoUsuario");
            ConectarFiltrosTeclado();

            cboRol.Items.AddRange(DatosDemo.Roles);
            cboOdontologoVinculado.Items.Add("— Ninguno —");
            cboOdontologoVinculado.Items.AddRange(DatosDemo.OdontologosLargo);

            CargarEspecialidades();
            CargarOdontologos(0);
            CargarTratamientos(0);

            // TODO (pendiente BD): leer usuarios desde la Capa de Negocio.
            foreach (object[] u in DatosDemo.UsuariosTabla)
                dgvUsuarios.Rows.Add(u);

            if (dgvUsuarios.Rows.Count > 2) dgvUsuarios.CurrentCell = dgvUsuarios.Rows[2].Cells[0];
            dgvUsuarios_SelectionChanged(null, EventArgs.Empty);
        }

        // ---------------------------------------------------- Filtros de teclado
        // Traídos de la rama de Jesús. Bloquean la tecla mientras se escribe;
        // la validación completa sigue en la Capa de Negocio al guardar.

        private void ConectarFiltrosTeclado()
        {
            txtNombres.KeyPress += SoloLetras;
            txtApellidos.KeyPress += SoloLetras;
            txtNombreCompleto.KeyPress += SoloLetras;
            txtCop.KeyPress += SoloDigitos;
            txtTelefono.KeyPress += SoloTelefono;
            txtPrecio.KeyPress += SoloDecimal;
        }

        // Letras (con tildes y ñ), espacio, apóstrofo y guion: "María José", "O'Brien", "Pérez-Rojas".
        private static void SoloLetras(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsLetter(c) && c != ' ' && c != '\'' && c != '-')
                e.Handled = true;
        }

        private static void SoloDigitos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Mismos caracteres que acepta clsOdontologo_N: dígitos, espacio, + y -.
        private static void SoloTelefono(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsDigit(c) && c != ' ' && c != '+' && c != '-')
                e.Handled = true;
        }

        // Dígitos y un solo separador decimal (punto o coma; Tema.Numero acepta ambos).
        private static void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsControl(c) || char.IsDigit(c)) return;
            string texto = ((Control)sender).Text;
            bool esSeparador = c == '.' || c == ',';
            if (!esSeparador || texto.Contains(".") || texto.Contains(","))
                e.Handled = true;
        }

        private static void Seleccionar(ComboBox combo, string texto)
        {
            combo.SelectedIndex = combo.FindStringExact(texto);
        }

        private static bool Validar(params Control[] obligatorios)
        {
            foreach (Control c in obligatorios)
            {
                bool vacio = (c is ComboBox) ? ((ComboBox)c).SelectedIndex < 0 : c.Text.Trim() == "";
                if (vacio)
                {
                    MessageBox.Show("Complete los campos obligatorios (*).", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c.Focus();
                    return false;
                }
            }
            return true;
        }

        private void MostrarErrorBD(string accion, Exception ex)
        {
            MessageBox.Show("No se pudo " + accion + ".\n\n" + ex.Message +
                            "\n\nRevise que la base de datos esté creada y la cadena \"DentoTacnaDB\" de App.config.",
                            "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ---------------------------------------------------------- Odontólogos

        private void CargarEspecialidades()
        {
            try
            {
                cboEspecialidad.DisplayMember = "Nombre";
                cboEspecialidad.ValueMember = "IdEspecialidad";
                cboEspecialidad.DataSource = negocioEspecialidad.mtdListarEspecialidades();
                cboEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarErrorBD("cargar las especialidades", ex);
            }
        }

        /// <summary>Lee los odontólogos de la BD y deja seleccionado el de <paramref name="idSeleccionar"/> (0 = el primero).</summary>
        private void CargarOdontologos(int idSeleccionar)
        {
            List<clsOdontologo> lista;
            try
            {
                lista = negocioOdontologo.mtdListarOdontologos();
            }
            catch (Exception ex)
            {
                MostrarErrorBD("cargar los odontólogos", ex);
                return;
            }

            dgvOdontologos.Rows.Clear();
            foreach (clsOdontologo o in lista)
            {
                int i = dgvOdontologos.Rows.Add(o.codigo, o.NombreCompleto, o.numeroCOP, o.especialidad,
                                                o.activo ? "Activo" : "Inactivo");
                dgvOdontologos.Rows[i].Tag = o;
                if (o.idOdontologo == idSeleccionar)
                    dgvOdontologos.CurrentCell = dgvOdontologos.Rows[i].Cells[0];
            }
            dgvOdontologos_SelectionChanged(null, EventArgs.Empty);
        }

        private clsOdontologo OdontologoSeleccionado()
        {
            return dgvOdontologos.CurrentRow == null ? null : dgvOdontologos.CurrentRow.Tag as clsOdontologo;
        }

        private void dgvOdontologos_SelectionChanged(object sender, EventArgs e)
        {
            clsOdontologo o = OdontologoSeleccionado();
            if (o == null) return;
            txtNombres.Text = o.nombres;
            txtApellidos.Text = o.apellidos;
            txtCop.Text = o.numeroCOP;
            txtTelefono.Text = o.telefono;
            Seleccionar(cboEspecialidad, o.especialidad);
            chkActivo.Checked = o.activo;
        }

        private void btnNuevoOdontologo_Click(object sender, EventArgs e)
        {
            dgvOdontologos.CurrentCell = null;
            txtNombres.Clear(); txtApellidos.Clear(); txtCop.Clear(); txtTelefono.Clear();
            cboEspecialidad.SelectedIndex = -1;
            chkActivo.Checked = true;
            txtNombres.Focus();
        }

        private void btnGuardarOdontologo_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombres, txtApellidos, txtCop, cboEspecialidad)) return;

            clsOdontologo actual = OdontologoSeleccionado();
            clsOdontologo o = new clsOdontologo
            {
                idOdontologo = actual == null ? 0 : actual.idOdontologo,
                nombres = txtNombres.Text,
                apellidos = txtApellidos.Text,
                numeroCOP = txtCop.Text,
                telefono = txtTelefono.Text,
                correo = actual == null ? null : actual.correo,   // el formulario aún no tiene campo de correo
                idEspecialidad = Convert.ToInt32(cboEspecialidad.SelectedValue),
                activo = chkActivo.Checked,
            };

            string mensaje;
            try
            {
                if (!negocioOdontologo.mtdGuardarOdontologo(o, out mensaje))
                {
                    MessageBox.Show(mensaje, "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MostrarErrorBD("guardar el odontólogo", ex);
                return;
            }

            CargarOdontologos(o.idOdontologo);
            Tema.Aviso(this, "Odontólogo guardado");
        }

        // Borrado lógico: el odontólogo queda "Inactivo" porque puede tener citas y atenciones.
        private void btnEliminarOdontologo_Click(object sender, EventArgs e)
        {
            clsOdontologo o = OdontologoSeleccionado();
            if (o == null) return;
            if (MessageBox.Show("¿Desactivar a " + o.NombreCompleto + "?\nSe conserva su historial de citas y atenciones.",
                                "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                negocioOdontologo.mtdDesactivarOdontologo(o.idOdontologo);
            }
            catch (Exception ex)
            {
                MostrarErrorBD("desactivar el odontólogo", ex);
                return;
            }
            CargarOdontologos(o.idOdontologo);
            Tema.Aviso(this, "Odontólogo desactivado");
        }

        // --------------------------------------------------------- Tratamientos

        /// <summary>Lee los tratamientos activos de la BD y deja seleccionado el de <paramref name="idSeleccionar"/> (0 = el primero).</summary>
        private void CargarTratamientos(int idSeleccionar)
        {
            List<clsTratamiento> lista;
            try
            {
                lista = negocioTratamiento.mtdListarTratamientos();
            }
            catch (Exception ex)
            {
                MostrarErrorBD("cargar los tratamientos", ex);
                return;
            }

            dgvTratamientos.Rows.Clear();
            foreach (clsTratamiento t in lista)
            {
                int i = dgvTratamientos.Rows.Add(t.codigo, t.nombre, t.duracionMin + " min", Tema.Dinero(t.precio));
                dgvTratamientos.Rows[i].Tag = t;
                if (t.idTratamiento == idSeleccionar)
                    dgvTratamientos.CurrentCell = dgvTratamientos.Rows[i].Cells[0];
            }
            if (dgvTratamientos.Rows.Count == 0) btnNuevoTratamiento_Click(null, EventArgs.Empty);
            dgvTratamientos_SelectionChanged(null, EventArgs.Empty);
        }

        private clsTratamiento TratamientoSeleccionado()
        {
            return dgvTratamientos.CurrentRow == null ? null : dgvTratamientos.CurrentRow.Tag as clsTratamiento;
        }

        private void dgvTratamientos_SelectionChanged(object sender, EventArgs e)
        {
            clsTratamiento t = TratamientoSeleccionado();
            if (t == null) return;
            txtNombreTratamiento.Text = t.nombre;
            txtPrecio.Text = t.precio.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            nudDuracion.Value = Math.Max(nudDuracion.Minimum, Math.Min(nudDuracion.Maximum, t.duracionMin));
            txtDescripcion.Text = t.descripcion;
        }

        private void btnNuevoTratamiento_Click(object sender, EventArgs e)
        {
            dgvTratamientos.CurrentCell = null;
            txtNombreTratamiento.Clear(); txtPrecio.Clear(); txtDescripcion.Clear();
            nudDuracion.Value = 30;
            txtNombreTratamiento.Focus();
        }

        private void btnGuardarTratamiento_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombreTratamiento, txtPrecio)) return;

            clsTratamiento actual = TratamientoSeleccionado();
            clsTratamiento t = new clsTratamiento
            {
                idTratamiento = actual == null ? 0 : actual.idTratamiento,
                nombre = txtNombreTratamiento.Text,
                descripcion = txtDescripcion.Text,
                precio = Tema.Numero(txtPrecio.Text),
                duracionMin = (int)nudDuracion.Value,
                activo = true,
            };

            string mensaje;
            try
            {
                if (!negocioTratamiento.mtdGuardarTratamiento(t, out mensaje))
                {
                    MessageBox.Show(mensaje, "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MostrarErrorBD("guardar el tratamiento", ex);
                return;
            }

            CargarTratamientos(t.idTratamiento);
            Tema.Aviso(this, "Tratamiento guardado");
        }

        // Borrado lógico: el tratamiento deja de listarse pero las citas y planes antiguos lo conservan.
        private void btnEliminarTratamiento_Click(object sender, EventArgs e)
        {
            clsTratamiento t = TratamientoSeleccionado();
            if (t == null) return;
            if (MessageBox.Show("¿Eliminar el tratamiento \"" + t.nombre + "\"?\nDejará de aparecer en la lista; las citas y planes anteriores se conservan.",
                                "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                negocioTratamiento.mtdDesactivarTratamiento(t.idTratamiento);
            }
            catch (Exception ex)
            {
                MostrarErrorBD("eliminar el tratamiento", ex);
                return;
            }
            CargarTratamientos(0);
            Tema.Aviso(this, "Tratamiento eliminado");
        }

        // ------------------------------------------------------------- Usuarios

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            DataGridViewRow f = dgvUsuarios.CurrentRow;
            txtUsuario.Text = Convert.ToString(f.Cells[colUsuario.Index].Value);
            txtNombreCompleto.Text = Convert.ToString(f.Cells[colNombre.Index].Value);
            Seleccionar(cboRol, Convert.ToString(f.Cells[colRol.Index].Value));
            txtContrasena.Text = "********";
            cboOdontologoVinculado.SelectedIndex = txtUsuario.Text == "mquispe" ? 1 : 0;
            chkUsuarioActivo.Checked = Convert.ToString(f.Cells[colEstadoUsuario.Index].Value) == "Activo";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            dgvUsuarios.CurrentCell = null;
            txtNombreCompleto.Clear(); txtUsuario.Clear(); txtContrasena.Clear();
            cboRol.SelectedIndex = -1;
            cboOdontologoVinculado.SelectedIndex = 0;
            chkUsuarioActivo.Checked = true;
            txtNombreCompleto.Focus();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombreCompleto, txtUsuario, cboRol, txtContrasena)) return;
            // TODO (pendiente BD): guardar la contraseña como SHA-256 + sal (nunca en texto plano).
            object[] fila = { txtUsuario.Text.Trim().ToLowerInvariant(), txtNombreCompleto.Text.Trim(), cboRol.SelectedItem, "—",
                              chkUsuarioActivo.Checked ? "Activo" : "Inactivo" };
            if (dgvUsuarios.CurrentRow == null)
                dgvUsuarios.Rows.Add(fila);
            else
                for (int i = 0; i < fila.Length; i++) if (i != 3) dgvUsuarios.CurrentRow.Cells[i].Value = fila[i];
            Tema.Aviso(this, "Usuario guardado");
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            dgvUsuarios.CurrentRow.Cells[colEstadoUsuario.Index].Value = "Inactivo";
            chkUsuarioActivo.Checked = false;
            Tema.Aviso(this, "Usuario desactivado");
        }
    }
}
