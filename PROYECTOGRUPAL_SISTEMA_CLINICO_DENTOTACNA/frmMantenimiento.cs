using System;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            Tema.PintarEtiquetas(dgvOdontologos, "colEstado");
            Tema.PintarEtiquetas(dgvUsuarios, "colEstadoUsuario");

            cboEspecialidad.Items.AddRange(DatosDemo.Especialidades);
            cboRol.Items.AddRange(DatosDemo.Roles);
            cboOdontologoVinculado.Items.Add("— Ninguno —");
            cboOdontologoVinculado.Items.AddRange(DatosDemo.OdontologosLargo);

            // TODO (pendiente BD): leer odontólogos, tratamientos y usuarios desde la Capa de Negocio.
            foreach (object[] o in DatosDemo.Odontologos)
                dgvOdontologos.Rows.Add(o[0], o[1], o[2], o[3], o[5]);
            foreach (object[] t in DatosDemo.Tratamientos)
                dgvTratamientos.Rows.Add(t[0], t[1], t[2] + " min", Tema.Dinero((decimal)t[3]));
            foreach (object[] u in DatosDemo.UsuariosTabla)
                dgvUsuarios.Rows.Add(u);

            dgvOdontologos_SelectionChanged(null, EventArgs.Empty);
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

        // ---------------------------------------------------------- Odontólogos

        private void dgvOdontologos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOdontologos.CurrentRow == null) return;
            DataGridViewRow f = dgvOdontologos.CurrentRow;
            string nombre = Convert.ToString(f.Cells[colOdontologo.Index].Value);
            string[] p = nombre.Replace("Dra. ", "").Replace("Dr. ", "").Split(' ');
            txtNombres.Text = p[0];
            txtApellidos.Text = p.Length > 1 ? string.Join(" ", p, 1, p.Length - 1) : "";
            txtCop.Text = Convert.ToString(f.Cells[colCop.Index].Value);
            txtTelefono.Text = Convert.ToString(DatosDemo.Odontologos[Math.Min(f.Index, DatosDemo.Odontologos.Length - 1)][4]);
            Seleccionar(cboEspecialidad, Convert.ToString(f.Cells[colEspecialidad.Index].Value));
            chkActivo.Checked = Convert.ToString(f.Cells[colEstado.Index].Value) == "Activo";
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
            // TODO (pendiente BD): el N.° COP debe ser único (lo valida la Capa de Negocio).
            string nombre = "Dr(a). " + txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();
            object[] fila = { null, nombre, txtCop.Text.Trim(), cboEspecialidad.SelectedItem, chkActivo.Checked ? "Activo" : "Inactivo" };
            if (dgvOdontologos.CurrentRow == null)
            {
                fila[0] = "OD-" + (dgvOdontologos.Rows.Count + 1).ToString("00");
                dgvOdontologos.Rows.Add(fila);
            }
            else
            {
                for (int i = 1; i < fila.Length; i++) dgvOdontologos.CurrentRow.Cells[i].Value = fila[i];
            }
            Tema.Aviso(this, "Odontólogo guardado");
        }

        private void btnEliminarOdontologo_Click(object sender, EventArgs e)
        {
            if (dgvOdontologos.CurrentRow == null) return;
            if (MessageBox.Show("¿Eliminar el odontólogo seleccionado?", "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            dgvOdontologos.Rows.Remove(dgvOdontologos.CurrentRow);
            Tema.Aviso(this, "Odontólogo eliminado");
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
