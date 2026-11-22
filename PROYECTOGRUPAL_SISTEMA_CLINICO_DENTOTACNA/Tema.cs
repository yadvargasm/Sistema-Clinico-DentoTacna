using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    /// <summary>
    /// Colores y estilos comunes de DentoTacna v0.1 (iguales al prototipo DentoTacna_v0.1.html).
    /// Cada formulario llama a Tema.Aplicar(this) en su constructor para que todos se vean igual.
    /// </summary>
    internal static class Tema
    {
        // Marca
        public static readonly Color Marca = Color.FromArgb(15, 124, 128);
        public static readonly Color Marca600 = Color.FromArgb(11, 100, 104);
        public static readonly Color Marca50 = Color.FromArgb(232, 245, 245);
        public static readonly Color Marca100 = Color.FromArgb(207, 234, 234);
        public static readonly Color MenuArriba = Color.FromArgb(17, 133, 138);
        public static readonly Color MenuAbajo = Color.FromArgb(10, 90, 94);

        // Superficies y texto
        public static readonly Color Fondo = Color.FromArgb(238, 243, 245);
        public static readonly Color Superficie = Color.White;
        public static readonly Color Superficie2 = Color.FromArgb(247, 250, 251);
        public static readonly Color Linea = Color.FromArgb(227, 233, 236);
        public static readonly Color LineaFuerte = Color.FromArgb(202, 213, 218);
        public static readonly Color Texto = Color.FromArgb(31, 42, 48);
        public static readonly Color Suave = Color.FromArgb(107, 122, 131);
        public static readonly Color Hover = Color.FromArgb(240, 247, 247);

        // Estados
        public static readonly Color Ok = Color.FromArgb(46, 139, 87);
        public static readonly Color Ok50 = Color.FromArgb(232, 245, 238);
        public static readonly Color Warn = Color.FromArgb(194, 124, 18);
        public static readonly Color Warn50 = Color.FromArgb(253, 243, 226);
        public static readonly Color Bad = Color.FromArgb(207, 64, 64);
        public static readonly Color Bad50 = Color.FromArgb(252, 235, 235);
        public static readonly Color Info = Color.FromArgb(53, 103, 196);
        public static readonly Color Info50 = Color.FromArgb(234, 240, 251);
        public static readonly Color Purple = Color.FromArgb(122, 79, 181);
        public static readonly Color Purple50 = Color.FromArgb(241, 235, 250);
        public static readonly Color Gold = Color.FromArgb(184, 134, 11);
        public static readonly Color Plain50 = Color.FromArgb(238, 242, 244);
        public static readonly Color Implante = Color.FromArgb(78, 100, 112);

        // Fuentes
        public static readonly Font Fuente = new Font("Segoe UI", 9.75F);
        public static readonly Font FuenteNegrita = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        public static readonly Font FuenteChica = new Font("Segoe UI", 8.25F);
        public static readonly Font FuenteEtiqueta = new Font("Segoe UI", 8.25F, FontStyle.Bold);

        private static readonly CultureInfo Peru = new CultureInfo("es-PE");

        /// <summary>Recorre el formulario y aplica el estilo común a cajas de texto, combos, fechas, casillas y tablas.</summary>
        public static void Aplicar(Control raiz)
        {
            foreach (Control c in raiz.Controls)
            {
                Estilizar(c);
                if (c.HasChildren && !(c is DataGridView))
                {
                    Aplicar(c);
                }
            }
        }

        private static void Estilizar(Control c)
        {
            if (c is Guna2TextBox)
            {
                var txt = (Guna2TextBox)c;
                txt.BorderRadius = 6;
                txt.BorderColor = LineaFuerte;
                txt.FocusedState.BorderColor = Marca;
                txt.HoverState.BorderColor = Color.FromArgb(159, 199, 201);
                txt.ForeColor = Texto;
                txt.PlaceholderForeColor = Color.FromArgb(150, 162, 170);
                txt.FillColor = txt.ReadOnly ? Superficie2 : Superficie;
                txt.DisabledState.FillColor = Superficie2;
                txt.DisabledState.BorderColor = Linea;
                txt.DisabledState.ForeColor = Suave;
                if (txt.Font.Name != "Segoe UI") txt.Font = Fuente;
            }
            else if (c is Guna2ComboBox)
            {
                var cbo = (Guna2ComboBox)c;
                cbo.BackColor = Color.Transparent;
                cbo.BorderRadius = 6;
                cbo.BorderColor = LineaFuerte;
                cbo.FocusedColor = Marca;
                cbo.FocusedState.BorderColor = Marca;
                cbo.HoverState.BorderColor = Color.FromArgb(159, 199, 201);
                cbo.ForeColor = Texto;
                cbo.Font = Fuente;
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (c is Guna2DateTimePicker)
            {
                var dtp = (Guna2DateTimePicker)c;
                dtp.BorderRadius = 6;
                dtp.BorderThickness = 1;
                dtp.BorderColor = LineaFuerte;
                dtp.FillColor = Superficie;
                dtp.ForeColor = Texto;
                dtp.Font = Fuente;
                dtp.HoverState.BorderColor = Color.FromArgb(159, 199, 201);
                dtp.FocusedColor = Marca;
                dtp.CheckedState.FillColor = Superficie;
                dtp.CheckedState.BorderColor = LineaFuerte;
                dtp.CheckedState.ForeColor = Texto;
            }
            else if (c is Guna2CheckBox)
            {
                var chk = (Guna2CheckBox)c;
                chk.BackColor = Color.Transparent;
                chk.CheckedState.BorderColor = Marca;
                chk.CheckedState.FillColor = Marca;
                chk.CheckedState.BorderRadius = 3;
                chk.CheckedState.BorderThickness = 0;
                chk.UncheckedState.BorderColor = LineaFuerte;
                chk.UncheckedState.FillColor = Superficie;
                chk.UncheckedState.BorderRadius = 3;
                chk.UncheckedState.BorderThickness = 1;
                chk.ForeColor = Texto;
                chk.Cursor = Cursors.Hand;
            }
            else if (c is Guna2RadioButton)
            {
                var rb = (Guna2RadioButton)c;
                rb.BackColor = Color.Transparent;
                rb.CheckedState.BorderColor = Marca;
                rb.CheckedState.FillColor = Superficie;
                rb.CheckedState.InnerColor = Marca;
                rb.CheckedState.InnerOffset = -4;
                rb.CheckedState.BorderThickness = 2;
                rb.UncheckedState.BorderColor = LineaFuerte;
                rb.UncheckedState.FillColor = Superficie;
                rb.UncheckedState.BorderThickness = 1;
                rb.ForeColor = Texto;
                rb.Cursor = Cursors.Hand;
            }
            else if (c is Guna2DataGridView)
            {
                EstilizarGrid((Guna2DataGridView)c);
            }
        }

        /// <summary>Estilo de tabla del prototipo: encabezado gris claro, fila seleccionada verde claro.</summary>
        public static void EstilizarGrid(Guna2DataGridView g)
        {
            g.BackgroundColor = Superficie;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.GridColor = Color.FromArgb(238, 242, 244);
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.RowTemplate.Height = 34;

            g.ThemeStyle.BackColor = Superficie;
            g.ThemeStyle.GridColor = Color.FromArgb(238, 242, 244);
            g.ThemeStyle.HeaderStyle.BackColor = Superficie2;
            g.ThemeStyle.HeaderStyle.ForeColor = Suave;
            g.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            g.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ThemeStyle.HeaderStyle.Height = 36;
            g.ThemeStyle.RowsStyle.BackColor = Superficie;
            g.ThemeStyle.RowsStyle.ForeColor = Texto;
            g.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            g.ThemeStyle.RowsStyle.SelectionBackColor = Marca50;
            g.ThemeStyle.RowsStyle.SelectionForeColor = Texto;
            g.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ThemeStyle.RowsStyle.Height = 34;
            g.ThemeStyle.AlternatingRowsStyle.BackColor = Superficie;
            g.ThemeStyle.AlternatingRowsStyle.ForeColor = Texto;
            g.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Marca50;
            g.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Texto;

            g.ColumnHeadersDefaultCellStyle.BackColor = Superficie2;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Suave;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Superficie2;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Suave;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.DefaultCellStyle.BackColor = Superficie;
            g.DefaultCellStyle.ForeColor = Texto;
            g.DefaultCellStyle.SelectionBackColor = Marca50;
            g.DefaultCellStyle.SelectionForeColor = Texto;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = Superficie;
            g.AlternatingRowsDefaultCellStyle.SelectionBackColor = Marca50;
            g.AlternatingRowsDefaultCellStyle.SelectionForeColor = Texto;

            // Borde izquierdo verde en la fila seleccionada, como en el prototipo.
            g.RowPostPaint -= MarcarFilaSeleccionada;
            g.RowPostPaint += MarcarFilaSeleccionada;
        }

        private static void MarcarFilaSeleccionada(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.RowIndex >= 0 && g.Rows[e.RowIndex].Selected)
            {
                using (var b = new SolidBrush(Marca))
                {
                    e.Graphics.FillRectangle(b, e.RowBounds.Left, e.RowBounds.Top, 3, e.RowBounds.Height - 1);
                }
            }
        }

        /// <summary>Devuelve el color de texto y de fondo de una etiqueta según su texto (Atendida, Pendiente, etc.).</summary>
        public static void ColorEtiqueta(string texto, out Color fg, out Color bg)
        {
            switch ((texto ?? "").Trim().ToLowerInvariant())
            {
                case "atendida":
                case "confirmada":
                case "programada":
                case "enviado":
                case "firmado":
                case "activo":
                case "total":
                case "sí":
                case "pagado":
                    fg = Ok; bg = Ok50; break;
                case "sin confirmar":
                case "pendiente":
                case "pendiente de firma":
                    fg = Warn; bg = Warn50; break;
                case "en consulta":
                case "ortodoncia":
                case "a cuenta":
                    fg = Info; bg = Info50; break;
                case "implantes":
                    fg = Purple; bg = Purple50; break;
                case "cancelada":
                case "inactivo":
                    fg = Bad; bg = Bad50; break;
                default:
                    fg = Suave; bg = Plain50; break;
            }
        }

        /// <summary>Dibuja como etiqueta de color (píldora) el texto de las columnas indicadas.</summary>
        public static void PintarEtiquetas(DataGridView g, params string[] columnas)
        {
            g.CellPainting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (Array.IndexOf(columnas, g.Columns[e.ColumnIndex].Name) < 0) return;
                string texto = Convert.ToString(e.FormattedValue);
                if (string.IsNullOrEmpty(texto)) return;

                e.PaintBackground(e.CellBounds, true);
                Color fg, bg;
                ColorEtiqueta(texto, out fg, out bg);
                DibujarEtiqueta(e.Graphics, texto, e.CellBounds.X + 8, e.CellBounds.Y + (e.CellBounds.Height - 22) / 2, fg, bg);
                e.Handled = true;
            };
        }

        /// <summary>Dibuja una etiqueta redondeada con punto de color. Devuelve el ancho dibujado.</summary>
        public static int DibujarEtiqueta(Graphics gr, string texto, int x, int y, Color fg, Color bg)
        {
            Size ts = TextRenderer.MeasureText(gr, texto, FuenteEtiqueta, Size.Empty, TextFormatFlags.NoPadding);
            var r = new Rectangle(x, y, ts.Width + 26, 22);
            var modo = gr.SmoothingMode;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            using (var p = Redondeado(r, 11))
            using (var b = new SolidBrush(bg))
            {
                gr.FillPath(b, p);
            }
            using (var b = new SolidBrush(fg))
            {
                gr.FillEllipse(b, r.X + 9, r.Y + 8, 6, 6);
            }
            gr.SmoothingMode = modo;
            TextRenderer.DrawText(gr, texto, FuenteEtiqueta, new Rectangle(r.X + 19, r.Y, r.Width - 19, r.Height), fg,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
            return r.Width;
        }

        /// <summary>Devuelve una copia del ícono pintada de un solo color (respeta la transparencia).</summary>
        public static Image ColorearIcono(Image original, Color color)
        {
            if (original == null) return null;
            var bmp = new Bitmap(original.Width, original.Height);
            var matriz = new System.Drawing.Imaging.ColorMatrix(new float[][]
            {
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { color.R / 255f, color.G / 255f, color.B / 255f, 0, 1 }
            });
            using (var atributos = new System.Drawing.Imaging.ImageAttributes())
            using (var g = Graphics.FromImage(bmp))
            {
                atributos.SetColorMatrix(matriz);
                g.DrawImage(original, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, atributos);
            }
            return bmp;
        }

        public static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        /// <summary>Formato de dinero del prototipo: S/ 2 860.00</summary>
        public static string Dinero(decimal monto)
        {
            return "S/ " + monto.ToString("#,0.00", CultureInfo.InvariantCulture).Replace(",", " ");
        }

        /// <summary>Convierte el texto de una caja a número (acepta coma o punto). Devuelve 0 si no es válido.</summary>
        public static decimal Numero(string texto)
        {
            decimal v;
            return decimal.TryParse((texto ?? "").Replace(",", ".").Replace("S/", "").Trim(),
                NumberStyles.Number, CultureInfo.InvariantCulture, out v) ? v : 0m;
        }

        public static string FechaLarga(DateTime f)
        {
            string s = f.ToString("dddd, d 'de' MMMM 'de' yyyy", Peru);
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        /// <summary>Pequeño diálogo para pedir un monto. Devuelve null si se cancela o el valor no es válido.</summary>
        public static decimal? PedirMonto(IWin32Window dueño, string mensaje, decimal valorInicial)
        {
            using (var dlg = new Form())
            {
                dlg.Text = "DentoTacna";
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.MinimizeBox = false;
                dlg.MaximizeBox = false;
                dlg.ShowInTaskbar = false;
                dlg.BackColor = Superficie;
                dlg.Font = Fuente;
                dlg.ClientSize = new Size(380, 150);

                var lbl = new Label { Text = mensaje, Location = new Point(16, 14), Size = new Size(348, 38), ForeColor = Texto };
                var txt = new Guna2TextBox { Location = new Point(16, 56), Size = new Size(348, 36), Text = valorInicial.ToString("0.00", CultureInfo.InvariantCulture) };
                var ok = new Guna2Button { Text = "Aceptar", Location = new Point(244, 104), Size = new Size(120, 34), FillColor = Marca, ForeColor = Color.White, BorderRadius = 6, DialogResult = DialogResult.OK, Font = FuenteNegrita };
                var cancelar = new Guna2Button { Text = "Cancelar", Location = new Point(116, 104), Size = new Size(120, 34), FillColor = Superficie, ForeColor = Texto, BorderRadius = 6, BorderThickness = 1, BorderColor = LineaFuerte, DialogResult = DialogResult.Cancel, Font = Fuente };
                dlg.Controls.AddRange(new Control[] { lbl, txt, ok, cancelar });
                dlg.AcceptButton = ok;
                dlg.CancelButton = cancelar;
                Aplicar(dlg);

                if (dlg.ShowDialog(dueño) != DialogResult.OK) return null;
                decimal v = Numero(txt.Text);
                return v > 0 ? v : (decimal?)null;
            }
        }

        /// <summary>Muestra la vista previa de impresión de un dibujo (el usuario elige la impresora desde ahí).</summary>
        public static void VistaImpresion(string titulo, System.Drawing.Printing.PrintPageEventHandler dibujar)
        {
            using (var doc = new System.Drawing.Printing.PrintDocument())
            using (var vista = new PrintPreviewDialog())
            {
                doc.DocumentName = titulo;
                doc.PrintPage += dibujar;
                vista.Document = doc;
                vista.Text = titulo;
                vista.Width = 900;
                vista.Height = 700;
                vista.ShowDialog();
            }
        }

        /// <summary>
        /// Mensaje breve abajo a la derecha que desaparece solo (el "toast" del prototipo).
        /// Se muestra sobre la ventana principal aunque se llame desde un formulario hijo.
        /// </summary>
        public static void Aviso(Control origen, string mensaje)
        {
            Control ventana = origen.TopLevelControl ?? origen;
            var lbl = ventana.Controls["lblToast"] as Label;
            if (lbl == null)
            {
                lbl = new Label
                {
                    Name = "lblToast",
                    AutoSize = true,
                    BackColor = Texto,
                    ForeColor = Color.White,
                    Font = Fuente,
                    Padding = new Padding(14, 9, 14, 9),
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right
                };
                var timer = new Timer { Interval = 2400 };
                timer.Tick += (s, e) => { timer.Stop(); lbl.Visible = false; };
                lbl.Tag = timer;
                ventana.Controls.Add(lbl);
            }
            lbl.Text = mensaje;
            lbl.Location = new Point(ventana.ClientSize.Width - lbl.PreferredSize.Width - 20,
                                     ventana.ClientSize.Height - lbl.PreferredSize.Height - 40);
            lbl.Visible = true;
            lbl.BringToFront();
            var t = (Timer)lbl.Tag;
            t.Stop();
            t.Start();
        }
    }
}
