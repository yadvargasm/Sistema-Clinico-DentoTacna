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

        public frmMantenimiento()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            Tema.PintarEtiquetas(dgvOdontologos, "colEstado");
            Tema.PintarEtiquetas(dgvUsuarios, "colEstadoUsuario");

            cboRol.Items.AddRange(DatosDemo.Roles);
            cboOdontologoVinculado.Items.Add("— Ninguno —");
            cboOdontologoVinculado.Items.AddRange(DatosDemo.OdontologosLargo);

            CargarEspecialidades();
            CargarOdontologos(0);

            // TODO (pendiente BD): leer tratamientos y usuarios desde la Capa de Negocio.
            foreach (object[] t in DatosDemo.Tratamientos)
                dgvTratamientos.Rows.Add(t[0], t[1], t[2] + " min", Tema.Dinero((decimal)t[3]));
            foreach (object[] u in DatosDemo.UsuariosTabla)
                dgvUsuarios.Rows.Add(u);

            if (dgvTratamientos.Rows.Count > 1) dgvTratamientos.CurrentCell = dgvTratamientos.Rows[1].Cells[0];
            dgvTratamientos_SelectionChanged(null, EventArgs.Empty);
            if (dgvUsuarios.Rows.Count > 2) dgvUsuarios.CurrentCell = dgvUsuarios.Rows[2].Cells[0];
            dgvUsuarios_SelectionChanged(null, EventArgs.Empty);
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
                cboEspecialidad.DataSource = negocioOdontologo.mtdListarEspecialidades();
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

        private void dgvTratamientos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow == null) return;
            DataGridViewRow f = dgvTratamientos.CurrentRow;
            txtNombreTratamiento.Text = Convert.ToString(f.Cells[colTratamiento.Index].Value);
            txtPrecio.Text = Tema.Numero(Convert.ToString(f.Cells[colPrecio.Index].Value).Replace(" ", "")).ToString("0.00");
            int minutos;
            if (int.TryParse(Convert.ToString(f.Cells[colDuracion.Index].Value).Replace(" min", ""), out minutos))
                nudDuracion.Value = Math.Max(nudDuracion.Minimum, Math.Min(nudDuracion.Maximum, minutos));
            txtDescripcion.Text = txtNombreTratamiento.Text == "Resina compuesta" ? "Restauración estética de una pieza dental." : "";
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
            decimal precio = Tema.Numero(txtPrecio.Text);
            object[] fila = { null, txtNombreTratamiento.Text.Trim(), nudDuracion.Value + " min", Tema.Dinero(precio) };
            if (dgvTratamientos.CurrentRow == null)
            {
                fila[0] = "TR-" + (dgvTratamientos.Rows.Count + 1).ToString("00");
                dgvTratamientos.Rows.Add(fila);
            }
            else
            {
                for (int i = 1; i < fila.Length; i++) dgvTratamientos.CurrentRow.Cells[i].Value = fila[i];
            }
            Tema.Aviso(this, "Tratamiento guardado");
        }

        private void btnEliminarTratamiento_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow == null) return;
            if (MessageBox.Show("¿Eliminar el tratamiento seleccionado?", "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            dgvTratamientos.Rows.Remove(dgvTratamientos.CurrentRow);
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
