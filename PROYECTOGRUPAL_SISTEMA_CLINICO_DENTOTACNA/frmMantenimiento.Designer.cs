namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmMantenimiento
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
            this.tabMantenimiento = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabOdontologos = new System.Windows.Forms.TabPage();
            this.tabTratamientos = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.pnlDatosOdontologo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatosOdontologo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCop = new System.Windows.Forms.Label();
            this.txtCop = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cboEspecialidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkActivo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnNuevoOdontologo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarOdontologo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarOdontologo = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTablaOdontologos = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOdontologos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatosTratamiento = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatosTratamiento = new System.Windows.Forms.Label();
            this.lblNombreTratamiento = new System.Windows.Forms.Label();
            this.txtNombreTratamiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudDuracion = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNuevoTratamiento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarTratamiento = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarTratamiento = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTablaTratamientos = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTratamientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCodigoTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatosUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOdontologoVinculado = new System.Windows.Forms.Label();
            this.cboOdontologoVinculado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkUsuarioActivo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnNuevoUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesactivarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTablaUsuarios = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltimoIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMantenimiento.SuspendLayout();
            this.tabOdontologos.SuspendLayout();
            this.tabTratamientos.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.pnlDatosOdontologo.SuspendLayout();
            this.pnlTablaOdontologos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).BeginInit();
            this.pnlDatosTratamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.pnlTablaTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.pnlTablaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(84, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblSubtitulo.Location = new System.Drawing.Point(23, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(312, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Odontólogos, catálogo de tratamientos y usuarios";
            //
            // tabMantenimiento
            //
            this.tabMantenimiento.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.tabMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.tabMantenimiento.ItemSize = new System.Drawing.Size(150, 36);
            this.tabMantenimiento.Controls.Add(this.tabOdontologos);
            this.tabMantenimiento.Controls.Add(this.tabTratamientos);
            this.tabMantenimiento.Controls.Add(this.tabUsuarios);
            this.tabMantenimiento.Location = new System.Drawing.Point(18, 76);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.SelectedIndex = 0;
            this.tabMantenimiento.Size = new System.Drawing.Size(1132, 636);
            this.tabMantenimiento.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(214, 226, 230);
            this.tabMantenimiento.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(214, 226, 230);
            this.tabMantenimiento.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabMantenimiento.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.tabMantenimiento.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(214, 226, 230);
            this.tabMantenimiento.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(226, 234, 237);
            this.tabMantenimiento.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(226, 234, 237);
            this.tabMantenimiento.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabMantenimiento.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(69, 84, 91);
            this.tabMantenimiento.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(226, 234, 237);
            this.tabMantenimiento.TabButtonSelectedState.BorderColor = System.Drawing.Color.White;
            this.tabMantenimiento.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabMantenimiento.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabMantenimiento.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.tabMantenimiento.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.tabMantenimiento.TabButtonSize = new System.Drawing.Size(150, 36);
            this.tabMantenimiento.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabMantenimiento.TabIndex = 2;
            this.tabMantenimiento.TabMenuBackColor = System.Drawing.Color.FromArgb(226, 234, 237);
            //
            // tabOdontologos
            //
            this.tabOdontologos.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.tabOdontologos.Controls.Add(this.pnlTablaOdontologos);
            this.tabOdontologos.Controls.Add(this.pnlDatosOdontologo);
            this.tabOdontologos.Location = new System.Drawing.Point(4, 40);
            this.tabOdontologos.Name = "tabOdontologos";
            this.tabOdontologos.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdontologos.Size = new System.Drawing.Size(1124, 592);
            this.tabOdontologos.TabIndex = 0;
            this.tabOdontologos.Text = "Odontólogos";
            //
            // tabTratamientos
            //
            this.tabTratamientos.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.tabTratamientos.Controls.Add(this.pnlTablaTratamientos);
            this.tabTratamientos.Controls.Add(this.pnlDatosTratamiento);
            this.tabTratamientos.Location = new System.Drawing.Point(4, 40);
            this.tabTratamientos.Name = "tabTratamientos";
            this.tabTratamientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTratamientos.Size = new System.Drawing.Size(1124, 592);
            this.tabTratamientos.TabIndex = 1;
            this.tabTratamientos.Text = "Tratamientos";
            //
            // tabUsuarios
            //
            this.tabUsuarios.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.tabUsuarios.Controls.Add(this.pnlTablaUsuarios);
            this.tabUsuarios.Controls.Add(this.pnlDatosUsuario);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 40);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1124, 592);
            this.tabUsuarios.TabIndex = 2;
            this.tabUsuarios.Text = "Usuarios";
            //
            // pnlDatosOdontologo
            //
            this.pnlDatosOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosOdontologo.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlDatosOdontologo.BorderRadius = 10;
            this.pnlDatosOdontologo.BorderThickness = 1;
            this.pnlDatosOdontologo.Controls.Add(this.btnGuardarOdontologo);
            this.pnlDatosOdontologo.Controls.Add(this.btnEliminarOdontologo);
            this.pnlDatosOdontologo.Controls.Add(this.btnNuevoOdontologo);
            this.pnlDatosOdontologo.Controls.Add(this.chkActivo);
            this.pnlDatosOdontologo.Controls.Add(this.cboEspecialidad);
            this.pnlDatosOdontologo.Controls.Add(this.lblEspecialidad);
            this.pnlDatosOdontologo.Controls.Add(this.txtTelefono);
            this.pnlDatosOdontologo.Controls.Add(this.lblTelefono);
            this.pnlDatosOdontologo.Controls.Add(this.txtCop);
            this.pnlDatosOdontologo.Controls.Add(this.lblCop);
            this.pnlDatosOdontologo.Controls.Add(this.txtApellidos);
            this.pnlDatosOdontologo.Controls.Add(this.lblApellidos);
            this.pnlDatosOdontologo.Controls.Add(this.txtNombres);
            this.pnlDatosOdontologo.Controls.Add(this.lblNombres);
            this.pnlDatosOdontologo.Controls.Add(this.lblDatosOdontologo);
            this.pnlDatosOdontologo.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlDatosOdontologo.Location = new System.Drawing.Point(4, 12);
            this.pnlDatosOdontologo.Name = "pnlDatosOdontologo";
            this.pnlDatosOdontologo.Size = new System.Drawing.Size(380, 332);
            this.pnlDatosOdontologo.TabIndex = 0;
            //
            // lblDatosOdontologo
            //
            this.lblDatosOdontologo.AutoSize = true;
            this.lblDatosOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosOdontologo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDatosOdontologo.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblDatosOdontologo.Location = new System.Drawing.Point(16, 14);
            this.lblDatosOdontologo.Name = "lblDatosOdontologo";
            this.lblDatosOdontologo.Size = new System.Drawing.Size(130, 17);
            this.lblDatosOdontologo.TabIndex = 0;
            this.lblDatosOdontologo.Text = "Datos del odontólogo";
            //
            // lblNombres
            //
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblNombres.Location = new System.Drawing.Point(16, 46);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(58, 17);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres *";
            //
            // txtNombres
            //
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.DefaultText = "";
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombres.Location = new System.Drawing.Point(16, 66);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PlaceholderText = "";
            this.txtNombres.SelectedText = "";
            this.txtNombres.Size = new System.Drawing.Size(170, 36);
            this.txtNombres.TabIndex = 2;
            //
            // lblApellidos
            //
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblApellidos.Location = new System.Drawing.Point(194, 46);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(71, 17);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos *";
            //
            // txtApellidos
            //
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.DefaultText = "";
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtApellidos.Location = new System.Drawing.Point(194, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PlaceholderText = "";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.Size = new System.Drawing.Size(170, 36);
            this.txtApellidos.TabIndex = 4;
            //
            // lblCop
            //
            this.lblCop.AutoSize = true;
            this.lblCop.BackColor = System.Drawing.Color.Transparent;
            this.lblCop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCop.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblCop.Location = new System.Drawing.Point(16, 110);
            this.lblCop.Name = "lblCop";
            this.lblCop.Size = new System.Drawing.Size(58, 17);
            this.lblCop.TabIndex = 5;
            this.lblCop.Text = "N.° COP *";
            //
            // txtCop
            //
            this.txtCop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCop.DefaultText = "";
            this.txtCop.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCop.Location = new System.Drawing.Point(16, 130);
            this.txtCop.MaxLength = 10;
            this.txtCop.Name = "txtCop";
            this.txtCop.PlaceholderText = "";
            this.txtCop.SelectedText = "";
            this.txtCop.Size = new System.Drawing.Size(170, 36);
            this.txtCop.TabIndex = 6;
            //
            // lblTelefono
            //
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblTelefono.Location = new System.Drawing.Point(194, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 17);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono";
            //
            // txtTelefono
            //
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(194, 130);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(170, 36);
            this.txtTelefono.TabIndex = 8;
            //
            // lblEspecialidad
            //
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblEspecialidad.Location = new System.Drawing.Point(16, 174);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(91, 17);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad *";
            //
            // cboEspecialidad
            //
            this.cboEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.cboEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboEspecialidad.ItemHeight = 30;
            this.cboEspecialidad.Location = new System.Drawing.Point(16, 194);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(348, 36);
            this.cboEspecialidad.TabIndex = 10;
            //
            // chkActivo
            //
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkActivo.Location = new System.Drawing.Point(16, 244);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 19);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Activo";
            //
            // btnNuevoOdontologo
            //
            this.btnNuevoOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoOdontologo.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnNuevoOdontologo.BorderRadius = 6;
            this.btnNuevoOdontologo.BorderThickness = 1;
            this.btnNuevoOdontologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoOdontologo.FillColor = System.Drawing.Color.White;
            this.btnNuevoOdontologo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevoOdontologo.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnNuevoOdontologo.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnNuevoOdontologo.Location = new System.Drawing.Point(16, 282);
            this.btnNuevoOdontologo.Name = "btnNuevoOdontologo";
            this.btnNuevoOdontologo.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoOdontologo.TabIndex = 12;
            this.btnNuevoOdontologo.Text = "Nuevo";
            this.btnNuevoOdontologo.Click += new System.EventHandler(this.btnNuevoOdontologo_Click);
            //
            // btnEliminarOdontologo
            //
            this.btnEliminarOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarOdontologo.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnEliminarOdontologo.BorderRadius = 6;
            this.btnEliminarOdontologo.BorderThickness = 1;
            this.btnEliminarOdontologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarOdontologo.FillColor = System.Drawing.Color.White;
            this.btnEliminarOdontologo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEliminarOdontologo.ForeColor = System.Drawing.Color.FromArgb(207, 64, 64);
            this.btnEliminarOdontologo.HoverState.FillColor = System.Drawing.Color.FromArgb(252, 235, 235);
            this.btnEliminarOdontologo.Location = new System.Drawing.Point(124, 282);
            this.btnEliminarOdontologo.Name = "btnEliminarOdontologo";
            this.btnEliminarOdontologo.Size = new System.Drawing.Size(100, 34);
            this.btnEliminarOdontologo.TabIndex = 13;
            this.btnEliminarOdontologo.Text = "Eliminar";
            this.btnEliminarOdontologo.Click += new System.EventHandler(this.btnEliminarOdontologo_Click);
            //
            // btnGuardarOdontologo
            //
            this.btnGuardarOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarOdontologo.BorderRadius = 6;
            this.btnGuardarOdontologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarOdontologo.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnGuardarOdontologo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarOdontologo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarOdontologo.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnGuardarOdontologo.Location = new System.Drawing.Point(232, 282);
            this.btnGuardarOdontologo.Name = "btnGuardarOdontologo";
            this.btnGuardarOdontologo.Size = new System.Drawing.Size(132, 34);
            this.btnGuardarOdontologo.TabIndex = 14;
            this.btnGuardarOdontologo.Text = "Guardar";
            this.btnGuardarOdontologo.Click += new System.EventHandler(this.btnGuardarOdontologo_Click);
            //
            // pnlTablaOdontologos
            //
            this.pnlTablaOdontologos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlTablaOdontologos.BackColor = System.Drawing.Color.Transparent;
            this.pnlTablaOdontologos.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlTablaOdontologos.BorderRadius = 8;
            this.pnlTablaOdontologos.BorderThickness = 1;
            this.pnlTablaOdontologos.Controls.Add(this.dgvOdontologos);
            this.pnlTablaOdontologos.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlTablaOdontologos.Location = new System.Drawing.Point(400, 12);
            this.pnlTablaOdontologos.Name = "pnlTablaOdontologos";
            this.pnlTablaOdontologos.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pnlTablaOdontologos.Size = new System.Drawing.Size(716, 576);
            this.pnlTablaOdontologos.TabIndex = 1;
            //
            // dgvOdontologos
            //
            this.dgvOdontologos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdontologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colOdontologo,
            this.colCop,
            this.colEspecialidad,
            this.colEstado});
            this.dgvOdontologos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdontologos.Location = new System.Drawing.Point(0, 0);
            this.dgvOdontologos.Name = "dgvOdontologos";
            this.dgvOdontologos.ReadOnly = true;
            this.dgvOdontologos.RowHeadersVisible = false;
            this.dgvOdontologos.Size = new System.Drawing.Size(714, 568);
            this.dgvOdontologos.TabIndex = 0;
            this.dgvOdontologos.SelectionChanged += new System.EventHandler(this.dgvOdontologos_SelectionChanged);
            //
            // colCodigo
            //
            this.colCodigo.FillWeight = 50F;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            //
            // colOdontologo
            //
            this.colOdontologo.FillWeight = 150F;
            this.colOdontologo.HeaderText = "Odontólogo";
            this.colOdontologo.Name = "colOdontologo";
            this.colOdontologo.ReadOnly = true;
            //
            // colCop
            //
            this.colCop.FillWeight = 60F;
            this.colCop.HeaderText = "N.° COP";
            this.colCop.Name = "colCop";
            this.colCop.ReadOnly = true;
            //
            // colEspecialidad
            //
            this.colEspecialidad.FillWeight = 100F;
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.ReadOnly = true;
            //
            // colEstado
            //
            this.colEstado.FillWeight = 60F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            //
            // pnlDatosTratamiento
            //
            this.pnlDatosTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosTratamiento.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlDatosTratamiento.BorderRadius = 10;
            this.pnlDatosTratamiento.BorderThickness = 1;
            this.pnlDatosTratamiento.Controls.Add(this.btnGuardarTratamiento);
            this.pnlDatosTratamiento.Controls.Add(this.btnEliminarTratamiento);
            this.pnlDatosTratamiento.Controls.Add(this.btnNuevoTratamiento);
            this.pnlDatosTratamiento.Controls.Add(this.txtDescripcion);
            this.pnlDatosTratamiento.Controls.Add(this.lblDescripcion);
            this.pnlDatosTratamiento.Controls.Add(this.nudDuracion);
            this.pnlDatosTratamiento.Controls.Add(this.lblDuracion);
            this.pnlDatosTratamiento.Controls.Add(this.txtPrecio);
            this.pnlDatosTratamiento.Controls.Add(this.lblPrecio);
            this.pnlDatosTratamiento.Controls.Add(this.txtNombreTratamiento);
            this.pnlDatosTratamiento.Controls.Add(this.lblNombreTratamiento);
            this.pnlDatosTratamiento.Controls.Add(this.lblDatosTratamiento);
            this.pnlDatosTratamiento.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlDatosTratamiento.Location = new System.Drawing.Point(4, 12);
            this.pnlDatosTratamiento.Name = "pnlDatosTratamiento";
            this.pnlDatosTratamiento.Size = new System.Drawing.Size(380, 332);
            this.pnlDatosTratamiento.TabIndex = 0;
            //
            // lblDatosTratamiento
            //
            this.lblDatosTratamiento.AutoSize = true;
            this.lblDatosTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosTratamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDatosTratamiento.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblDatosTratamiento.Location = new System.Drawing.Point(16, 14);
            this.lblDatosTratamiento.Name = "lblDatosTratamiento";
            this.lblDatosTratamiento.Size = new System.Drawing.Size(136, 17);
            this.lblDatosTratamiento.TabIndex = 0;
            this.lblDatosTratamiento.Text = "Datos del tratamiento";
            //
            // lblNombreTratamiento
            //
            this.lblNombreTratamiento.AutoSize = true;
            this.lblNombreTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreTratamiento.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblNombreTratamiento.Location = new System.Drawing.Point(16, 46);
            this.lblNombreTratamiento.Name = "lblNombreTratamiento";
            this.lblNombreTratamiento.Size = new System.Drawing.Size(52, 17);
            this.lblNombreTratamiento.TabIndex = 1;
            this.lblNombreTratamiento.Text = "Nombre *";
            //
            // txtNombreTratamiento
            //
            this.txtNombreTratamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreTratamiento.DefaultText = "";
            this.txtNombreTratamiento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombreTratamiento.Location = new System.Drawing.Point(16, 66);
            this.txtNombreTratamiento.Name = "txtNombreTratamiento";
            this.txtNombreTratamiento.PlaceholderText = "";
            this.txtNombreTratamiento.SelectedText = "";
            this.txtNombreTratamiento.Size = new System.Drawing.Size(348, 36);
            this.txtNombreTratamiento.TabIndex = 2;
            //
            // lblPrecio
            //
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPrecio.Location = new System.Drawing.Point(16, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(84, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio (S/) *";
            //
            // txtPrecio
            //
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(16, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(170, 36);
            this.txtPrecio.TabIndex = 4;
            //
            // lblDuracion
            //
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.BackColor = System.Drawing.Color.Transparent;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblDuracion.Location = new System.Drawing.Point(194, 110);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(91, 17);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración (min)";
            //
            // nudDuracion
            //
            this.nudDuracion.BackColor = System.Drawing.Color.Transparent;
            this.nudDuracion.BorderRadius = 6;
            this.nudDuracion.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.nudDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDuracion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.nudDuracion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudDuracion.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.nudDuracion.Increment = new decimal(new int[] { 15, 0, 0, 0});
            this.nudDuracion.Location = new System.Drawing.Point(194, 130);
            this.nudDuracion.Maximum = new decimal(new int[] { 600, 0, 0, 0});
            this.nudDuracion.Minimum = new decimal(new int[] { 5, 0, 0, 0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(170, 36);
            this.nudDuracion.TabIndex = 6;
            this.nudDuracion.UpDownButtonFillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.nudDuracion.UpDownButtonForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.nudDuracion.Value = new decimal(new int[] { 45, 0, 0, 0});
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblDescripcion.Location = new System.Drawing.Point(16, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(71, 17);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(16, 194);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(348, 72);
            this.txtDescripcion.TabIndex = 8;
            //
            // btnNuevoTratamiento
            //
            this.btnNuevoTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoTratamiento.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnNuevoTratamiento.BorderRadius = 6;
            this.btnNuevoTratamiento.BorderThickness = 1;
            this.btnNuevoTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTratamiento.FillColor = System.Drawing.Color.White;
            this.btnNuevoTratamiento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevoTratamiento.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnNuevoTratamiento.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnNuevoTratamiento.Location = new System.Drawing.Point(16, 282);
            this.btnNuevoTratamiento.Name = "btnNuevoTratamiento";
            this.btnNuevoTratamiento.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoTratamiento.TabIndex = 9;
            this.btnNuevoTratamiento.Text = "Nuevo";
            this.btnNuevoTratamiento.Click += new System.EventHandler(this.btnNuevoTratamiento_Click);
            //
            // btnEliminarTratamiento
            //
            this.btnEliminarTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTratamiento.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnEliminarTratamiento.BorderRadius = 6;
            this.btnEliminarTratamiento.BorderThickness = 1;
            this.btnEliminarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTratamiento.FillColor = System.Drawing.Color.White;
            this.btnEliminarTratamiento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEliminarTratamiento.ForeColor = System.Drawing.Color.FromArgb(207, 64, 64);
            this.btnEliminarTratamiento.HoverState.FillColor = System.Drawing.Color.FromArgb(252, 235, 235);
            this.btnEliminarTratamiento.Location = new System.Drawing.Point(124, 282);
            this.btnEliminarTratamiento.Name = "btnEliminarTratamiento";
            this.btnEliminarTratamiento.Size = new System.Drawing.Size(100, 34);
            this.btnEliminarTratamiento.TabIndex = 10;
            this.btnEliminarTratamiento.Text = "Eliminar";
            this.btnEliminarTratamiento.Click += new System.EventHandler(this.btnEliminarTratamiento_Click);
            //
            // btnGuardarTratamiento
            //
            this.btnGuardarTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTratamiento.BorderRadius = 6;
            this.btnGuardarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTratamiento.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnGuardarTratamiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarTratamiento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTratamiento.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnGuardarTratamiento.Location = new System.Drawing.Point(232, 282);
            this.btnGuardarTratamiento.Name = "btnGuardarTratamiento";
            this.btnGuardarTratamiento.Size = new System.Drawing.Size(132, 34);
            this.btnGuardarTratamiento.TabIndex = 11;
            this.btnGuardarTratamiento.Text = "Guardar";
            this.btnGuardarTratamiento.Click += new System.EventHandler(this.btnGuardarTratamiento_Click);
            //
            // pnlTablaTratamientos
            //
            this.pnlTablaTratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlTablaTratamientos.BackColor = System.Drawing.Color.Transparent;
            this.pnlTablaTratamientos.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlTablaTratamientos.BorderRadius = 8;
            this.pnlTablaTratamientos.BorderThickness = 1;
            this.pnlTablaTratamientos.Controls.Add(this.dgvTratamientos);
            this.pnlTablaTratamientos.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlTablaTratamientos.Location = new System.Drawing.Point(400, 12);
            this.pnlTablaTratamientos.Name = "pnlTablaTratamientos";
            this.pnlTablaTratamientos.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pnlTablaTratamientos.Size = new System.Drawing.Size(716, 576);
            this.pnlTablaTratamientos.TabIndex = 1;
            //
            // dgvTratamientos
            //
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoTratamiento,
            this.colTratamiento,
            this.colDuracion,
            this.colPrecio});
            this.dgvTratamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTratamientos.Location = new System.Drawing.Point(0, 0);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.RowHeadersVisible = false;
            this.dgvTratamientos.Size = new System.Drawing.Size(714, 568);
            this.dgvTratamientos.TabIndex = 0;
            this.dgvTratamientos.SelectionChanged += new System.EventHandler(this.dgvTratamientos_SelectionChanged);
            //
            // colCodigoTratamiento
            //
            this.colCodigoTratamiento.FillWeight = 50F;
            this.colCodigoTratamiento.HeaderText = "Código";
            this.colCodigoTratamiento.Name = "colCodigoTratamiento";
            this.colCodigoTratamiento.ReadOnly = true;
            //
            // colTratamiento
            //
            this.colTratamiento.FillWeight = 170F;
            this.colTratamiento.HeaderText = "Tratamiento";
            this.colTratamiento.Name = "colTratamiento";
            this.colTratamiento.ReadOnly = true;
            //
            // colDuracion
            //
            this.colDuracion.FillWeight = 60F;
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            //
            // colPrecio
            //
            this.colPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.FillWeight = 70F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            //
            // pnlDatosUsuario
            //
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosUsuario.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlDatosUsuario.BorderRadius = 10;
            this.pnlDatosUsuario.BorderThickness = 1;
            this.pnlDatosUsuario.Controls.Add(this.btnGuardarUsuario);
            this.pnlDatosUsuario.Controls.Add(this.btnDesactivarUsuario);
            this.pnlDatosUsuario.Controls.Add(this.btnNuevoUsuario);
            this.pnlDatosUsuario.Controls.Add(this.chkUsuarioActivo);
            this.pnlDatosUsuario.Controls.Add(this.cboOdontologoVinculado);
            this.pnlDatosUsuario.Controls.Add(this.lblOdontologoVinculado);
            this.pnlDatosUsuario.Controls.Add(this.txtContrasena);
            this.pnlDatosUsuario.Controls.Add(this.lblContrasena);
            this.pnlDatosUsuario.Controls.Add(this.cboRol);
            this.pnlDatosUsuario.Controls.Add(this.lblRol);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.txtNombreCompleto);
            this.pnlDatosUsuario.Controls.Add(this.lblNombreCompleto);
            this.pnlDatosUsuario.Controls.Add(this.lblNuevoUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblDatosUsuario);
            this.pnlDatosUsuario.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(4, 12);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(380, 312);
            this.pnlDatosUsuario.TabIndex = 0;
            //
            // lblDatosUsuario
            //
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDatosUsuario.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblDatosUsuario.Location = new System.Drawing.Point(16, 14);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(110, 17);
            this.lblDatosUsuario.TabIndex = 0;
            this.lblDatosUsuario.Text = "Datos del usuario";
            //
            // lblNuevoUsuario
            //
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(241, 235, 250);
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(122, 79, 181);
            this.lblNuevoUsuario.Location = new System.Drawing.Point(150, 17);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblNuevoUsuario.Size = new System.Drawing.Size(48, 14);
            this.lblNuevoUsuario.TabIndex = 1;
            this.lblNuevoUsuario.Text = "NUEVO";
            //
            // lblNombreCompleto
            //
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblNombreCompleto.Location = new System.Drawing.Point(16, 46);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(110, 17);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "Nombre completo *";
            //
            // txtNombreCompleto
            //
            this.txtNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCompleto.DefaultText = "";
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(16, 66);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.PlaceholderText = "";
            this.txtNombreCompleto.SelectedText = "";
            this.txtNombreCompleto.Size = new System.Drawing.Size(348, 36);
            this.txtNombreCompleto.TabIndex = 3;
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblUsuario.Location = new System.Drawing.Point(16, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario *";
            //
            // txtUsuario
            //
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(16, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(170, 36);
            this.txtUsuario.TabIndex = 5;
            //
            // lblRol
            //
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblRol.Location = new System.Drawing.Point(194, 110);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 17);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol *";
            //
            // cboRol
            //
            this.cboRol.BackColor = System.Drawing.Color.Transparent;
            this.cboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboRol.ItemHeight = 30;
            this.cboRol.Location = new System.Drawing.Point(194, 130);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(170, 36);
            this.cboRol.TabIndex = 7;
            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblContrasena.Location = new System.Drawing.Point(16, 174);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(78, 17);
            this.lblContrasena.TabIndex = 8;
            this.lblContrasena.Text = "Contraseña *";
            //
            // txtContrasena
            //
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.DefaultText = "";
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtContrasena.Location = new System.Drawing.Point(16, 194);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PlaceholderText = "";
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.Size = new System.Drawing.Size(170, 36);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.UseSystemPasswordChar = true;
            //
            // lblOdontologoVinculado
            //
            this.lblOdontologoVinculado.AutoSize = true;
            this.lblOdontologoVinculado.BackColor = System.Drawing.Color.Transparent;
            this.lblOdontologoVinculado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdontologoVinculado.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblOdontologoVinculado.Location = new System.Drawing.Point(194, 174);
            this.lblOdontologoVinculado.Name = "lblOdontologoVinculado";
            this.lblOdontologoVinculado.Size = new System.Drawing.Size(130, 17);
            this.lblOdontologoVinculado.TabIndex = 10;
            this.lblOdontologoVinculado.Text = "Odontólogo vinculado";
            //
            // cboOdontologoVinculado
            //
            this.cboOdontologoVinculado.BackColor = System.Drawing.Color.Transparent;
            this.cboOdontologoVinculado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOdontologoVinculado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOdontologoVinculado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboOdontologoVinculado.ItemHeight = 30;
            this.cboOdontologoVinculado.Location = new System.Drawing.Point(194, 194);
            this.cboOdontologoVinculado.Name = "cboOdontologoVinculado";
            this.cboOdontologoVinculado.Size = new System.Drawing.Size(170, 36);
            this.cboOdontologoVinculado.TabIndex = 11;
            //
            // chkUsuarioActivo
            //
            this.chkUsuarioActivo.AutoSize = true;
            this.chkUsuarioActivo.Checked = true;
            this.chkUsuarioActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkUsuarioActivo.Location = new System.Drawing.Point(16, 242);
            this.chkUsuarioActivo.Name = "chkUsuarioActivo";
            this.chkUsuarioActivo.Size = new System.Drawing.Size(62, 19);
            this.chkUsuarioActivo.TabIndex = 12;
            this.chkUsuarioActivo.Text = "Activo";
            //
            // btnNuevoUsuario
            //
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoUsuario.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnNuevoUsuario.BorderRadius = 6;
            this.btnNuevoUsuario.BorderThickness = 1;
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FillColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnNuevoUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnNuevoUsuario.Location = new System.Drawing.Point(16, 266);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoUsuario.TabIndex = 13;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            //
            // btnDesactivarUsuario
            //
            this.btnDesactivarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnDesactivarUsuario.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnDesactivarUsuario.BorderRadius = 6;
            this.btnDesactivarUsuario.BorderThickness = 1;
            this.btnDesactivarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarUsuario.FillColor = System.Drawing.Color.White;
            this.btnDesactivarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDesactivarUsuario.ForeColor = System.Drawing.Color.FromArgb(207, 64, 64);
            this.btnDesactivarUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(252, 235, 235);
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(124, 266);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(100, 34);
            this.btnDesactivarUsuario.TabIndex = 14;
            this.btnDesactivarUsuario.Text = "Desactivar";
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);
            //
            // btnGuardarUsuario
            //
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarUsuario.BorderRadius = 6;
            this.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUsuario.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnGuardarUsuario.Location = new System.Drawing.Point(232, 266);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(132, 34);
            this.btnGuardarUsuario.TabIndex = 15;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            //
            // pnlTablaUsuarios
            //
            this.pnlTablaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlTablaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pnlTablaUsuarios.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlTablaUsuarios.BorderRadius = 8;
            this.pnlTablaUsuarios.BorderThickness = 1;
            this.pnlTablaUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlTablaUsuarios.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlTablaUsuarios.Location = new System.Drawing.Point(400, 12);
            this.pnlTablaUsuarios.Name = "pnlTablaUsuarios";
            this.pnlTablaUsuarios.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pnlTablaUsuarios.Size = new System.Drawing.Size(716, 576);
            this.pnlTablaUsuarios.TabIndex = 1;
            //
            // dgvUsuarios
            //
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario,
            this.colNombre,
            this.colRol,
            this.colUltimoIngreso,
            this.colEstadoUsuario});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(714, 568);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            //
            // colUsuario
            //
            this.colUsuario.FillWeight = 60F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            //
            // colNombre
            //
            this.colNombre.FillWeight = 150F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            //
            // colRol
            //
            this.colRol.FillWeight = 80F;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            //
            // colUltimoIngreso
            //
            this.colUltimoIngreso.FillWeight = 90F;
            this.colUltimoIngreso.HeaderText = "Último ingreso";
            this.colUltimoIngreso.Name = "colUltimoIngreso";
            this.colUltimoIngreso.ReadOnly = true;
            //
            // colEstadoUsuario
            //
            this.colEstadoUsuario.FillWeight = 60F;
            this.colEstadoUsuario.HeaderText = "Estado";
            this.colEstadoUsuario.Name = "colEstadoUsuario";
            this.colEstadoUsuario.ReadOnly = true;
            //
            // frmMantenimiento
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.ClientSize = new System.Drawing.Size(1168, 726);
            this.Controls.Add(this.tabMantenimiento);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimiento";
            this.Text = "DentoTacna — Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlTablaUsuarios.ResumeLayout(false);
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.pnlTablaTratamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.pnlDatosTratamiento.ResumeLayout(false);
            this.pnlDatosTratamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).EndInit();
            this.pnlTablaOdontologos.ResumeLayout(false);
            this.pnlDatosOdontologo.ResumeLayout(false);
            this.pnlDatosOdontologo.PerformLayout();
            this.tabUsuarios.ResumeLayout(false);
            this.tabTratamientos.ResumeLayout(false);
            this.tabOdontologos.ResumeLayout(false);
            this.tabMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2TabControl tabMantenimiento;
        private System.Windows.Forms.TabPage tabOdontologos;
        private System.Windows.Forms.TabPage tabTratamientos;
        private System.Windows.Forms.TabPage tabUsuarios;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosOdontologo;
        private System.Windows.Forms.Label lblDatosOdontologo;
        private System.Windows.Forms.Label lblNombres;
        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label lblCop;
        private Guna.UI2.WinForms.Guna2TextBox txtCop;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label lblEspecialidad;
        private Guna.UI2.WinForms.Guna2ComboBox cboEspecialidad;
        private Guna.UI2.WinForms.Guna2CheckBox chkActivo;
        private Guna.UI2.WinForms.Guna2Button btnNuevoOdontologo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarOdontologo;
        private Guna.UI2.WinForms.Guna2Button btnGuardarOdontologo;
        private Guna.UI2.WinForms.Guna2Panel pnlTablaOdontologos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOdontologos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosTratamiento;
        private System.Windows.Forms.Label lblDatosTratamiento;
        private System.Windows.Forms.Label lblNombreTratamiento;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreTratamiento;
        private System.Windows.Forms.Label lblPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label lblDuracion;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2Button btnNuevoTratamiento;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTratamiento;
        private Guna.UI2.WinForms.Guna2Button btnGuardarTratamiento;
        private Guna.UI2.WinForms.Guna2Panel pnlTablaTratamientos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosUsuario;
        private System.Windows.Forms.Label lblDatosUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label lblRol;
        private Guna.UI2.WinForms.Guna2ComboBox cboRol;
        private System.Windows.Forms.Label lblContrasena;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasena;
        private System.Windows.Forms.Label lblOdontologoVinculado;
        private Guna.UI2.WinForms.Guna2ComboBox cboOdontologoVinculado;
        private Guna.UI2.WinForms.Guna2CheckBox chkUsuarioActivo;
        private Guna.UI2.WinForms.Guna2Button btnNuevoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnDesactivarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnGuardarUsuario;
        private Guna.UI2.WinForms.Guna2Panel pnlTablaUsuarios;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltimoIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoUsuario;
    }
}
