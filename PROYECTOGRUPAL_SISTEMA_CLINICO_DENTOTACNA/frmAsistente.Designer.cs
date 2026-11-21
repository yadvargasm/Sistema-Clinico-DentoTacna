namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmAsistente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEncabezado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlConversacion = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAvatarBot = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlBurbujaBot = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMensajeBot = new System.Windows.Forms.Label();
            this.lblMetaBot = new System.Windows.Forms.Label();
            this.pnlEntrada = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMensaje = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPreguntas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.btnPregunta1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPregunta5 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEstadoAsistente = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlIndicador = new Guna.UI2.WinForms.Guna2Panel();
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblNotaAsistente = new System.Windows.Forms.Label();
            this.btnBorrarConversacion = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlConversacion.SuspendLayout();
            this.pnlBurbujaBot.SuspendLayout();
            this.pnlEntrada.SuspendLayout();
            this.pnlPreguntas.SuspendLayout();
            this.pnlEstadoAsistente.SuspendLayout();
            this.pnlIndicador.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1138, 80);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 25);
            this.lblTitulo.Text = "Asistente IA";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(22, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(394, 15);
            this.lblSubtitulo.Text = "Consultas en lenguaje natural sobre citas, pacientes y pagos";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // pnlConversacion
            // 
            this.pnlConversacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConversacion.AutoScroll = true;
            this.pnlConversacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlConversacion.BorderRadius = 10;
            this.pnlConversacion.Controls.Add(this.lblMetaBot);
            this.pnlConversacion.Controls.Add(this.pnlBurbujaBot);
            this.pnlConversacion.Controls.Add(this.btnAvatarBot);
            this.pnlConversacion.FillColor = System.Drawing.Color.White;
            this.pnlConversacion.Location = new System.Drawing.Point(20, 80);
            this.pnlConversacion.Name = "pnlConversacion";
            this.pnlConversacion.Size = new System.Drawing.Size(742, 470);
            this.pnlConversacion.TabIndex = 1;
            // 
            // btnAvatarBot
            // 
            this.btnAvatarBot.BackColor = System.Drawing.Color.Transparent;
            this.btnAvatarBot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.btnAvatarBot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatarBot.ForeColor = System.Drawing.Color.White;
            this.btnAvatarBot.Location = new System.Drawing.Point(18, 18);
            this.btnAvatarBot.Name = "btnAvatarBot";
            this.btnAvatarBot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvatarBot.Size = new System.Drawing.Size(38, 38);
            this.btnAvatarBot.Text = "IA";
            this.btnAvatarBot.TabIndex = 0;
            // 
            // pnlBurbujaBot
            // 
            this.pnlBurbujaBot.BackColor = System.Drawing.Color.Transparent;
            this.pnlBurbujaBot.BorderRadius = 12;
            this.pnlBurbujaBot.Controls.Add(this.lblMensajeBot);
            this.pnlBurbujaBot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.pnlBurbujaBot.Location = new System.Drawing.Point(66, 20);
            this.pnlBurbujaBot.Name = "pnlBurbujaBot";
            this.pnlBurbujaBot.Size = new System.Drawing.Size(440, 44);
            this.pnlBurbujaBot.TabIndex = 1;
            // 
            // lblMensajeBot
            // 
            this.lblMensajeBot.AutoSize = true;
            this.lblMensajeBot.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeBot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblMensajeBot.Location = new System.Drawing.Point(14, 14);
            this.lblMensajeBot.Name = "lblMensajeBot";
            this.lblMensajeBot.Size = new System.Drawing.Size(491, 15);
            this.lblMensajeBot.Text = "Hola, puedo consultar la agenda, los pacientes y los pagos. ¿Qué necesitas?";
            this.lblMensajeBot.TabIndex = 0;
            // 
            // lblMetaBot
            // 
            this.lblMetaBot.AutoSize = true;
            this.lblMetaBot.BackColor = System.Drawing.Color.Transparent;
            this.lblMetaBot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaBot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblMetaBot.Location = new System.Drawing.Point(70, 68);
            this.lblMetaBot.Name = "lblMetaBot";
            this.lblMetaBot.Size = new System.Drawing.Size(62, 13);
            this.lblMetaBot.Text = "Asistente";
            this.lblMetaBot.TabIndex = 2;
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEntrada.BackColor = System.Drawing.Color.Transparent;
            this.pnlEntrada.BorderRadius = 10;
            this.pnlEntrada.Controls.Add(this.btnEnviar);
            this.pnlEntrada.Controls.Add(this.txtMensaje);
            this.pnlEntrada.FillColor = System.Drawing.Color.White;
            this.pnlEntrada.Location = new System.Drawing.Point(20, 566);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(742, 70);
            this.pnlEntrada.TabIndex = 2;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.BackColor = System.Drawing.Color.Transparent;
            this.txtMensaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtMensaje.BorderRadius = 8;
            this.txtMensaje.BorderThickness = 0;
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensaje.DefaultText = "";
            this.txtMensaje.FillColor = System.Drawing.Color.White;
            this.txtMensaje.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtMensaje.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMensaje.Location = new System.Drawing.Point(8, 8);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtMensaje.PlaceholderText = "Escribe tu pregunta. Ej.: ¿Quién tiene cita mañana?";
            this.txtMensaje.SelectedText = "";
            this.txtMensaje.Size = new System.Drawing.Size(614, 54);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BorderRadius = 8;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnEnviar.Location = new System.Drawing.Point(628, 17);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 36);
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TabIndex = 1;
            // 
            // pnlPreguntas
            // 
            this.pnlPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.pnlPreguntas.BorderRadius = 10;
            this.pnlPreguntas.Controls.Add(this.btnPregunta5);
            this.pnlPreguntas.Controls.Add(this.btnPregunta4);
            this.pnlPreguntas.Controls.Add(this.btnPregunta3);
            this.pnlPreguntas.Controls.Add(this.btnPregunta2);
            this.pnlPreguntas.Controls.Add(this.btnPregunta1);
            this.pnlPreguntas.Controls.Add(this.lblPreguntas);
            this.pnlPreguntas.FillColor = System.Drawing.Color.White;
            this.pnlPreguntas.Location = new System.Drawing.Point(778, 80);
            this.pnlPreguntas.Name = "pnlPreguntas";
            this.pnlPreguntas.Size = new System.Drawing.Size(340, 278);
            this.pnlPreguntas.TabIndex = 3;
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblPreguntas.Location = new System.Drawing.Point(16, 14);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(154, 20);
            this.lblPreguntas.Text = "Preguntas frecuentes";
            this.lblPreguntas.TabIndex = 0;
            // 
            // btnPregunta1
            // 
            this.btnPregunta1.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnPregunta1.BorderRadius = 6;
            this.btnPregunta1.BorderThickness = 1;
            this.btnPregunta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnPregunta1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnPregunta1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPregunta1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnPregunta1.Location = new System.Drawing.Point(16, 48);
            this.btnPregunta1.Name = "btnPregunta1";
            this.btnPregunta1.Size = new System.Drawing.Size(308, 38);
            this.btnPregunta1.Text = "¿Qué citas tengo hoy?";
            this.btnPregunta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta1.TextOffset = new System.Drawing.Point(6, 0);
            this.btnPregunta1.TabIndex = 1;
            // 
            // btnPregunta2
            // 
            this.btnPregunta2.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnPregunta2.BorderRadius = 6;
            this.btnPregunta2.BorderThickness = 1;
            this.btnPregunta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnPregunta2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnPregunta2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPregunta2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnPregunta2.Location = new System.Drawing.Point(16, 92);
            this.btnPregunta2.Name = "btnPregunta2";
            this.btnPregunta2.Size = new System.Drawing.Size(308, 38);
            this.btnPregunta2.Text = "¿Qué citas hay mañana?";
            this.btnPregunta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta2.TextOffset = new System.Drawing.Point(6, 0);
            this.btnPregunta2.TabIndex = 2;
            // 
            // btnPregunta3
            // 
            this.btnPregunta3.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnPregunta3.BorderRadius = 6;
            this.btnPregunta3.BorderThickness = 1;
            this.btnPregunta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnPregunta3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnPregunta3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPregunta3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnPregunta3.Location = new System.Drawing.Point(16, 136);
            this.btnPregunta3.Name = "btnPregunta3";
            this.btnPregunta3.Size = new System.Drawing.Size(308, 38);
            this.btnPregunta3.Text = "¿Cuánto se cobró hoy?";
            this.btnPregunta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta3.TextOffset = new System.Drawing.Point(6, 0);
            this.btnPregunta3.TabIndex = 3;
            // 
            // btnPregunta4
            // 
            this.btnPregunta4.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnPregunta4.BorderRadius = 6;
            this.btnPregunta4.BorderThickness = 1;
            this.btnPregunta4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnPregunta4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnPregunta4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPregunta4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnPregunta4.Location = new System.Drawing.Point(16, 180);
            this.btnPregunta4.Name = "btnPregunta4";
            this.btnPregunta4.Size = new System.Drawing.Size(308, 38);
            this.btnPregunta4.Text = "¿Qué pacientes tienen saldo pendiente?";
            this.btnPregunta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta4.TextOffset = new System.Drawing.Point(6, 0);
            this.btnPregunta4.TabIndex = 4;
            // 
            // btnPregunta5
            // 
            this.btnPregunta5.BackColor = System.Drawing.Color.Transparent;
            this.btnPregunta5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnPregunta5.BorderRadius = 6;
            this.btnPregunta5.BorderThickness = 1;
            this.btnPregunta5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregunta5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnPregunta5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnPregunta5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPregunta5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnPregunta5.Location = new System.Drawing.Point(16, 224);
            this.btnPregunta5.Name = "btnPregunta5";
            this.btnPregunta5.Size = new System.Drawing.Size(308, 38);
            this.btnPregunta5.Text = "¿Cuándo fue la última visita de un paciente?";
            this.btnPregunta5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPregunta5.TextOffset = new System.Drawing.Point(6, 0);
            this.btnPregunta5.TabIndex = 5;
            // 
            // pnlEstadoAsistente
            // 
            this.pnlEstadoAsistente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEstadoAsistente.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstadoAsistente.BorderRadius = 10;
            this.pnlEstadoAsistente.Controls.Add(this.btnBorrarConversacion);
            this.pnlEstadoAsistente.Controls.Add(this.lblNotaAsistente);
            this.pnlEstadoAsistente.Controls.Add(this.lblConectado);
            this.pnlEstadoAsistente.Controls.Add(this.pnlIndicador);
            this.pnlEstadoAsistente.Controls.Add(this.lblEstado);
            this.pnlEstadoAsistente.FillColor = System.Drawing.Color.White;
            this.pnlEstadoAsistente.Location = new System.Drawing.Point(778, 374);
            this.pnlEstadoAsistente.Name = "pnlEstadoAsistente";
            this.pnlEstadoAsistente.Size = new System.Drawing.Size(340, 176);
            this.pnlEstadoAsistente.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblEstado.Location = new System.Drawing.Point(16, 14);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 20);
            this.lblEstado.Text = "Estado";
            this.lblEstado.TabIndex = 0;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicador.BorderRadius = 5;
            this.pnlIndicador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pnlIndicador.Location = new System.Drawing.Point(18, 51);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(10, 10);
            this.pnlIndicador.TabIndex = 1;
            // 
            // lblConectado
            // 
            this.lblConectado.AutoSize = true;
            this.lblConectado.BackColor = System.Drawing.Color.Transparent;
            this.lblConectado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblConectado.Location = new System.Drawing.Point(34, 48);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(62, 15);
            this.lblConectado.Text = "Conectado";
            this.lblConectado.TabIndex = 2;
            // 
            // lblNotaAsistente
            // 
            this.lblNotaAsistente.AutoSize = true;
            this.lblNotaAsistente.BackColor = System.Drawing.Color.Transparent;
            this.lblNotaAsistente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaAsistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblNotaAsistente.Location = new System.Drawing.Point(16, 74);
            this.lblNotaAsistente.MaximumSize = new System.Drawing.Size(308, 0);
            this.lblNotaAsistente.Name = "lblNotaAsistente";
            this.lblNotaAsistente.Size = new System.Drawing.Size(400, 15);
            this.lblNotaAsistente.Text = "El asistente solo consulta datos; no modifica citas ni pagos.";
            this.lblNotaAsistente.TabIndex = 3;
            // 
            // btnBorrarConversacion
            // 
            this.btnBorrarConversacion.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarConversacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnBorrarConversacion.BorderRadius = 8;
            this.btnBorrarConversacion.BorderThickness = 1;
            this.btnBorrarConversacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarConversacion.FillColor = System.Drawing.Color.White;
            this.btnBorrarConversacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarConversacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnBorrarConversacion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnBorrarConversacion.Location = new System.Drawing.Point(16, 124);
            this.btnBorrarConversacion.Name = "btnBorrarConversacion";
            this.btnBorrarConversacion.Size = new System.Drawing.Size(308, 36);
            this.btnBorrarConversacion.Text = "Borrar conversación";
            this.btnBorrarConversacion.TabIndex = 4;
            // 
            // frmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1138, 731);
            this.Controls.Add(this.pnlEstadoAsistente);
            this.Controls.Add(this.pnlPreguntas);
            this.Controls.Add(this.pnlEntrada);
            this.Controls.Add(this.pnlConversacion);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentoTacna Smart — Asistente IA";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlConversacion.ResumeLayout(false);
            this.pnlConversacion.PerformLayout();
            this.pnlBurbujaBot.ResumeLayout(false);
            this.pnlBurbujaBot.PerformLayout();
            this.pnlEntrada.ResumeLayout(false);
            this.pnlPreguntas.ResumeLayout(false);
            this.pnlPreguntas.PerformLayout();
            this.pnlEstadoAsistente.ResumeLayout(false);
            this.pnlEstadoAsistente.PerformLayout();
            this.pnlIndicador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlConversacion;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatarBot;
        private Guna.UI2.WinForms.Guna2Panel pnlBurbujaBot;
        private System.Windows.Forms.Label lblMensajeBot;
        private System.Windows.Forms.Label lblMetaBot;
        private Guna.UI2.WinForms.Guna2Panel pnlEntrada;
        private Guna.UI2.WinForms.Guna2TextBox txtMensaje;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Guna.UI2.WinForms.Guna2Panel pnlPreguntas;
        private System.Windows.Forms.Label lblPreguntas;
        private Guna.UI2.WinForms.Guna2Button btnPregunta1;
        private Guna.UI2.WinForms.Guna2Button btnPregunta2;
        private Guna.UI2.WinForms.Guna2Button btnPregunta3;
        private Guna.UI2.WinForms.Guna2Button btnPregunta4;
        private Guna.UI2.WinForms.Guna2Button btnPregunta5;
        private Guna.UI2.WinForms.Guna2Panel pnlEstadoAsistente;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlIndicador;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Label lblNotaAsistente;
        private Guna.UI2.WinForms.Guna2Button btnBorrarConversacion;
    }
}