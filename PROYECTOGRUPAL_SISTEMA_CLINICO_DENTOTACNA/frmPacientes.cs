using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmPacientes : Form
    {
        // Paciente de ejemplo con la ficha completa (el resto solo trae nombre y programa).
        private const string HistoriaEjemplo = "HC-00482";

        private bool cargando;

        public frmPacientes()
        {
            InitializeComponent();
            Tema.Aplicar(this);

            // Pestañas largas: solo desplazamiento vertical.
            foreach (TabPage pagina in new[] { tabDatos, tabConsentimiento, tabPlan, tabOdontograma })
            {
                pagina.AutoScroll = false;
                pagina.HorizontalScroll.Maximum = 0;
                pagina.HorizontalScroll.Visible = false;
                pagina.VerticalScroll.Visible = true;
                pagina.AutoScroll = true;
            }
            foreach (Control soloLectura in new Control[] { txtHistoria, txtEdad, txtConsPaciente, txtPlSaldo })
                soloLectura.TabStop = false;

            cargando = true;
            CargarCombos();
            CrearAnamnesis();
            PrepararOdontograma();
            PrepararPlan();
            CargarEvolucion();
            CargarImagenes();
            CargarPacientes();
            cargando = false;

            dgvPacientes_SelectionChanged(dgvPacientes, EventArgs.Empty);
        }

        /// <summary>Abre Pacientes ya filtrado (lo usa la búsqueda de la barra superior).</summary>
        public frmPacientes(string busqueda) : this()
        {
            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                txtBuscar.Text = busqueda;
                btnBuscar_Click(btnBuscar, EventArgs.Empty);
            }
        }

        // ================================================================ Lista

        private void CargarCombos()
        {
            cboFiltroPrograma.Items.Add("Todos");
            cboFiltroPrograma.Items.AddRange(DatosDemo.Programas);
            cboFiltroPrograma.SelectedIndex = 0;
            cboFiltroPrograma.SelectedIndexChanged += (s, e) => FiltrarPacientes();

            cboTipoDoc.Items.AddRange(new object[] { "DNI", "RUT (Chile)", "Carnet de extranjería", "Pasaporte" });
            cboTipoDoc.SelectedIndex = 0;
            cboTipoDoc.SelectedIndexChanged += cboTipoDoc_SelectedIndexChanged;

            cboPrograma.Items.AddRange(DatosDemo.Programas);
            cboPrograma.SelectedIndexChanged += cboPrograma_SelectedIndexChanged;

            cboConsOdontologo.Items.AddRange(DatosDemo.OdontologosCop);
            cboPlDoctor.Items.AddRange(DatosDemo.OdontologosCorto);
            foreach (object[] t in DatosDemo.Tratamientos) cboPlTratamiento.Items.Add(t[1]);

            dtpNacimiento.ValueChanged += (s, e) => CalcularEdad();
            txtBuscar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnBuscar_Click(btnBuscar, EventArgs.Empty); }
            };
            chkConsFirmado.CheckedChanged += (s, e) => MostrarEstadoConsentimiento();
            Tema.PintarEtiquetas(dgvPacientes, "colPrograma");
        }

        private void CargarPacientes()
        {
            // TODO (pendiente BD): leer pacientes desde la Capa de Negocio.
            foreach (object[] p in DatosDemo.Pacientes) dgvPacientes.Rows.Add(p);
            foreach (DataGridViewRow f in dgvPacientes.Rows)
            {
                if ((string)f.Cells[colHistoria.Index].Value == HistoriaEjemplo)
                {
                    dgvPacientes.CurrentCell = f.Cells[0];
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) { FiltrarPacientes(); }

        private void FiltrarPacientes()
        {
            string texto = txtBuscar.Text.Trim().ToLowerInvariant();
            string programa = Convert.ToString(cboFiltroPrograma.SelectedItem);
            dgvPacientes.CurrentCell = null;
            DataGridViewRow primera = null;

            foreach (DataGridViewRow f in dgvPacientes.Rows)
            {
                string historia = Convert.ToString(f.Cells[colHistoria.Index].Value);
                string nombre = Convert.ToString(f.Cells[colPaciente.Index].Value);
                bool coincide = texto == "" || historia.ToLowerInvariant().Contains(texto) || nombre.ToLowerInvariant().Contains(texto)
                                || (historia == HistoriaEjemplo && "45872136".Contains(texto));
                bool ok = coincide && (programa == "Todos" || Convert.ToString(f.Cells[colPrograma.Index].Value) == programa);
                f.Visible = ok;
                if (ok && primera == null) primera = f;
            }
            if (primera != null) dgvPacientes.CurrentCell = primera.Cells[0];
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvPacientes.CurrentRow == null) return;
            DataGridViewRow f = dgvPacientes.CurrentRow;
            string historia = Convert.ToString(f.Cells[colHistoria.Index].Value);
            string[] partes = Convert.ToString(f.Cells[colPaciente.Index].Value).Split(',');
            string apellidos = partes[0].Trim();
            string nombres = partes.Length > 1 ? partes[1].Trim() : "";
            MostrarPaciente(historia, nombres, apellidos, Convert.ToString(f.Cells[colPrograma.Index].Value));
        }

        // ===================================================== Datos personales

        private void MostrarPaciente(string historia, string nombres, string apellidos, string programa)
        {
            bool ejemplo = historia == HistoriaEjemplo;
            cargando = true;

            cboTipoDoc.SelectedIndex = 0;
            txtNumDoc.Text = ejemplo ? "45872136" : "";
            txtHistoria.Text = historia;
            pnlReniecOk.Visible = ejemplo;
            lblReniecOk.Text = "Datos verificados con RENIEC el 05/11/2026.";
            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            dtpNacimiento.Value = ejemplo ? new DateTime(1992, 3, 14) : new DateTime(1990, 1, 1);
            cboSexo.SelectedIndex = ejemplo ? 0 : -1;
            txtTelefono.Text = ejemplo ? "956 302 118" : "";
            txtCorreo.Text = ejemplo ? "mecastillo@correo.pe" : "";
            txtDomicilio.Text = ejemplo ? "Av. Bolognesi 845, Tacna" : "";
            txtMotivoConsulta.Text = ejemplo ? "Dolor al masticar en el lado superior derecho" : "";
            cboPrograma.SelectedItem = programa;
            txtResponsable.Clear();
            txtDniResponsable.Clear();
            CalcularEdad();

            // Anamnesis
            CargarAnamnesis(ejemplo);

            // Consentimiento
            txtConsPaciente.Text = (nombres + " " + apellidos).Trim() + (ejemplo ? " — DNI 45872136" : "");
            cboConsOdontologo.SelectedIndex = 0;
            chkConsFirmado.Checked = ejemplo;
            MostrarEstadoConsentimiento();

            // Odontograma, plan, evolución e imágenes solo tienen datos de ejemplo para María Elena.
            odontograma["inicial"] = ejemplo
                ? new Dictionary<int, string> { { 14, "caries" }, { 36, "endodoncia" }, { 18, "ausente" }, { 48, "extraccion" }, { 26, "restaurado" } }
                : new Dictionary<int, string>();
            odontograma["final"] = new Dictionary<int, string>();
            MostrarTipoOdontograma("inicial");

            plan.Clear();
            if (ejemplo) CargarPlanEjemplo();
            DibujarPlan();

            dgvHistoria.Visible = true;
            dgvHistoria.Rows.Clear();
            if (ejemplo) foreach (object[] fila in DatosDemo.Evolucion) dgvHistoria.Rows.Add(fila);

            flpImagenes.Visible = true;
            CargarImagenes(ejemplo);

            cargando = false;
            ActualizarAlertas();
        }

        private void CalcularEdad()
        {
            DateTime hoy = DatosDemo.Hoy, nac = dtpNacimiento.Value.Date;
            int edad = hoy.Year - nac.Year;
            if (hoy < nac.AddYears(edad)) edad--;
            txtEdad.Text = edad + " años";
            pnlApoderado.Visible = edad < 18;
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool dni = cboTipoDoc.SelectedIndex == 0;
            txtNumDoc.MaxLength = dni ? 8 : 12;
            string[] ayudas = { "8 dígitos", "12.345.678-9", "N.° de carnet", "N.° de pasaporte" };
            txtNumDoc.PlaceholderText = ayudas[Math.Max(0, cboTipoDoc.SelectedIndex)];
            if (!cargando) txtNumDoc.Clear();
            btnReniec.Enabled = dni;
            pnlReniecOk.Visible = false;
        }

        private void btnReniec_Click(object sender, EventArgs e)
        {
            string dni = txtNumDoc.Text.Trim();
            if (dni.Length != 8 || !EsNumero(dni))
            {
                Tema.Aviso(this, "El DNI debe tener 8 dígitos");
                return;
            }
            // TODO (pendiente): conectar con el servicio de consulta RENIEC que contrate la clínica.
            lblReniecOk.Text = "Datos verificados con RENIEC hoy. Nombres y apellidos completados automáticamente.";
            pnlReniecOk.Visible = true;
            Tema.Aviso(this, "Consulta a RENIEC correcta");
        }

        private static bool EsNumero(string s)
        {
            foreach (char c in s) if (!char.IsDigit(c)) return false;
            return s.Length > 0;
        }

        private void cboPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando || cboPrograma.SelectedItem == null) return;
            if (dgvPacientes.CurrentRow != null)
                dgvPacientes.CurrentRow.Cells[colPrograma.Index].Value = cboPrograma.SelectedItem;
            Tema.Aviso(this, "Programa cambiado a " + cboPrograma.SelectedItem + ". El N.° de historia " + txtHistoria.Text + " se mantiene.");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cargando = true;
            dgvPacientes.CurrentCell = null;
            MostrarPaciente("", "", "", "General");
            txtHistoria.Text = "Se genera al guardar";
            cargando = false;
            tabPaciente.SelectedTab = tabDatos;
            txtNumDoc.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obligatorios = new List<Control> { txtNumDoc, txtNombres, txtApellidos, txtTelefono, txtMotivoConsulta };
            if (pnlApoderado.Visible) { obligatorios.Add(txtResponsable); obligatorios.Add(txtDniResponsable); }
            foreach (Control c in obligatorios)
            {
                if (c.Text.Trim() == "")
                {
                    MessageBox.Show("Complete los campos obligatorios (*).", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c.Focus();
                    return;
                }
            }
            if (cboSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el sexo del paciente.", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO (pendiente BD): guardar con la Capa de Negocio; el N.° de historia lo genera la base de datos.
            string nombreLista = txtApellidos.Text.Trim() + ", " + txtNombres.Text.Trim();
            if (dgvPacientes.CurrentRow == null)
            {
                string historia = "HC-" + (519 + dgvPacientes.Rows.Count - DatosDemo.Pacientes.Length).ToString("00000");
                int i = dgvPacientes.Rows.Add(historia, nombreLista, cboPrograma.SelectedItem ?? "General");
                txtHistoria.Text = historia;
                cargando = true;
                dgvPacientes.CurrentCell = dgvPacientes.Rows[i].Cells[0];
                cargando = false;
            }
            else
            {
                dgvPacientes.CurrentRow.Cells[colPaciente.Index].Value = nombreLista;
            }
            Tema.Aviso(this, "Paciente guardado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;
            if (MessageBox.Show("¿Eliminar al paciente seleccionado?", "DentoTacna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            dgvPacientes.Rows.Remove(dgvPacientes.CurrentRow);
            Tema.Aviso(this, "Paciente eliminado");
        }

        // ============================================================ Anamnesis

        private readonly List<Guna2RadioButton> respuestasSi = new List<Guna2RadioButton>();
        private readonly List<Guna2RadioButton> respuestasNo = new List<Guna2RadioButton>();
        private readonly List<Guna2TextBox> detalles = new List<Guna2TextBox>();
        private readonly List<Panel> filasAnamnesis = new List<Panel>();

        private void CrearAnamnesis()
        {
            string[] ayudas = new string[DatosDemo.Anamnesis.Length];
            ayudas[10] = "¿A qué medicamento?";
            ayudas[11] = "¿Qué medicamento y dosis?";

            pnlPreguntas.SuspendLayout();
            for (int i = 0; i < DatosDemo.Anamnesis.Length; i++)
            {
                var fila = new Panel { Location = new Point(0, i * 36), Size = new Size(pnlPreguntas.ClientSize.Width, 36), BackColor = Color.White, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                fila.Paint += (s, e) =>
                {
                    using (var pen = new Pen(Color.FromArgb(238, 242, 244)))
                        e.Graphics.DrawLine(pen, 0, ((Panel)s).Height - 1, ((Panel)s).Width, ((Panel)s).Height - 1);
                };
                var n = new Label { Text = (i + 1) + ".", Location = new Point(6, 9), Size = new Size(26, 17), ForeColor = Tema.Suave, TextAlign = ContentAlignment.TopRight, BackColor = Color.Transparent };
                var preg = new Label { Text = DatosDemo.Anamnesis[i], Location = new Point(38, 9), AutoSize = true, ForeColor = Tema.Texto, BackColor = Color.Transparent };
                var si = new Guna2RadioButton { Text = "SÍ", Location = new Point(350, 8), AutoSize = true };
                var no = new Guna2RadioButton { Text = "NO", Location = new Point(410, 8), AutoSize = true, Checked = true };
                var det = new Guna2TextBox { Location = new Point(476, 3), Size = new Size(fila.Width - 486, 30), PlaceholderText = ayudas[i] ?? "Detalle (opcional)", Enabled = false, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                si.CheckedChanged += (s, e) => ActualizarAlertas();
                det.TextChanged += (s, e) => ActualizarAlertas();

                fila.Controls.AddRange(new Control[] { n, preg, si, no, det });
                pnlPreguntas.Controls.Add(fila);
                respuestasSi.Add(si);
                respuestasNo.Add(no);
                detalles.Add(det);
                filasAnamnesis.Add(fila);
            }
            pnlPreguntas.ResumeLayout();
            Tema.Aplicar(pnlPreguntas);
            txtOtros.TextChanged += (s, e) => ActualizarAlertas();
        }

        private void CargarAnamnesis(bool ejemplo)
        {
            for (int i = 0; i < respuestasSi.Count; i++)
            {
                bool si = ejemplo && (i == 0 || i == 10);
                respuestasSi[i].Checked = si;
                respuestasNo[i].Checked = !si;
                detalles[i].Text = ejemplo && i == 10 ? "Penicilina" : "";
            }
            txtOtros.Clear();
            lblUltimaAnamnesis.Text = ejemplo ? "Última actualización: 05/11/2026 · Dr. M. Quispe" : "Sin registrar";
        }

        /// <summary>Lo marcado SÍ en la anamnesis se muestra como alerta roja arriba de la ficha.</summary>
        private void ActualizarAlertas()
        {
            if (cargando) return;
            var lista = new List<string>();
            for (int i = 0; i < respuestasSi.Count; i++)
            {
                bool si = respuestasSi[i].Checked;
                detalles[i].Enabled = si;
                filasAnamnesis[i].BackColor = si ? Tema.Bad50 : Color.White;
                if (!si) continue;

                string det = detalles[i].Text.Trim();
                if (i == 10) lista.Add("alergia a " + (det == "" ? "medicamento" : det.ToLowerInvariant()));
                else if (i == 11) lista.Add("toma " + (det == "" ? "medicamento" : det.ToLowerInvariant()));
                else lista.Add(DatosDemo.Anamnesis[i].ToLowerInvariant() + (det == "" ? "" : " (" + det + ")"));
            }
            if (txtOtros.Text.Trim() != "") lista.Add(txtOtros.Text.Trim());

            pnlAlertas.Visible = lista.Count > 0;
            lblAlertas.Text = string.Join(" · ", lista);
        }

        private void btnGuardarAnamnesis_Click(object sender, EventArgs e)
        {
            // TODO (pendiente BD): guardar respuestas en PacienteAntecedente.
            lblUltimaAnamnesis.Text = "Última actualización: " + DateTime.Now.ToString("dd/MM/yyyy") + " · " + "usuario actual";
            Tema.Aviso(this, "Anamnesis guardada");
        }

        // ========================================================== Odontograma

        private static readonly string[] EstadosPieza = { "sano", "caries", "restaurado", "endodoncia", "corona", "implante", "brackets", "extraccion", "ausente" };
        private static readonly string[] NombresEstado = { "Sano", "Caries", "Restaurado", "Endodoncia", "Corona", "Implante", "Bracket", "Extracción indicada", "Ausente" };
        private static readonly Color[] ColoresEstado =
        {
            Color.White, Color.FromArgb(207, 64, 64), Color.FromArgb(53, 103, 196), Color.FromArgb(122, 79, 181),
            Color.FromArgb(184, 134, 11), Color.FromArgb(78, 100, 112), Color.FromArgb(15, 124, 128), Color.White, Color.FromArgb(238, 242, 244)
        };

        private readonly Dictionary<string, Dictionary<int, string>> odontograma = new Dictionary<string, Dictionary<int, string>>
        {
            { "inicial", new Dictionary<int, string>() },
            { "final", new Dictionary<int, string>() }
        };
        private string odontogramaActual = "inicial";
        private string estadoElegido = "caries";
        private readonly Dictionary<int, Rectangle> zonasDientes = new Dictionary<int, Rectangle>();
        private readonly List<Guna2Button> botonesPaleta = new List<Guna2Button>();

        private void PrepararOdontograma()
        {
            for (int i = 0; i < EstadosPieza.Length; i++)
            {
                var b = new Guna2Button
                {
                    Text = NombresEstado[i],
                    Tag = EstadosPieza[i],
                    Height = 26,
                    Width = TextRenderer.MeasureText(NombresEstado[i], Tema.FuenteEtiqueta).Width + 26,
                    BorderRadius = 13,
                    BorderThickness = 1,
                    BorderColor = Tema.LineaFuerte,
                    FillColor = Color.White,
                    ForeColor = Tema.Texto,
                    Font = Tema.FuenteChica,
                    Image = Muestra(ColoresEstado[i], EstadosPieza[i]),
                    ImageSize = new Size(12, 12),
                    ImageAlign = HorizontalAlignment.Left,
                    TextAlign = HorizontalAlignment.Left,
                    Margin = new Padding(0, 0, 3, 0),
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
                };
                b.HoverState.FillColor = Tema.Hover;
                b.Click += (s, e) => { estadoElegido = (string)((Control)s).Tag; MarcarPaleta(); };
                flpPaleta.Controls.Add(b);
                botonesPaleta.Add(b);

                var ley = new Label
                {
                    Text = "     " + NombresEstado[i],
                    Image = Muestra(ColoresEstado[i], EstadosPieza[i]),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                    Padding = new Padding(0, 2, 0, 2),
                    Margin = new Padding(0, 0, 10, 0),
                    ForeColor = Tema.Suave,
                    Font = Tema.FuenteChica
                };
                flpLeyenda.Controls.Add(ley);
            }
            MarcarPaleta();

            pnlDientes.Paint += pnlDientes_Paint;
            pnlDientes.MouseClick += pnlDientes_MouseClick;
            pnlDientes.MouseMove += (s, e) =>
            {
                bool sobre = false;
                foreach (var z in zonasDientes.Values) if (z.Contains(e.Location)) { sobre = true; break; }
                pnlDientes.Cursor = sobre ? Cursors.Hand : Cursors.Default;
            };
            pnlDientes.Resize += (s, e) => pnlDientes.Invalidate();
            typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(pnlDientes, true, null);
        }

        private static Image Muestra(Color color, string estado)
        {
            var bmp = new Bitmap(12, 12);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var b = new SolidBrush(color)) g.FillRectangle(b, 0, 0, 11, 11);
                using (var p = new Pen(estado == "extraccion" ? Color.FromArgb(207, 64, 64) : Color.FromArgb(64, 0, 0, 0))) g.DrawRectangle(p, 0, 0, 11, 11);
            }
            return bmp;
        }

        private void MarcarPaleta()
        {
            foreach (var b in botonesPaleta)
            {
                bool activo = (string)b.Tag == estadoElegido;
                b.BorderColor = activo ? Tema.Marca : Tema.LineaFuerte;
                b.BorderThickness = activo ? 2 : 1;
                b.Font = activo ? Tema.FuenteEtiqueta : Tema.FuenteChica;
            }
        }

        private void btnOdoTipo_Click(object sender, EventArgs e)
        {
            MostrarTipoOdontograma(sender == btnOdoInicial ? "inicial" : "final");
        }

        private void MostrarTipoOdontograma(string tipo)
        {
            odontogramaActual = tipo;
            EstiloSegmento(btnOdoInicial, tipo == "inicial");
            EstiloSegmento(btnOdoFinal, tipo == "final");
            lblOdoInfo.Text = tipo == "inicial"
                ? (odontograma["inicial"].Count > 0 ? "Inicial · 05/11/2026 · Dr. M. Quispe" : "Inicial · sin registrar")
                : "Final · se completa al terminar el tratamiento";
            pnlDientes.Invalidate();
        }

        private static void EstiloSegmento(Guna2Button b, bool activo)
        {
            b.FillColor = activo ? Tema.Marca : Color.White;
            b.ForeColor = activo ? Color.White : Tema.Texto;
            b.BorderThickness = activo ? 0 : 1;
            b.HoverState.FillColor = activo ? Tema.Marca600 : Tema.Hover;
            b.Font = new Font("Segoe UI", 9F, activo ? FontStyle.Bold : FontStyle.Regular);
        }

        private static int[] Rango(int desde, int hasta)
        {
            var r = new List<int>();
            if (desde > hasta) for (int i = desde; i >= hasta; i--) r.Add(i);
            else for (int i = desde; i <= hasta; i++) r.Add(i);
            return r.ToArray();
        }

        /// <summary>Dibuja el odontograma con numeración FDI: 32 piezas permanentes y 20 temporales.</summary>
        private void pnlDientes_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            zonasDientes.Clear();

            var filas = new[]
            {
                new { Titulo = "Permanentes superiores", Izq = Rango(18, 11), Der = Rango(21, 28), Temporal = false, Arriba = true },
                new { Titulo = "Temporales superiores", Izq = Rango(55, 51), Der = Rango(61, 65), Temporal = true, Arriba = true },
                new { Titulo = "Temporales inferiores", Izq = Rango(85, 81), Der = Rango(71, 75), Temporal = true, Arriba = false },
                new { Titulo = "Permanentes inferiores", Izq = Rango(48, 41), Der = Rango(31, 38), Temporal = false, Arriba = false },
            };

            const int paso = 31, separacion = 14;
            int centro = pnlDientes.ClientSize.Width / 2;
            int y = 6;
            var fuenteNum = new Font("Segoe UI", 7.5F);

            for (int f = 0; f < filas.Length; f++)
            {
                var fila = filas[f];
                if (f == 2)
                {
                    using (var pen = new Pen(Tema.LineaFuerte)) g.DrawLine(pen, 40, y + 4, pnlDientes.ClientSize.Width - 40, y + 4);
                    y += 14;
                }
                if (fila.Arriba)
                {
                    TextRenderer.DrawText(g, fila.Titulo, Tema.FuenteChica, new Rectangle(0, y, pnlDientes.ClientSize.Width, 14), Tema.Suave, TextFormatFlags.HorizontalCenter);
                    y += 16;
                }

                int ancho = fila.Izq.Length * paso;
                int xIzq = centro - separacion / 2 - ancho;
                int xDer = centro + separacion / 2;
                int altoCaja = fila.Temporal ? 28 : 34, anchoCaja = fila.Temporal ? 24 : 28;

                for (int lado = 0; lado < 2; lado++)
                {
                    int[] piezas = lado == 0 ? fila.Izq : fila.Der;
                    int x0 = lado == 0 ? xIzq : xDer;
                    for (int i = 0; i < piezas.Length; i++)
                    {
                        int n = piezas[i];
                        int x = x0 + i * paso + (paso - anchoCaja) / 2;
                        int yNum = fila.Arriba ? y : y + altoCaja + 2;
                        int yCaja = fila.Arriba ? y + 14 : y;
                        TextRenderer.DrawText(g, n.ToString(), fuenteNum, new Rectangle(x0 + i * paso, yNum, paso, 13), Tema.Suave, TextFormatFlags.HorizontalCenter);
                        var caja = new Rectangle(x, yCaja, anchoCaja, altoCaja);
                        DibujarPieza(g, caja, EstadoPieza(n));
                        zonasDientes[n] = Rectangle.Inflate(caja, 2, 8);
                    }
                }
                y += fila.Arriba ? altoCaja + 22 : altoCaja + 16;
                if (!fila.Arriba)
                {
                    TextRenderer.DrawText(g, fila.Titulo, Tema.FuenteChica, new Rectangle(0, y, pnlDientes.ClientSize.Width, 14), Tema.Suave, TextFormatFlags.HorizontalCenter);
                    y += 18;
                }
            }
            fuenteNum.Dispose();
        }

        private string EstadoPieza(int n)
        {
            string est;
            return odontograma[odontogramaActual].TryGetValue(n, out est) ? est : "sano";
        }

        private static void DibujarPieza(Graphics g, Rectangle r, string estado)
        {
            int i = Array.IndexOf(EstadosPieza, estado);
            Color relleno = ColoresEstado[Math.Max(0, i)];
            Color borde = estado == "sano" || estado == "ausente" ? Color.FromArgb(154, 170, 178)
                        : estado == "extraccion" ? Color.FromArgb(207, 64, 64) : relleno;

            using (var path = Tema.Redondeado(r, 6))
            using (var b = new SolidBrush(relleno))
            using (var p = new Pen(borde, 1.5f))
            {
                if (estado == "ausente") p.DashStyle = DashStyle.Dash;
                g.FillPath(b, path);
                g.DrawPath(p, path);
            }
            if (estado == "ausente" || estado == "extraccion")
            {
                Color colorX = estado == "extraccion" ? Color.FromArgb(207, 64, 64) : Color.FromArgb(132, 148, 160);
                using (var p = new Pen(colorX, 1.6f))
                {
                    int m = 7;
                    g.DrawLine(p, r.Left + m, r.Top + m + 2, r.Right - m, r.Bottom - m - 2);
                    g.DrawLine(p, r.Right - m, r.Top + m + 2, r.Left + m, r.Bottom - m - 2);
                }
            }
        }

        private void pnlDientes_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var z in zonasDientes)
            {
                if (!z.Value.Contains(e.Location)) continue;
                if (estadoElegido == "sano") odontograma[odontogramaActual].Remove(z.Key);
                else odontograma[odontogramaActual][z.Key] = estadoElegido;
                pnlDientes.Invalidate();
                return;
            }
        }

        private void btnCopiarInicial_Click(object sender, EventArgs e)
        {
            odontograma["final"] = new Dictionary<int, string>(odontograma["inicial"]);
            if (odontogramaActual == "final") pnlDientes.Invalidate();
            Tema.Aviso(this, "Se copió el odontograma inicial al final");
        }

        private void btnGuardarOdo_Click(object sender, EventArgs e)
        {
            // TODO (pendiente BD): guardar en Odontograma / OdontogramaPieza.
            Tema.Aviso(this, "Odontograma " + odontogramaActual + " guardado");
        }

        private void btnImprimirOdo_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap(pnlDientes.Width, pnlDientes.Height);
            pnlDientes.DrawToBitmap(bmp, new Rectangle(Point.Empty, pnlDientes.Size));
            string paciente = txtNombres.Text + " " + txtApellidos.Text;
            Tema.VistaImpresion("Odontograma " + odontogramaActual, (s, ev) =>
            {
                var g = ev.Graphics;
                int x = ev.MarginBounds.Left, y = ev.MarginBounds.Top;
                using (var titulo = new Font("Segoe UI", 14F, FontStyle.Bold)) g.DrawString("DentoTacna — Odontograma " + odontogramaActual, titulo, Brushes.Black, x, y);
                g.DrawString("Paciente: " + paciente + "   ·   " + txtHistoria.Text + "   ·   Fecha: " + dtpOdoFecha.Value.ToString("dd/MM/yyyy"), Tema.Fuente, Brushes.Black, x, y + 34);
                float escala = Math.Min(1f, (float)ev.MarginBounds.Width / bmp.Width);
                g.DrawImage(bmp, x, y + 64, bmp.Width * escala, bmp.Height * escala);
                g.DrawString("Observaciones: " + txtOdoObs.Text, Tema.Fuente, Brushes.Black,
                    new RectangleF(x, y + 80 + bmp.Height * escala, ev.MarginBounds.Width, 60));
            });
            bmp.Dispose();
        }

        // ======================================================= Consentimiento

        private void MostrarEstadoConsentimiento()
        {
            bool firmado = chkConsFirmado.Checked;
            tagConsEstado.Text = firmado ? "Firmado" : "Pendiente de firma";
            tagConsEstado.Width = firmado ? 80 : 130;
            tagConsEstado.FillColor = firmado ? Tema.Ok50 : Tema.Warn50;
            tagConsEstado.HoverState.FillColor = tagConsEstado.FillColor;
            tagConsEstado.ForeColor = firmado ? Tema.Ok : Tema.Warn;
        }

        private void btnGuardarCons_Click(object sender, EventArgs e)
        {
            if (cboConsOdontologo.SelectedIndex < 0 || txtConsDiagnostico.Text.Trim() == "" || txtConsProcedimiento.Text.Trim() == "")
            {
                MessageBox.Show("Complete los campos obligatorios (*).", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO (pendiente BD): guardar en la tabla Consentimiento.
            Tema.Aviso(this, "Consentimiento guardado");
        }

        private void btnImprimirCons_Click(object sender, EventArgs e)
        {
            Tema.VistaImpresion("Consentimiento informado", (s, ev) =>
            {
                var g = ev.Graphics;
                var area = ev.MarginBounds;
                float y = area.Top;
                using (var titulo = new Font("Segoe UI", 14F, FontStyle.Bold))
                using (var negrita = new Font("Segoe UI", 10F, FontStyle.Bold))
                using (var normal = new Font("Segoe UI", 10F))
                {
                    Action<string, Font, float> linea = (texto, fuente, extra) =>
                    {
                        var tam = g.MeasureString(texto, fuente, area.Width);
                        g.DrawString(texto, fuente, Brushes.Black, new RectangleF(area.Left, y, area.Width, tam.Height));
                        y += tam.Height + extra;
                    };
                    linea("CONSENTIMIENTO INFORMADO PARA TRATAMIENTO ODONTOLÓGICO", titulo, 4);
                    linea("Clínica DentoTacna — Implantología y Ortodoncia · Tacna", normal, 16);
                    linea("Paciente: " + txtConsPaciente.Text, normal, 4);
                    linea("Odontólogo tratante: " + cboConsOdontologo.Text, normal, 12);
                    linea("Diagnóstico", negrita, 0); linea(txtConsDiagnostico.Text, normal, 8);
                    linea("Tratamiento o procedimiento propuesto", negrita, 0); linea(txtConsProcedimiento.Text, normal, 8);
                    linea("Riesgos, ventajas y beneficios", negrita, 0); linea(txtConsRiesgos.Text, normal, 8);
                    linea("Tratamientos alternativos", negrita, 0); linea(txtConsAlternativas.Text, normal, 8);
                    linea("Consecuencias del no tratamiento", negrita, 0); linea(txtConsConsecuencias.Text, normal, 12);
                    linea("Declaraciones del paciente", negrita, 2);
                    foreach (var chk in new[] { chkDeclExplicacion, chkDeclFotos, chkDeclPresupuesto })
                        linea((chk.Checked ? "[X] " : "[  ] ") + chk.Text, normal, 2);
                    y += 50;
                    linea(txtConsLugar.Text, normal, 50);
                    g.DrawLine(Pens.Black, area.Left, y, area.Left + 220, y);
                    g.DrawLine(Pens.Black, area.Right - 220, y, area.Right, y);
                    y += 4;
                    g.DrawString("Firma del paciente o responsable legal", normal, Brushes.Black, area.Left, y);
                    g.DrawString("Firma y sello del odontólogo", normal, Brushes.Black, area.Right - 220, y);
                }
            });
        }

        // ================================================== Plan de tratamiento

        private class ItemPlan
        {
            public string Fecha, Doctor, Tratamiento;
            public decimal Total, Cuenta;
            public bool Firma;
        }

        private readonly List<ItemPlan> plan = new List<ItemPlan>();

        private void PrepararPlan()
        {
            Tema.PintarEtiquetas(dgvPlan, "colPlanFirma");
            dgvPlan.CellPainting += PintarBotonAbonar;
            dgvPlan.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == colPlanSaldo.Index && Convert.ToString(e.Value) == "Pagado")
                {
                    e.CellStyle.ForeColor = Tema.Ok;
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            };
            cboPlTratamiento.SelectedIndexChanged += (s, e) =>
            {
                if (cboPlTratamiento.SelectedIndex < 0) return;
                txtPlTotal.Text = ((decimal)DatosDemo.Tratamientos[cboPlTratamiento.SelectedIndex][3]).ToString("0.00");
                CalcularSaldoPlan();
            };
            txtPlTotal.TextChanged += (s, e) => CalcularSaldoPlan();
            txtPlCuenta.TextChanged += (s, e) => CalcularSaldoPlan();
            cboPlDoctor.SelectedIndex = 0;
            cboPlTratamiento.SelectedIndex = 1;
            dtpPlFecha.Value = DatosDemo.Hoy;
        }

        private void CargarPlanEjemplo()
        {
            plan.Add(new ItemPlan { Fecha = "12/09/2026", Doctor = "Dr. M. Quispe", Tratamiento = "Endodoncia molar — pieza 36", Total = 450, Cuenta = 450, Firma = true });
            plan.Add(new ItemPlan { Fecha = "05/11/2026", Doctor = "Dr. M. Quispe", Tratamiento = "Radiografía periapical — pieza 14", Total = 35, Cuenta = 0, Firma = true });
            plan.Add(new ItemPlan { Fecha = "22/11/2026", Doctor = "Dr. M. Quispe", Tratamiento = "Resina compuesta — pieza 14", Total = 180, Cuenta = 0, Firma = true });
            plan.Add(new ItemPlan { Fecha = "—", Doctor = "Dr. M. Quispe", Tratamiento = "Corona de porcelana — pieza 36", Total = 950, Cuenta = 0, Firma = false });
        }

        private void DibujarPlan()
        {
            dgvPlan.Rows.Clear();
            decimal total = 0, cuenta = 0;
            foreach (var p in plan)
            {
                decimal saldo = p.Total - p.Cuenta;
                total += p.Total;
                cuenta += p.Cuenta;
                dgvPlan.Rows.Add(p.Fecha, p.Doctor, p.Tratamiento, Tema.Dinero(p.Total), Tema.Dinero(p.Cuenta),
                    saldo > 0 ? Tema.Dinero(saldo) : "Pagado", p.Firma ? "Sí" : "No", saldo > 0 ? "Abonar" : "");
            }
            dgvPlan.ClearSelection();
            lblTotalPlan.Text = "Total: " + Tema.Dinero(total);
            lblCuentaPlan.Text = "A cuenta: " + Tema.Dinero(cuenta);
            lblSaldoPlan.Text = "Saldo: " + Tema.Dinero(total - cuenta);
            lblSaldoPlan.Left = pnlTotalesPlan.Width - lblSaldoPlan.Width - 14;
            lblCuentaPlan.Left = lblSaldoPlan.Left - lblCuentaPlan.Width - 20;
            lblTotalPlan.Left = lblCuentaPlan.Left - lblTotalPlan.Width - 20;
        }

        private void PintarBotonAbonar(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colPlanAbonar.Index) return;
            e.PaintBackground(e.CellBounds, true);
            if (Convert.ToString(e.Value) != "")
            {
                var r = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + 6, e.CellBounds.Width - 8, e.CellBounds.Height - 12);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var p = Tema.Redondeado(r, 5))
                using (var borde = new Pen(Tema.LineaFuerte))
                {
                    e.Graphics.FillPath(Brushes.White, p);
                    e.Graphics.DrawPath(borde, p);
                }
                TextRenderer.DrawText(e.Graphics, "Abonar", Tema.FuenteChica, r, Tema.Texto, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            e.Handled = true;
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colPlanAbonar.Index || e.RowIndex >= plan.Count) return;
            ItemPlan item = plan[e.RowIndex];
            decimal saldo = item.Total - item.Cuenta;
            if (saldo <= 0) return;

            decimal? monto = Tema.PedirMonto(this, "Monto a cuenta para \"" + item.Tratamiento + "\" (saldo " + Tema.Dinero(saldo) + "):", saldo);
            if (monto == null) return;
            item.Cuenta = Math.Min(item.Total, item.Cuenta + monto.Value);
            DibujarPlan();
            Tema.Aviso(this, "Pago a cuenta registrado: " + Tema.Dinero(monto.Value));
        }

        private void CalcularSaldoPlan()
        {
            txtPlSaldo.Text = (Tema.Numero(txtPlTotal.Text) - Tema.Numero(txtPlCuenta.Text)).ToString("0.00");
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            decimal total = Tema.Numero(txtPlTotal.Text);
            if (total <= 0 || cboPlTratamiento.SelectedIndex < 0 || cboPlDoctor.SelectedIndex < 0)
            {
                Tema.Aviso(this, "Ingresa el doctor, el tratamiento y el total");
                return;
            }
            string pieza = txtPlPieza.Text.Trim();
            plan.Add(new ItemPlan
            {
                Fecha = dtpPlFecha.Value.ToString("dd/MM/yyyy"),
                Doctor = Convert.ToString(cboPlDoctor.SelectedItem),
                Tratamiento = cboPlTratamiento.Text + (pieza == "" ? "" : " — pieza " + pieza),
                Total = total,
                Cuenta = Math.Min(Tema.Numero(txtPlCuenta.Text), total),
                Firma = chkPlFirma.Checked
            });
            DibujarPlan();
            txtPlPieza.Clear();
            txtPlCuenta.Text = "0.00";
            chkPlFirma.Checked = false;
            Tema.Aviso(this, "Tratamiento agregado al plan");
        }

        // ============================================================ Evolución

        private void CargarEvolucion()
        {
            dgvHistoria.Rows.Clear();
        }

        private void btnAgregarAtencion_Click(object sender, EventArgs e)
        {
            if (txtMotivo.Text.Trim() == "" || txtDiagnostico.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el motivo y el diagnóstico.", "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO (pendiente BD): guardar en la tabla Atencion con el odontólogo del usuario actual.
            dgvHistoria.Rows.Insert(0, DateTime.Now.ToString("dd/MM/yyyy"), "Dr. M. Quispe", txtMotivo.Text.Trim(),
                txtDiagnostico.Text.Trim(), txtProcedimiento.Text.Trim());
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtProcedimiento.Clear();
            Tema.Aviso(this, "Atención agregada");
        }

        // ============================================================= Imágenes

        private void CargarImagenes(bool ejemplo = false)
        {
            flpImagenes.Controls.Clear();
            if (ejemplo)
            {
                flpImagenes.Controls.Add(Miniatura("Periapical pieza 14", "05/11/2026", "Radiografía", null, false));
                flpImagenes.Controls.Add(Miniatura("Periapical pieza 36", "12/09/2026", "Radiografía", null, false));
                flpImagenes.Controls.Add(Miniatura("Foto intraoral inicial", "05/11/2026", "Foto", null, true));
            }
            var agregar = Miniatura("Agregar imagen", "JPG, PNG o PDF", "+", null, false);
            agregar.Name = "pnlAgregarImagen";
            ((Guna2GradientPanel)agregar.Controls[0]).FillColor = Tema.Superficie2;
            ((Guna2GradientPanel)agregar.Controls[0]).FillColor2 = Tema.Superficie2;
            agregar.Controls[0].Controls[0].ForeColor = Tema.Suave;
            agregar.Controls[0].Controls[0].Font = new Font("Segoe UI", 20F);
            foreach (Control c in Descendientes(agregar)) { c.Cursor = Cursors.Hand; c.Click += AgregarImagen_Click; }
            agregar.Cursor = Cursors.Hand;
            agregar.Click += AgregarImagen_Click;
            flpImagenes.Controls.Add(agregar);
        }

        private static IEnumerable<Control> Descendientes(Control c)
        {
            foreach (Control h in c.Controls)
            {
                yield return h;
                foreach (Control n in Descendientes(h)) yield return n;
            }
        }

        private Guna2Panel Miniatura(string titulo, string subtitulo, string tipo, Image imagen, bool foto)
        {
            var tarjeta = new Guna2Panel
            {
                Size = new Size(176, 156),
                BorderRadius = 8,
                BorderThickness = 1,
                BorderColor = Tema.Linea,
                FillColor = Color.White,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 0, 12, 12),
                Padding = new Padding(1)
            };
            var vista = new Guna2GradientPanel
            {
                Location = new Point(1, 1),
                Size = new Size(174, 100),
                FillColor = foto ? Color.FromArgb(201, 166, 142) : Color.FromArgb(47, 59, 64),
                FillColor2 = foto ? Color.FromArgb(232, 211, 194) : Color.FromArgb(86, 101, 108),
                GradientMode = LinearGradientMode.ForwardDiagonal,
                BorderRadius = 7,
                CustomizableEdges = { BottomLeft = false, BottomRight = false }
            };
            var etiqueta = new Label
            {
                Dock = DockStyle.Fill,
                Text = tipo,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = foto ? Color.FromArgb(107, 79, 61) : Color.FromArgb(201, 213, 218),
                BackColor = Color.Transparent,
                Font = Tema.FuenteChica
            };
            if (imagen != null)
            {
                var pic = new PictureBox { Dock = DockStyle.Fill, Image = imagen, SizeMode = PictureBoxSizeMode.Zoom, BackColor = Color.Transparent };
                vista.Controls.Add(pic);
            }
            else
            {
                vista.Controls.Add(etiqueta);
            }
            var lblT = new Label { Text = titulo, Location = new Point(9, 108), Size = new Size(160, 18), Font = Tema.FuenteNegrita, ForeColor = Tema.Texto, BackColor = Color.Transparent, AutoEllipsis = true };
            var lblS = new Label { Text = subtitulo, Location = new Point(9, 128), Size = new Size(160, 16), Font = Tema.FuenteChica, ForeColor = Tema.Suave, BackColor = Color.Transparent };
            tarjeta.Controls.Add(vista);
            tarjeta.Controls.Add(lblT);
            tarjeta.Controls.Add(lblS);
            return tarjeta;
        }

        private void AgregarImagen_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Imágenes y PDF|*.jpg;*.jpeg;*.png;*.pdf", Title = "Agregar imagen a la ficha" })
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                string ext = Path.GetExtension(dlg.FileName).ToLowerInvariant();
                Image img = null;
                if (ext != ".pdf")
                {
                    using (var original = Image.FromFile(dlg.FileName)) img = new Bitmap(original);
                }
                // TODO (pendiente BD): copiar el archivo a la carpeta de la clínica y registrarlo en PacienteImagen.
                var mini = Miniatura(Path.GetFileNameWithoutExtension(dlg.FileName), DateTime.Now.ToString("dd/MM/yyyy"),
                                     ext == ".pdf" ? "PDF" : "Imagen", img, false);
                flpImagenes.Controls.Add(mini);
                flpImagenes.Controls.SetChildIndex(mini, flpImagenes.Controls.Count - 2);
                Tema.Aviso(this, "Imagen agregada a la ficha");
            }
        }
    }
}
