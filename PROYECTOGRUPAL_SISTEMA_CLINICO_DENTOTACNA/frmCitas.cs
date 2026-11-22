using System;
using System.Globalization;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmCitas : Form
    {
        private const string TodosOdontologos = "Todos los odontólogos";
        private const string TodosEstados = "Todos los estados";

        public frmCitas()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            Tema.PintarEtiquetas(dgvCitas, "colEstado", "colRecordatorio");
            CargarCombos();
            CargarCitas();
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            if (dgvCitas.Rows.Count > 1) dgvCitas.CurrentCell = dgvCitas.Rows[1].Cells[0];
            dgvCitas_SelectionChanged(dgvCitas, EventArgs.Empty);
        }

        private void CargarCombos()
        {
            // TODO (pendiente BD): llenar desde la Capa de Negocio (pacientes, odontólogos activos, tratamientos, estados).
            foreach (object[] p in DatosDemo.Pacientes)
            {
                cboPaciente.Items.Add(NombreNatural((string)p[1]) + " — " + p[0]);
            }
            cboOdontologo.Items.AddRange(DatosDemo.OdontologosLargo);
            foreach (object[] t in DatosDemo.Tratamientos) cboTratamiento.Items.Add(t[1]);
            cboEstado.Items.AddRange(DatosDemo.EstadosCita);

            cboFiltroOdontologo.Items.Add(TodosOdontologos);
            cboFiltroOdontologo.Items.AddRange(DatosDemo.OdontologosLargo);
            cboFiltroEstado.Items.Add(TodosEstados);
            cboFiltroEstado.Items.AddRange(DatosDemo.EstadosCita);
            cboFiltroOdontologo.SelectedIndex = 0;
            cboFiltroEstado.SelectedIndex = 0;
        }

        /// <summary>"Castillo Ugarte, María Elena" → "María Elena Castillo Ugarte"</summary>
        private static string NombreNatural(string apellidosNombres)
        {
            string[] partes = apellidosNombres.Split(',');
            return partes.Length == 2 ? partes[1].Trim() + " " + partes[0].Trim() : apellidosNombres;
        }

        private void CargarCitas()
        {
            dgvCitas.Rows.Clear();
            foreach (object[] fila in DatosDemo.Citas) dgvCitas.Rows.Add(fila);
            ActualizarContador();
        }

        private void ActualizarContador()
        {
            int visibles = 0;
            foreach (DataGridViewRow f in dgvCitas.Rows) if (f.Visible) visibles++;
            lblRegistros.Text = visibles + (visibles == 1 ? " registro" : " registros");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFiltroFecha.Value.ToString("dd/MM/yyyy");
            string odontologo = Convert.ToString(cboFiltroOdontologo.SelectedItem);
            string estado = Convert.ToString(cboFiltroEstado.SelectedItem);

            dgvCitas.CurrentCell = null;
            foreach (DataGridViewRow f in dgvCitas.Rows)
            {
                bool ok = Convert.ToString(f.Cells[colFecha.Index].Value) == fecha;
                if (odontologo != TodosOdontologos)
                    ok &= CoincideOdontologo(Convert.ToString(f.Cells[colOdontologo.Index].Value), odontologo);
                if (estado != TodosEstados)
                    ok &= Convert.ToString(f.Cells[colEstado.Index].Value) == estado;
                f.Visible = ok;
            }
            ActualizarContador();
        }

        /// <summary>"Dr. M. Quispe" coincide con "Dr. Martín Quispe" (mismo apellido).</summary>
        private static bool CoincideOdontologo(string corto, string largo)
        {
            string[] a = corto.Split(' '), b = largo.Split(' ');
            return a[a.Length - 1] == b[b.Length - 1];
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null || !dgvCitas.CurrentRow.Visible) return;
            DataGridViewRow f = dgvCitas.CurrentRow;

            SeleccionarQueContenga(cboPaciente, Convert.ToString(f.Cells[colPaciente.Index].Value).Split(' ')[0]);
            string odo = Convert.ToString(f.Cells[colOdontologo.Index].Value);
            for (int i = 0; i < cboOdontologo.Items.Count; i++)
                if (CoincideOdontologo(odo, (string)cboOdontologo.Items[i])) cboOdontologo.SelectedIndex = i;
            SeleccionarQueContenga(cboTratamiento, Convert.ToString(f.Cells[colTratamiento.Index].Value).Split(' ')[0]);
            cboEstado.SelectedItem = Convert.ToString(f.Cells[colEstado.Index].Value);

            DateTime fecha;
            if (DateTime.TryParseExact(Convert.ToString(f.Cells[colFecha.Index].Value) + " " + Convert.ToString(f.Cells[colHora.Index].Value),
                "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                dtpFecha.Value = fecha.Date;
                dtpHora.Value = fecha;
            }
            chkRecordarDiaAntes.Checked = true;
            chkMostrarPanel.Checked = true;
            txtObservaciones.Text = Convert.ToString(f.Cells[colPaciente.Index].Value).StartsWith("María Elena")
                ? "Paciente alérgica a la penicilina." : "";
        }

        private static void SeleccionarQueContenga(ComboBox combo, string texto)
        {
            combo.SelectedIndex = -1;
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (Convert.ToString(combo.Items[i]).IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void dgvCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) cboPaciente.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCitas.ClearSelection();
            dgvCitas.CurrentCell = null;
            cboPaciente.SelectedIndex = -1;
            cboOdontologo.SelectedIndex = -1;
            cboTratamiento.SelectedIndex = -1;
            cboEstado.SelectedItem = "Programada";
            dtpFecha.Value = DatosDemo.Hoy;
            dtpHora.Value = DatosDemo.Hoy.AddHours(9);
            chkRecordarDiaAntes.Checked = true;
            chkMostrarPanel.Checked = true;
            txtObservaciones.Clear();
            cboPaciente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedIndex < 0 || cboOdontologo.SelectedIndex < 0 || cboTratamiento.SelectedIndex < 0)
            {
                MessageBox.Show("Complete los campos obligatorios (*).", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO (pendiente BD): guardar con la Capa de Negocio (valida que el odontólogo no tenga otra cita a esa hora).
            string paciente = Convert.ToString(cboPaciente.SelectedItem).Split('—')[0].Trim();
            string[] odo = Convert.ToString(cboOdontologo.SelectedItem).Split(' ');
            string odontologoCorto = odo[0] + " " + odo[1][0] + ". " + odo[odo.Length - 1];
            object[] valores =
            {
                null,
                dtpFecha.Value.ToString("dd/MM/yyyy"),
                dtpHora.Value.ToString("HH:mm"),
                paciente,
                null,
                cboTratamiento.SelectedItem,
                odontologoCorto,
                cboEstado.SelectedItem ?? "Programada",
                chkRecordarDiaAntes.Checked ? "Pendiente" : "—"
            };

            DataGridViewRow fila = dgvCitas.CurrentRow;
            if (fila == null || dgvCitas.SelectedRows.Count == 0)
            {
                int ultimo = 10230 + dgvCitas.Rows.Count + 1;
                valores[0] = ultimo.ToString();
                valores[4] = "—";
                fila = dgvCitas.Rows[dgvCitas.Rows.Add(valores)];
            }
            else
            {
                for (int i = 0; i < valores.Length; i++)
                    if (valores[i] != null) fila.Cells[i].Value = valores[i];
            }
            fila.Selected = true;
            ActualizarContador();
            Tema.Aviso(this, "Cita guardada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            if (MessageBox.Show("¿Eliminar la cita seleccionada?", "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            dgvCitas.Rows.Remove(dgvCitas.CurrentRow);
            ActualizarContador();
            Tema.Aviso(this, "Cita eliminada");
        }
    }
}
