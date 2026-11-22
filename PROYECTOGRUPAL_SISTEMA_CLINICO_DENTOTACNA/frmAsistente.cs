using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmAsistente : Form
    {
        private class Mensaje
        {
            public bool EsBot;
            public string Texto;
            public string[][] Tabla;
            public string Hora;
        }

        private readonly List<Mensaje> conversacion = new List<Mensaje>();
        private string nombreUsuario = "Rosa";
        private string inicialesUsuario = "RT";
        private int anchoAnterior;

        public frmAsistente()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            txtMensaje.BorderThickness = 0;
            txtMensaje.KeyDown += txtMensaje_KeyDown;
            flpChat.SizeChanged += (s, e) =>
            {
                if (Math.Abs(flpChat.ClientSize.Width - anchoAnterior) > 4) RedibujarConversacion();
            };
            ConversacionInicial();
        }

        public frmAsistente(string nombre, string iniciales) : this()
        {
            nombreUsuario = PrimerNombre(nombre);
            inicialesUsuario = iniciales;
            ConversacionInicial();
        }

        private static string PrimerNombre(string nombre)
        {
            string limpio = nombre.Replace("Dra. ", "").Replace("Dr. ", "").Trim();
            int i = limpio.IndexOf(' ');
            return i > 0 ? limpio.Substring(0, i) : limpio;
        }

        private void ConversacionInicial()
        {
            conversacion.Clear();
            Agregar(true, "Hola, " + nombreUsuario + ". Puedo consultar la agenda, los pacientes y los pagos. Escribe tu pregunta o usa una palabra clave.", null, "08:02");
            Agregar(false, "citas mañana", null, "08:03");
            Responder("citas mañana", "08:03");
            Agregar(false, "saldo Castillo", null, "08:05");
            Responder("saldo Castillo", "08:05");
        }

        // ===================================================== Burbujas de chat

        private void Agregar(bool esBot, string texto, string[][] tabla, string hora = null)
        {
            conversacion.Add(new Mensaje { EsBot = esBot, Texto = texto, Tabla = tabla, Hora = hora ?? DateTime.Now.ToString("HH:mm") });
            RedibujarConversacion();
        }

        private void RedibujarConversacion()
        {
            anchoAnterior = flpChat.ClientSize.Width;
            flpChat.SuspendLayout();
            while (flpChat.Controls.Count > 0) flpChat.Controls[0].Dispose();
            Control ultima = null;
            foreach (var m in conversacion) ultima = CrearFila(m);
            flpChat.ResumeLayout();
            if (ultima != null) flpChat.ScrollControlIntoView(ultima);
        }

        private Control CrearFila(Mensaje m)
        {
            int anchoFila = Math.Max(300, flpChat.ClientSize.Width - flpChat.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth);
            int anchoMaxBurbuja = (int)(anchoFila * 0.78);

            var fila = new Panel { Width = anchoFila, BackColor = Color.White, Margin = new Padding(0, 0, 0, 14) };

            var avatar = new Guna2Panel
            {
                Size = new Size(30, 30),
                BorderRadius = 15,
                FillColor = m.EsBot ? Tema.Marca : Color.FromArgb(191, 232, 234),
                BackColor = Color.Transparent
            };
            avatar.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = m.EsBot ? "IA" : inicialesUsuario,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = m.EsBot ? Color.White : Tema.Marca600,
                BackColor = Color.Transparent
            });

            var burbuja = new Guna2Panel
            {
                BorderRadius = 14,
                FillColor = m.EsBot ? Color.FromArgb(241, 246, 247) : Tema.Marca,
                BackColor = Color.Transparent
            };
            var texto = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(anchoMaxBurbuja - 28, 0),
                Text = m.Texto,
                Font = Tema.Fuente,
                ForeColor = m.EsBot ? Tema.Texto : Color.White,
                BackColor = Color.Transparent,
                Location = new Point(14, 10)
            };
            burbuja.Controls.Add(texto);
            int ancho = texto.PreferredSize.Width, alto = texto.PreferredSize.Height;

            if (m.Tabla != null)
            {
                var tabla = CrearTabla(m.Tabla);
                tabla.Location = new Point(14, 10 + alto + 8);
                burbuja.Controls.Add(tabla);
                ancho = Math.Max(ancho, tabla.PreferredSize.Width);
                alto += 8 + tabla.PreferredSize.Height;
            }
            burbuja.Size = new Size(Math.Min(anchoMaxBurbuja, ancho + 28), alto + 20);

            var meta = new Label
            {
                AutoSize = true,
                Text = (m.EsBot ? "Asistente · " : "Tú · ") + m.Hora,
                Font = Tema.FuenteChica,
                ForeColor = Tema.Suave,
                BackColor = Color.Transparent
            };

            if (m.EsBot)
            {
                avatar.Location = new Point(0, 0);
                burbuja.Location = new Point(40, 0);
                meta.Location = new Point(44, burbuja.Bottom + 3);
            }
            else
            {
                avatar.Location = new Point(anchoFila - 30, 0);
                burbuja.Location = new Point(anchoFila - 40 - burbuja.Width, 0);
                meta.Location = new Point(burbuja.Right - meta.PreferredSize.Width - 4, burbuja.Bottom + 3);
            }
            fila.Controls.AddRange(new Control[] { avatar, burbuja, meta });
            fila.Height = meta.Bottom + 2;
            flpChat.Controls.Add(fila);
            return fila;
        }

        private static TableLayoutPanel CrearTabla(string[][] datos)
        {
            var t = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = datos[0].Length,
                RowCount = datos.Length,
                BackColor = Color.White,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Padding = new Padding(0)
            };
            for (int r = 0; r < datos.Length; r++)
            {
                for (int c = 0; c < datos[r].Length; c++)
                {
                    t.Controls.Add(new Label
                    {
                        Text = datos[r][c],
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        Padding = new Padding(6, 5, 10, 5),
                        Margin = new Padding(0),
                        Font = r == 0 ? new Font("Segoe UI", 8.25F, FontStyle.Bold) : new Font("Segoe UI", 9F),
                        ForeColor = r == 0 ? Tema.Suave : Tema.Texto,
                        BackColor = r == 0 ? Tema.Superficie2 : Color.White
                    }, c, r);
                }
            }
            return t;
        }

        // =============================================== Palabras clave (v0.1)

        /// <summary>Responde por palabras clave. Solo consulta datos; nunca modifica citas, fichas ni pagos.</summary>
        private void Responder(string pregunta, string hora = null)
        {
            // TODO (pendiente BD): consultar las vistas (vw_Citas, vw_SaldoPaciente, vw_Pagos, vw_Atenciones)
            // con el usuario de solo lectura y guardar la consulta en ConsultaAsistente.
            string k = pregunta.ToLowerInvariant();
            string respuesta;
            string[][] tabla = null;

            if (k.Contains("confirm"))
            {
                var lista = new List<string>();
                foreach (object[] c in DatosDemo.CitasHoy)
                    if ((string)c[4] == "Sin confirmar") lista.Add(c[1] + " (" + c[0] + ")");
                respuesta = "Hoy hay " + lista.Count + " pacientes sin confirmar: " + string.Join(" y ", lista) + ".";
            }
            else if (k.Contains("recordatorio"))
            {
                int n = 0;
                foreach (object[] r in DatosDemo.RecordatoriosManana) if ((string)r[4] == "Pendiente") n++;
                respuesta = "Hay " + n + " recordatorios pendientes para las citas de mañana. Puedes enviarlos desde el Panel principal con el botón \"Avisar\".";
            }
            else if (k.Contains("cobr"))
            {
                decimal total = 0;
                foreach (object[] p in DatosDemo.PagosHoy) total += (decimal)p[7];
                respuesta = "Hoy se cobraron " + Tema.Dinero(total) + " en " + DatosDemo.PagosHoy.Length + " pagos.";
            }
            else if (k.Contains("alergi"))
            {
                respuesta = "María Elena Castillo es alérgica a la penicilina y tiene hipertensión arterial.";
            }
            else if (k.Contains("visita"))
            {
                respuesta = "La última visita de María Elena Castillo (HC-00482) fue el 05/11/2026 con el Dr. M. Quispe: evaluación y radiografía de la pieza 14.";
            }
            else if (k.Contains("saldo") && (k.Contains("castillo") || k.Contains("maría") || k.Contains("maria")))
            {
                respuesta = "María Elena Castillo (HC-00482) tiene un saldo de S/ 1 165.00 en su plan de tratamiento. Hoy debe la resina de la pieza 14 (S/ 180.00) y la radiografía (S/ 35.00).";
            }
            else if (k.Contains("saldo"))
            {
                respuesta = "Estos pacientes tienen saldo pendiente (total S/ 4 315.00):";
                tabla = new[]
                {
                    new[] { "Paciente", "Historia", "Saldo" },
                    new[] { "Ricardo Gutiérrez Paz", "HC-00076", "S/ 2 000.00" },
                    new[] { "María Elena Castillo", "HC-00482", "S/ 1 165.00" },
                    new[] { "Luis Fernández Soto", "HC-00298", "S/ 1 150.00" },
                };
            }
            else if (k.Contains("mañana") || k.Contains("manana"))
            {
                var filas = new List<string[]> { new[] { "Hora", "Paciente", "Tratamiento", "Recordatorio" } };
                foreach (object[] r in DatosDemo.RecordatoriosManana)
                    if ((string)r[4] == "Pendiente") filas.Add(new[] { (string)r[0], (string)r[1], (string)r[3], (string)r[4] });
                respuesta = "Mañana, lunes 23/11, hay " + DatosDemo.RecordatoriosManana.Length + " citas. " + (filas.Count - 1) + " todavía no tienen recordatorio:";
                tabla = filas.ToArray();
            }
            else if (k.Contains("hoy"))
            {
                int atendidas = 0, consulta = 0, confirmadas = 0, sin = 0;
                foreach (object[] c in DatosDemo.CitasHoy)
                {
                    switch ((string)c[4])
                    {
                        case "Atendida": atendidas++; break;
                        case "En consulta": consulta++; break;
                        case "Confirmada": confirmadas++; break;
                        case "Sin confirmar": sin++; break;
                    }
                }
                respuesta = "Hoy hay " + DatosDemo.CitasHoy.Length + " citas: " + atendidas + " atendidas, " + consulta + " en consulta, " +
                            confirmadas + " confirmadas y " + sin + " sin confirmar.";
            }
            else
            {
                respuesta = "Prueba con una palabra clave: \"citas hoy\", \"citas mañana\", \"sin confirmar\", \"saldo\" seguido del apellido, \"cobrado hoy\" o \"alergias\" seguido del apellido.";
            }
            Agregar(true, respuesta, tabla, hora);
        }

        private void Enviar()
        {
            string pregunta = txtMensaje.Text.Trim();
            if (pregunta == "") return;
            Agregar(false, pregunta, null);
            Responder(pregunta);
            txtMensaje.Clear();
            txtMensaje.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e) { Enviar(); }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                Enviar();
            }
        }

        private void chip_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = ((Control)sender).Text.Replace("[paciente]", "").TrimEnd() + " ";
            txtMensaje.Focus();
            txtMensaje.SelectionStart = txtMensaje.Text.Length;
        }

        private void pregunta_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = ((Control)sender).Text;
            Enviar();
        }

        private void btnBorrarConversacion_Click(object sender, EventArgs e)
        {
            conversacion.Clear();
            Agregar(true, "Hola, " + nombreUsuario + ". Puedo consultar la agenda, los pacientes y los pagos. Escribe tu pregunta o usa una palabra clave.", null);
        }
    }
}
