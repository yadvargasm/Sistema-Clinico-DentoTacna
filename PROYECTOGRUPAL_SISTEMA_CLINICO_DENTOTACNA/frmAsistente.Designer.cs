namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmAsistente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlConversacion = new Guna.UI2.WinForms.Guna2Panel();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.flpChips = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPalabrasClave = new System.Windows.Forms.Label();
            this.btnChip1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChip7 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEntrada = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMensaje = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPreguntas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.pnlListaPreguntas = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPregunta1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta5 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEstadoAsistente = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPuntoEstado = new System.Windows.Forms.Label();
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblNotaAsistente = new System.Windows.Forms.Label();
            this.btnBorrarConversacion = new Guna.UI2.WinForms.Guna2Button();
            this.pnlConversacion.SuspendLayout();
            this.flpChat.SuspendLayout();
            this.flpChips.SuspendLayout();
            this.pnlEntrada.SuspendLayout();
            this.pnlPreguntas.SuspendLayout();
            this.pnlListaPreguntas.SuspendLayout();
            this.pnlEstadoAsistente.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asistente IA";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblSubtitulo.Location = new System.Drawing.Point(23, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(383, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Consultas por palabras clave sobre citas, pacientes y pagos";
            //
            // pnlConversacion
            //
            this.pnlConversacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlConversacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlConversacion.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlConversacion.BorderRadius = 10;
            this.pnlConversacion.BorderThickness = 1;
            this.pnlConversacion.Controls.Add(this.flpChat);
            this.pnlConversacion.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlConversacion.Location = new System.Drawing.Point(22, 80);
            this.pnlConversacion.Name = "pnlConversacion";
            this.pnlConversacion.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlConversacion.Size = new System.Drawing.Size(788, 446);
            this.pnlConversacion.TabIndex = 2;
            //
            // flpChat
            //
            this.flpChat.AutoScroll = true;
            this.flpChat.BackColor = System.Drawing.Color.White;
            this.flpChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChat.Location = new System.Drawing.Point(1, 1);
            this.flpChat.Name = "flpChat";
            this.flpChat.Padding = new System.Windows.Forms.Padding(16, 16, 16, 8);
            this.flpChat.Size = new System.Drawing.Size(786, 444);
            this.flpChat.TabIndex = 0;
            this.flpChat.WrapContents = false;
            //
            // flpChips
            //
            this.flpChips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.flpChips.BackColor = System.Drawing.Color.Transparent;
            this.flpChips.Controls.Add(this.lblPalabrasClave);
            this.flpChips.Controls.Add(this.btnChip1);
            this.flpChips.Controls.Add(this.btnChip2);
            this.flpChips.Controls.Add(this.btnChip3);
            this.flpChips.Controls.Add(this.btnChip4);
            this.flpChips.Controls.Add(this.btnChip5);
            this.flpChips.Controls.Add(this.btnChip6);
            this.flpChips.Controls.Add(this.btnChip7);
            this.flpChips.Location = new System.Drawing.Point(22, 534);
            this.flpChips.Name = "flpChips";
            this.flpChips.Size = new System.Drawing.Size(788, 62);
            this.flpChips.TabIndex = 3;
            //
            // lblPalabrasClave
            //
            this.lblPalabrasClave.AutoSize = true;
            this.lblPalabrasClave.BackColor = System.Drawing.Color.Transparent;
            this.lblPalabrasClave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPalabrasClave.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPalabrasClave.Location = new System.Drawing.Point(0, 0);
            this.lblPalabrasClave.Name = "lblPalabrasClave";
            this.lblPalabrasClave.Size = new System.Drawing.Size(97, 17);
            this.lblPalabrasClave.TabIndex = 0;
            this.lblPalabrasClave.Text = "Palabras clave:";
            this.lblPalabrasClave.Margin = new System.Windows.Forms.Padding(0, 7, 6, 0);
            //
            // btnChip1
            //
            this.btnChip1.BackColor = System.Drawing.Color.Transparent;
            this.btnChip1.BorderRadius = 6;
            this.btnChip1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip1.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip1.BorderRadius = 13;
            this.btnChip1.BorderThickness = 1;
            this.btnChip1.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip1.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip1.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip1.Location = new System.Drawing.Point(0, 0);
            this.btnChip1.Name = "btnChip1";
            this.btnChip1.Size = new System.Drawing.Size(81, 26);
            this.btnChip1.TabIndex = 1;
            this.btnChip1.Text = "citas hoy";
            this.btnChip1.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip1.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip2
            //
            this.btnChip2.BackColor = System.Drawing.Color.Transparent;
            this.btnChip2.BorderRadius = 6;
            this.btnChip2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip2.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip2.BorderRadius = 13;
            this.btnChip2.BorderThickness = 1;
            this.btnChip2.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip2.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip2.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip2.Location = new System.Drawing.Point(0, 0);
            this.btnChip2.Name = "btnChip2";
            this.btnChip2.Size = new System.Drawing.Size(100, 26);
            this.btnChip2.TabIndex = 2;
            this.btnChip2.Text = "citas mañana";
            this.btnChip2.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip2.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip3
            //
            this.btnChip3.BackColor = System.Drawing.Color.Transparent;
            this.btnChip3.BorderRadius = 6;
            this.btnChip3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip3.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip3.BorderRadius = 13;
            this.btnChip3.BorderThickness = 1;
            this.btnChip3.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip3.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip3.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip3.Location = new System.Drawing.Point(0, 0);
            this.btnChip3.Name = "btnChip3";
            this.btnChip3.Size = new System.Drawing.Size(106, 26);
            this.btnChip3.TabIndex = 3;
            this.btnChip3.Text = "sin confirmar";
            this.btnChip3.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip3.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip4
            //
            this.btnChip4.BackColor = System.Drawing.Color.Transparent;
            this.btnChip4.BorderRadius = 6;
            this.btnChip4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip4.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip4.BorderRadius = 13;
            this.btnChip4.BorderThickness = 1;
            this.btnChip4.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip4.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip4.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip4.Location = new System.Drawing.Point(0, 0);
            this.btnChip4.Name = "btnChip4";
            this.btnChip4.Size = new System.Drawing.Size(174, 26);
            this.btnChip4.TabIndex = 4;
            this.btnChip4.Text = "recordatorios pendientes";
            this.btnChip4.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip4.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip5
            //
            this.btnChip5.BackColor = System.Drawing.Color.Transparent;
            this.btnChip5.BorderRadius = 6;
            this.btnChip5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip5.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip5.BorderRadius = 13;
            this.btnChip5.BorderThickness = 1;
            this.btnChip5.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip5.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip5.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip5.Location = new System.Drawing.Point(0, 0);
            this.btnChip5.Name = "btnChip5";
            this.btnChip5.Size = new System.Drawing.Size(125, 26);
            this.btnChip5.TabIndex = 5;
            this.btnChip5.Text = "saldo [paciente]";
            this.btnChip5.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip5.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip6
            //
            this.btnChip6.BackColor = System.Drawing.Color.Transparent;
            this.btnChip6.BorderRadius = 6;
            this.btnChip6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip6.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip6.BorderRadius = 13;
            this.btnChip6.BorderThickness = 1;
            this.btnChip6.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip6.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip6.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip6.Location = new System.Drawing.Point(0, 0);
            this.btnChip6.Name = "btnChip6";
            this.btnChip6.Size = new System.Drawing.Size(94, 26);
            this.btnChip6.TabIndex = 6;
            this.btnChip6.Text = "cobrado hoy";
            this.btnChip6.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip6.Click += new System.EventHandler(this.chip_Click);
            //
            // btnChip7
            //
            this.btnChip7.BackColor = System.Drawing.Color.Transparent;
            this.btnChip7.BorderRadius = 6;
            this.btnChip7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChip7.BorderColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip7.BorderRadius = 13;
            this.btnChip7.BorderThickness = 1;
            this.btnChip7.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnChip7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnChip7.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnChip7.HoverState.FillColor = System.Drawing.Color.FromArgb(207, 234, 234);
            this.btnChip7.Location = new System.Drawing.Point(0, 0);
            this.btnChip7.Name = "btnChip7";
            this.btnChip7.Size = new System.Drawing.Size(143, 26);
            this.btnChip7.TabIndex = 7;
            this.btnChip7.Text = "alergias [paciente]";
            this.btnChip7.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnChip7.Click += new System.EventHandler(this.chip_Click);
            //
            // pnlEntrada
            //
            this.pnlEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEntrada.BackColor = System.Drawing.Color.Transparent;
            this.pnlEntrada.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlEntrada.BorderRadius = 12;
            this.pnlEntrada.BorderThickness = 1;
            this.pnlEntrada.Controls.Add(this.btnEnviar);
            this.pnlEntrada.Controls.Add(this.txtMensaje);
            this.pnlEntrada.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlEntrada.Location = new System.Drawing.Point(22, 604);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(788, 90);
            this.pnlEntrada.TabIndex = 4;
            //
            // txtMensaje
            //
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensaje.DefaultText = "";
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMensaje.Location = new System.Drawing.Point(8, 8);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.PlaceholderText = "Escribe tu pregunta. Ej.: ¿Quién tiene cita mañana?";
            this.txtMensaje.SelectedText = "";
            this.txtMensaje.Size = new System.Drawing.Size(664, 74);
            this.txtMensaje.TabIndex = 0;
            //
            // btnEnviar
            //
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BorderRadius = 6;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnEnviar.Location = new System.Drawing.Point(680, 27);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 36);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            //
            // pnlPreguntas
            //
            this.pnlPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.pnlPreguntas.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlPreguntas.BorderRadius = 10;
            this.pnlPreguntas.BorderThickness = 1;
            this.pnlPreguntas.Controls.Add(this.pnlListaPreguntas);
            this.pnlPreguntas.Controls.Add(this.lblPreguntas);
            this.pnlPreguntas.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlPreguntas.Location = new System.Drawing.Point(826, 80);
            this.pnlPreguntas.Name = "pnlPreguntas";
            this.pnlPreguntas.Size = new System.Drawing.Size(320, 264);
            this.pnlPreguntas.TabIndex = 5;
            //
            // lblPreguntas
            //
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPreguntas.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblPreguntas.Location = new System.Drawing.Point(16, 14);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(130, 17);
            this.lblPreguntas.TabIndex = 0;
            this.lblPreguntas.Text = "Preguntas frecuentes";
            //
            // pnlListaPreguntas
            //
            this.pnlListaPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.pnlListaPreguntas.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlListaPreguntas.BorderRadius = 8;
            this.pnlListaPreguntas.BorderThickness = 1;
            this.pnlListaPreguntas.Controls.Add(this.btnPregunta5);
            this.pnlListaPreguntas.Controls.Add(this.btnPregunta4);
            this.pnlListaPreguntas.Controls.Add(this.btnPregunta3);
            this.pnlListaPreguntas.Controls.Add(this.btnPregunta2);
            this.pnlListaPreguntas.Controls.Add(this.btnPregunta1);
            this.pnlListaPreguntas.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.pnlListaPreguntas.Location = new System.Drawing.Point(16, 44);
            this.pnlListaPreguntas.Name = "pnlListaPreguntas";
            this.pnlListaPreguntas.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlListaPreguntas.Size = new System.Drawing.Size(288, 204);
            this.pnlListaPreguntas.TabIndex = 1;
            //
            // btnPregunta1
            //
            this.btnPregunta1.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta1.BorderRadius = 6;
            this.btnPregunta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta1.FillColor = System.Drawing.Color.White;
            this.btnPregunta1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPregunta1.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnPregunta1.HoverState.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnPregunta1.HoverState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnPregunta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta1.Location = new System.Drawing.Point(1, 2);
            this.btnPregunta1.Name = "btnPregunta1";
            this.btnPregunta1.Size = new System.Drawing.Size(286, 40);
            this.btnPregunta1.TabIndex = 0;
            this.btnPregunta1.Text = "¿Qué citas tengo hoy?";
            this.btnPregunta1.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.btnPregunta1.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPregunta1.Click += new System.EventHandler(this.pregunta_Click);
            //
            // btnPregunta2
            //
            this.btnPregunta2.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta2.BorderRadius = 6;
            this.btnPregunta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta2.FillColor = System.Drawing.Color.White;
            this.btnPregunta2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPregunta2.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnPregunta2.HoverState.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnPregunta2.HoverState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnPregunta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta2.Location = new System.Drawing.Point(1, 42);
            this.btnPregunta2.Name = "btnPregunta2";
            this.btnPregunta2.Size = new System.Drawing.Size(286, 40);
            this.btnPregunta2.TabIndex = 1;
            this.btnPregunta2.Text = "¿Qué pacientes no han confirmado?";
            this.btnPregunta2.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.btnPregunta2.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPregunta2.Click += new System.EventHandler(this.pregunta_Click);
            //
            // btnPregunta3
            //
            this.btnPregunta3.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta3.BorderRadius = 6;
            this.btnPregunta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta3.FillColor = System.Drawing.Color.White;
            this.btnPregunta3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPregunta3.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnPregunta3.HoverState.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnPregunta3.HoverState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnPregunta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta3.Location = new System.Drawing.Point(1, 82);
            this.btnPregunta3.Name = "btnPregunta3";
            this.btnPregunta3.Size = new System.Drawing.Size(286, 40);
            this.btnPregunta3.TabIndex = 2;
            this.btnPregunta3.Text = "¿Cuánto se cobró hoy?";
            this.btnPregunta3.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.btnPregunta3.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPregunta3.Click += new System.EventHandler(this.pregunta_Click);
            //
            // btnPregunta4
            //
            this.btnPregunta4.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta4.BorderRadius = 6;
            this.btnPregunta4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta4.FillColor = System.Drawing.Color.White;
            this.btnPregunta4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPregunta4.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnPregunta4.HoverState.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnPregunta4.HoverState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnPregunta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta4.Location = new System.Drawing.Point(1, 122);
            this.btnPregunta4.Name = "btnPregunta4";
            this.btnPregunta4.Size = new System.Drawing.Size(286, 40);
            this.btnPregunta4.TabIndex = 3;
            this.btnPregunta4.Text = "¿Qué pacientes tienen saldo pendiente?";
            this.btnPregunta4.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.btnPregunta4.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPregunta4.Click += new System.EventHandler(this.pregunta_Click);
            //
            // btnPregunta5
            //
            this.btnPregunta5.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta5.BorderRadius = 6;
            this.btnPregunta5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta5.FillColor = System.Drawing.Color.White;
            this.btnPregunta5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPregunta5.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnPregunta5.HoverState.FillColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.btnPregunta5.HoverState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnPregunta5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta5.Location = new System.Drawing.Point(1, 162);
            this.btnPregunta5.Name = "btnPregunta5";
            this.btnPregunta5.Size = new System.Drawing.Size(286, 40);
            this.btnPregunta5.TabIndex = 4;
            this.btnPregunta5.Text = "¿Cuándo fue la última visita de un paciente?";
            this.btnPregunta5.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.btnPregunta5.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPregunta5.Click += new System.EventHandler(this.pregunta_Click);
            //
            // pnlEstadoAsistente
            //
            this.pnlEstadoAsistente.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEstadoAsistente.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstadoAsistente.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlEstadoAsistente.BorderRadius = 10;
            this.pnlEstadoAsistente.BorderThickness = 1;
            this.pnlEstadoAsistente.Controls.Add(this.btnBorrarConversacion);
            this.pnlEstadoAsistente.Controls.Add(this.lblNotaAsistente);
            this.pnlEstadoAsistente.Controls.Add(this.lblConectado);
            this.pnlEstadoAsistente.Controls.Add(this.lblPuntoEstado);
            this.pnlEstadoAsistente.Controls.Add(this.lblEstado);
            this.pnlEstadoAsistente.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlEstadoAsistente.Location = new System.Drawing.Point(826, 358);
            this.pnlEstadoAsistente.Name = "pnlEstadoAsistente";
            this.pnlEstadoAsistente.Size = new System.Drawing.Size(320, 156);
            this.pnlEstadoAsistente.TabIndex = 6;
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblEstado.Location = new System.Drawing.Point(16, 14);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(39, 17);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            //
            // lblPuntoEstado
            //
            this.lblPuntoEstado.AutoSize = true;
            this.lblPuntoEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPuntoEstado.ForeColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.lblPuntoEstado.Location = new System.Drawing.Point(16, 46);
            this.lblPuntoEstado.Name = "lblPuntoEstado";
            this.lblPuntoEstado.Size = new System.Drawing.Size(20, 17);
            this.lblPuntoEstado.TabIndex = 1;
            this.lblPuntoEstado.Text = "●";
            //
            // lblConectado
            //
            this.lblConectado.AutoSize = true;
            this.lblConectado.BackColor = System.Drawing.Color.Transparent;
            this.lblConectado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblConectado.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblConectado.Location = new System.Drawing.Point(32, 46);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(58, 17);
            this.lblConectado.TabIndex = 2;
            this.lblConectado.Text = "Conectado";
            //
            // lblNotaAsistente
            //
            this.lblNotaAsistente.BackColor = System.Drawing.Color.Transparent;
            this.lblNotaAsistente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotaAsistente.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblNotaAsistente.Location = new System.Drawing.Point(16, 72);
            this.lblNotaAsistente.Name = "lblNotaAsistente";
            this.lblNotaAsistente.Size = new System.Drawing.Size(288, 32);
            this.lblNotaAsistente.TabIndex = 3;
            this.lblNotaAsistente.Text = "El asistente solo consulta datos; no modifica citas, fichas ni pagos.";
            //
            // btnBorrarConversacion
            //
            this.btnBorrarConversacion.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarConversacion.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnBorrarConversacion.BorderRadius = 6;
            this.btnBorrarConversacion.BorderThickness = 1;
            this.btnBorrarConversacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarConversacion.FillColor = System.Drawing.Color.White;
            this.btnBorrarConversacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBorrarConversacion.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnBorrarConversacion.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnBorrarConversacion.Location = new System.Drawing.Point(16, 110);
            this.btnBorrarConversacion.Name = "btnBorrarConversacion";
            this.btnBorrarConversacion.Size = new System.Drawing.Size(288, 32);
            this.btnBorrarConversacion.TabIndex = 4;
            this.btnBorrarConversacion.Text = "Borrar conversación";
            this.btnBorrarConversacion.Click += new System.EventHandler(this.btnBorrarConversacion_Click);
            //
            // frmAsistente
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.ClientSize = new System.Drawing.Size(1168, 726);
            this.Controls.Add(this.pnlEstadoAsistente);
            this.Controls.Add(this.pnlPreguntas);
            this.Controls.Add(this.pnlEntrada);
            this.Controls.Add(this.flpChips);
            this.Controls.Add(this.pnlConversacion);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsistente";
            this.Text = "DentoTacna — Asistente IA";
            this.pnlEstadoAsistente.ResumeLayout(false);
            this.pnlEstadoAsistente.PerformLayout();
            this.pnlListaPreguntas.ResumeLayout(false);
            this.pnlPreguntas.ResumeLayout(false);
            this.pnlPreguntas.PerformLayout();
            this.pnlEntrada.ResumeLayout(false);
            this.flpChips.ResumeLayout(false);
            this.flpChips.PerformLayout();
            this.flpChat.ResumeLayout(false);
            this.pnlConversacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlConversacion;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        private System.Windows.Forms.FlowLayoutPanel flpChips;
        private System.Windows.Forms.Label lblPalabrasClave;
        private Guna.UI2.WinForms.Guna2Button btnChip1;
        private Guna.UI2.WinForms.Guna2Button btnChip2;
        private Guna.UI2.WinForms.Guna2Button btnChip3;
        private Guna.UI2.WinForms.Guna2Button btnChip4;
        private Guna.UI2.WinForms.Guna2Button btnChip5;
        private Guna.UI2.WinForms.Guna2Button btnChip6;
        private Guna.UI2.WinForms.Guna2Button btnChip7;
        private Guna.UI2.WinForms.Guna2Panel pnlEntrada;
        private Guna.UI2.WinForms.Guna2TextBox txtMensaje;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Guna.UI2.WinForms.Guna2Panel pnlPreguntas;
        private System.Windows.Forms.Label lblPreguntas;
        private Guna.UI2.WinForms.Guna2Panel pnlListaPreguntas;
        private Guna.UI2.WinForms.Guna2Button btnPregunta1;
        private Guna.UI2.WinForms.Guna2Button btnPregunta2;
        private Guna.UI2.WinForms.Guna2Button btnPregunta3;
        private Guna.UI2.WinForms.Guna2Button btnPregunta4;
        private Guna.UI2.WinForms.Guna2Button btnPregunta5;
        private Guna.UI2.WinForms.Guna2Panel pnlEstadoAsistente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPuntoEstado;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Label lblNotaAsistente;
        private Guna.UI2.WinForms.Guna2Button btnBorrarConversacion;
    }
}
