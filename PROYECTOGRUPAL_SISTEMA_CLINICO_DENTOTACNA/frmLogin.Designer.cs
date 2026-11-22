namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlMarca = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClinica = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlTarjeta = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlError = new Guna.UI2.WinForms.Guna2Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsuariosPrueba = new System.Windows.Forms.Label();
            this.pnlMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTarjeta.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMarca
            //
            this.pnlMarca.Controls.Add(this.lblVersion);
            this.pnlMarca.Controls.Add(this.lblDescripcion);
            this.pnlMarca.Controls.Add(this.lblClinica);
            this.pnlMarca.Controls.Add(this.pictureBox1);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(133)))), ((int)(((byte)(138)))));
            this.pnlMarca.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(94)))));
            this.pnlMarca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(396, 600);
            this.pnlMarca.TabIndex = 0;
            //
            // pictureBox1
            //
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA.Properties.Resources.Diente_brillante_con_corazón_ortodóntico;
            this.pictureBox1.Location = new System.Drawing.Point(46, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // lblClinica
            //
            this.lblClinica.AutoSize = true;
            this.lblClinica.BackColor = System.Drawing.Color.Transparent;
            this.lblClinica.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinica.ForeColor = System.Drawing.Color.White;
            this.lblClinica.Location = new System.Drawing.Point(40, 140);
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.Size = new System.Drawing.Size(181, 41);
            this.lblClinica.TabIndex = 1;
            this.lblClinica.Text = "DentoTacna";
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblDescripcion.Location = new System.Drawing.Point(45, 186);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(243, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Implantología y Ortodoncia · Tacna";
            //
            // lblVersion
            //
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.lblVersion.Location = new System.Drawing.Point(46, 548);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(278, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Sistema de gestión de la clínica · Versión 0.1 de prueba";
            //
            // pnlTarjeta
            //
            this.pnlTarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.pnlTarjeta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.pnlTarjeta.BorderRadius = 14;
            this.pnlTarjeta.BorderThickness = 1;
            this.pnlTarjeta.Controls.Add(this.lblUsuariosPrueba);
            this.pnlTarjeta.Controls.Add(this.btnSalir);
            this.pnlTarjeta.Controls.Add(this.btnIngresar);
            this.pnlTarjeta.Controls.Add(this.pnlError);
            this.pnlTarjeta.Controls.Add(this.btnMostrar);
            this.pnlTarjeta.Controls.Add(this.txtContrasenia);
            this.pnlTarjeta.Controls.Add(this.lblContrasenia);
            this.pnlTarjeta.Controls.Add(this.txtUsuario);
            this.pnlTarjeta.Controls.Add(this.lblUsuario);
            this.pnlTarjeta.Controls.Add(this.lblIndicacion);
            this.pnlTarjeta.Controls.Add(this.lblTitulo);
            this.pnlTarjeta.FillColor = System.Drawing.Color.White;
            this.pnlTarjeta.Location = new System.Drawing.Point(462, 80);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(380, 440);
            this.pnlTarjeta.TabIndex = 1;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblTitulo.Location = new System.Drawing.Point(26, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Iniciar sesión";
            //
            // lblIndicacion
            //
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblIndicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblIndicacion.Location = new System.Drawing.Point(28, 56);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(225, 17);
            this.lblIndicacion.TabIndex = 1;
            this.lblIndicacion.Text = "Ingresa con tu usuario de la clínica.";
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblUsuario.Location = new System.Drawing.Point(28, 96);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 15);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario *";
            //
            // txtUsuario
            //
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(28, 116);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ej.: rtorres";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(324, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);
            //
            // lblContrasenia
            //
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblContrasenia.Location = new System.Drawing.Point(28, 164);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(75, 15);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña *";
            //
            // txtContrasenia
            //
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.DefaultText = "";
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtContrasenia.Location = new System.Drawing.Point(28, 184);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PlaceholderText = "Ingrese su contraseña";
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.Size = new System.Drawing.Size(234, 36);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);
            //
            // btnMostrar
            //
            this.btnMostrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnMostrar.BorderRadius = 6;
            this.btnMostrar.BorderThickness = 1;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FillColor = System.Drawing.Color.White;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnMostrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnMostrar.Location = new System.Drawing.Point(268, 184);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(84, 36);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            //
            // pnlError
            //
            this.pnlError.BackColor = System.Drawing.Color.Transparent;
            this.pnlError.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.pnlError.BorderRadius = 8;
            this.pnlError.BorderThickness = 1;
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlError.Location = new System.Drawing.Point(28, 232);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(324, 36);
            this.pnlError.TabIndex = 5;
            this.pnlError.Visible = false;
            //
            // lblError
            //
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblError.Location = new System.Drawing.Point(12, 10);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(196, 15);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Usuario o contraseña incorrectos.";
            //
            // btnIngresar
            //
            this.btnIngresar.BorderRadius = 6;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnIngresar.Location = new System.Drawing.Point(28, 280);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(324, 40);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // btnSalir
            //
            this.btnSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnSalir.BorderRadius = 6;
            this.btnSalir.BorderThickness = 1;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FillColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnSalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSalir.Location = new System.Drawing.Point(28, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(324, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // lblUsuariosPrueba
            //
            this.lblUsuariosPrueba.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuariosPrueba.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUsuariosPrueba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblUsuariosPrueba.Location = new System.Drawing.Point(28, 378);
            this.lblUsuariosPrueba.Name = "lblUsuariosPrueba";
            this.lblUsuariosPrueba.Size = new System.Drawing.Size(324, 36);
            this.lblUsuariosPrueba.TabIndex = 6;
            this.lblUsuariosPrueba.Text = "Usuarios de prueba: rtorres (Recepción) · mquispe (Odontólogo) · admin (Administrador)";
            //
            // frmLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlTarjeta);
            this.Controls.Add(this.pnlMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentoTacna — Iniciar sesión";
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMarca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVersion;
        private Guna.UI2.WinForms.Guna2Panel pnlTarjeta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Guna.UI2.WinForms.Guna2Button btnMostrar;
        private Guna.UI2.WinForms.Guna2Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private System.Windows.Forms.Label lblUsuariosPrueba;
    }
}
