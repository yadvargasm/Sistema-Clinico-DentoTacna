using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmPrincipal : Form
    {
        private readonly Color colorTextoMenu = Color.FromArgb(235, 248, 248);

        private Form formularioActual;
        private readonly Dictionary<Guna2Button, Image> iconosBlancos = new Dictionary<Guna2Button, Image>();
        private readonly Dictionary<Guna2Button, Image> iconosVerdes = new Dictionary<Guna2Button, Image>();

        /// <summary>true si el usuario pulsó "Salir" (vuelve al login); false si cerró la ventana.</summary>
        public bool CerroSesion { get; private set; }

        public frmPrincipal()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            PrepararMenu();
            PrepararTablas();
            CargarPanelPrincipal();
            MarcarBotonActivo(btnInicio);
        }

        public frmPrincipal(string usuario, string nombre, string rol, string iniciales) : this()
        {
            lblNombreUsuario.Text = nombre;
            lblRolUsuario.Text = rol;
            lblAvatar.Text = iniciales;
            lblEstadoUsuario.Text = "Usuario: " + usuario + " (" + rol + ")";
            Tema.Aviso(this, "Bienvenido(a), " + nombre);
        }

        // ---------------------------------------------------------------- Menú

        private Guna2Button[] BotonesMenu
        {
            get { return new[] { btnInicio, btnCitas, btnPacientes, btnPagos, btnAsistente, btnMantenimiento }; }
        }

        private void PrepararMenu()
        {
            // Los íconos del menú son blancos; el botón activo (fondo blanco) usa la versión verde azulada.
            foreach (var b in BotonesMenu)
            {
                iconosBlancos[b] = b.Image;
                iconosVerdes[b] = Tema.ColorearIcono(b.Image, Tema.Marca600);
            }
        }

        private void MarcarBotonActivo(Guna2Button activo)
        {
            foreach (var b in BotonesMenu)
            {
                bool esActivo = b == activo;
                b.FillColor = esActivo ? Color.White : Color.Transparent;
                b.HoverState.FillColor = esActivo ? Color.White : Color.FromArgb(28, 255, 255, 255);
                b.ForeColor = esActivo ? Tema.Marca600 : colorTextoMenu;
                b.HoverState.ForeColor = b.ForeColor;
                b.Font = new Font("Segoe UI", 9.75F, esActivo ? FontStyle.Bold : FontStyle.Regular);
                b.Image = esActivo ? iconosVerdes[b] : iconosBlancos[b];
            }
        }

        /// <summary>Muestra un módulo dentro del área de contenido (sin tapar el menú ni la barra de estado).</summary>
        private void AbrirFormulario(Form formulario, Guna2Button boton)
        {
            CerrarFormularioActual();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlArea.Controls.Add(formulario);
            pnlDashboard.Visible = false;
            formulario.BringToFront();
            formulario.Show();

            formularioActual = formulario;
            lblEstadoFormulario.Text = "Formulario: " + formulario.Name;
            MarcarBotonActivo(boton);
        }

        private void CerrarFormularioActual()
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
                formularioActual.Dispose();
                formularioActual = null;
            }
            pnlDashboard.Visible = true;
            lblEstadoFormulario.Text = "Formulario: frmPrincipal";
        }

        private void IrAlPanel()
        {
            CerrarFormularioActual();
            MarcarBotonActivo(btnInicio);
        }

        private void btnInicio_Click(object sender, EventArgs e) { IrAlPanel(); }
        private void btnCitas_Click(object sender, EventArgs e) { AbrirFormulario(new frmCitas(), btnCitas); }
        private void btnPacientes_Click(object sender, EventArgs e) { AbrirFormulario(new frmPacientes(), btnPacientes); }
        private void btnPagos_Click(object sender, EventArgs e) { AbrirFormulario(new frmPagos(), btnPagos); }
        private void btnAsistente_Click(object sender, EventArgs e) { AbrirFormulario(new frmAsistente(lblNombreUsuario.Text, lblAvatar.Text), btnAsistente); }
        private void btnMantenimiento_Click(object sender, EventArgs e) { AbrirFormulario(new frmMantenimiento(), btnMantenimiento); }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerroSesion = true;
            Close();
        }

        // ------------------------------------------------------- Barra superior

        private void btnNuevaCita_Click(object sender, EventArgs e) { AbrirFormulario(new frmCitas(), btnCitas); }
        private void btnNuevoPaciente_Click(object sender, EventArgs e) { AbrirFormulario(new frmPacientes(), btnPacientes); }
        private void btnRecordatorios_Click(object sender, EventArgs e) { IrAlPanel(); }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // TODO (pendiente BD): volver a leer los datos desde la Capa de Negocio.
            Tema.Aviso(this, "Datos actualizados");
        }

        private void txtBuscarPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            AbrirFormulario(new frmPacientes(txtBuscarPaciente.Text.Trim()), btnPacientes);
        }

        // ------------------------------------------------------ Panel principal

        private void PrepararTablas()
        {
            Tema.PintarEtiquetas(dgvCitas, "colEstado");
            Tema.PintarEtiquetas(dgvRecordatorios, "colRRecordatorio");
            dgvRecordatorios.CellPainting += PintarBotonAvisar;
            dgvRecordatorios.CellMouseMove += (s, e) =>
            {
                bool sobreBoton = e.RowIndex >= 0 && e.ColumnIndex == colRAvisar.Index
                                  && Convert.ToString(dgvRecordatorios.Rows[e.RowIndex].Cells[colRAvisar.Index].Value) != "";
                dgvRecordatorios.Cursor = sobreBoton ? Cursors.Hand : Cursors.Default;
            };
        }

        private void CargarPanelPrincipal()
        {
            lblFecha.Text = Tema.FechaLarga(DatosDemo.Hoy);
            lblEstadoFecha.Text = DatosDemo.Hoy.ToString("ddd dd/MM/yyyy", new System.Globalization.CultureInfo("es-PE"));
            lblAvisoDia.Left = lblAvisoDiaTitulo.Right + 2;

            dgvCitas.Rows.Clear();
            foreach (object[] fila in DatosDemo.CitasHoy) dgvCitas.Rows.Add(fila);
            if (dgvCitas.Rows.Count > 4) dgvCitas.Rows[4].Selected = true;

            dgvRecordatorios.Rows.Clear();
            foreach (object[] fila in DatosDemo.RecordatoriosManana)
            {
                int i = dgvRecordatorios.Rows.Add(fila);
                dgvRecordatorios.Rows[i].Cells[colRAvisar.Index].Value = (string)fila[4] == "Pendiente" ? "Avisar" : "";
            }
            dgvRecordatorios.ClearSelection();

            ActualizarIndicadores();
        }

        private void ActualizarIndicadores()
        {
            int atendidas = 0, sinConfirmar = 0;
            foreach (DataGridViewRow f in dgvCitas.Rows)
            {
                string estado = Convert.ToString(f.Cells[colEstado.Index].Value);
                if (estado == "Atendida") atendidas++;
                if (estado == "Sin confirmar") sinConfirmar++;
            }
            int pendientes = RecordatoriosPendientes();

            lblTotalCitas.Text = dgvCitas.Rows.Count.ToString();
            lblTextoCitas.Text = "Citas hoy · " + atendidas + " atendidas";
            lblTotalManana.Text = dgvRecordatorios.Rows.Count.ToString();
            lblTextoManana.Text = "Citas mañana · " + pendientes + " por recordar";

            lblAvisoDia.Text = "hoy vienen " + dgvCitas.Rows.Count + " pacientes. " + sinConfirmar +
                               " aún no confirman su cita y hay " + pendientes +
                               " recordatorios para las citas de mañana sin enviar.";

            lblBadgeRecordatorios.Text = pendientes.ToString();
            lblBadgeRecordatorios.Visible = pendientes > 0;
        }

        private int RecordatoriosPendientes()
        {
            int n = 0;
            foreach (DataGridViewRow f in dgvRecordatorios.Rows)
            {
                if (Convert.ToString(f.Cells[colRRecordatorio.Index].Value) == "Pendiente") n++;
            }
            return n;
        }

        private void btnMarcarAtendida_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            dgvCitas.CurrentRow.Cells[colEstado.Index].Value = "Atendida";
            ActualizarIndicadores();
            Tema.Aviso(this, "Cita de " + dgvCitas.CurrentRow.Cells[colPaciente.Index].Value + " marcada como atendida");
        }

        private void btnReprogramar_Click(object sender, EventArgs e) { AbrirFormulario(new frmCitas(), btnCitas); }

        private void dgvCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) AbrirFormulario(new frmCitas(), btnCitas);
        }

        private void btnAbrirFicha_Click(object sender, EventArgs e) { AbrirFormulario(new frmPacientes(), btnPacientes); }
        private void btnCobrar_Click(object sender, EventArgs e) { AbrirFormulario(new frmPagos(), btnPagos); }

        // ------------------------------------------- Recordatorios (WhatsApp)

        private void PintarBotonAvisar(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colRAvisar.Index) return;
            e.PaintBackground(e.CellBounds, true);
            if (Convert.ToString(e.Value) == "")
            {
                e.Handled = true;
                return;
            }

            var r = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, Math.Min(84, e.CellBounds.Width - 12), e.CellBounds.Height - 12);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var p = Tema.Redondeado(r, 5))
            using (var fondo = new SolidBrush(Color.White))
            using (var borde = new Pen(Tema.LineaFuerte))
            {
                e.Graphics.FillPath(fondo, p);
                e.Graphics.DrawPath(borde, p);
            }
            using (var verde = new SolidBrush(Color.FromArgb(37, 162, 68)))
            {
                e.Graphics.FillEllipse(verde, r.X + 8, r.Y + (r.Height - 10) / 2, 10, 10);
            }
            TextRenderer.DrawText(e.Graphics, "Avisar", Tema.FuenteChica, new Rectangle(r.X + 22, r.Y, r.Width - 24, r.Height),
                Tema.Texto, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            e.Handled = true;
        }

        private void dgvRecordatorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colRAvisar.Index) return;
            DataGridViewRow fila = dgvRecordatorios.Rows[e.RowIndex];
            if (Convert.ToString(fila.Cells[colRAvisar.Index].Value) == "") return;

            string hora = Convert.ToString(fila.Cells[colRHora.Index].Value);
            string telefono = Convert.ToString(fila.Cells[colRTelefono.Index].Value);
            string paciente = Convert.ToString(fila.Cells[colRPaciente.Index].Value);
            AbrirWhatsApp(telefono, "Hola, le recordamos su cita en DentoTacna mañana a las " + hora + ". Responda SÍ para confirmar.");

            fila.Cells[colRRecordatorio.Index].Value = "Enviado";
            fila.Cells[colRAvisar.Index].Value = "";
            ActualizarIndicadores();
            Tema.Aviso(this, "Recordatorio enviado por WhatsApp a " + paciente);
        }

        /// <summary>Abre WhatsApp (web o escritorio) con el mensaje listo. El envío lo confirma la recepcionista.</summary>
        private static void AbrirWhatsApp(string telefono, string mensaje)
        {
            string numero = new string(Array.FindAll(telefono.ToCharArray(), char.IsDigit));
            if (!telefono.StartsWith("+")) numero = "51" + numero; // Perú por defecto
            string url = "https://wa.me/" + numero + "?text=" + Uri.EscapeDataString(mensaje);
            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                // Sin navegador configurado: el estado se marca igual para la demostración.
            }
        }
    }
}
