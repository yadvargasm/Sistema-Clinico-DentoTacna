namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmCitas
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
            this.pnlDatosCita = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatosCita = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cboPaciente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblOdontologo = new System.Windows.Forms.Label();
            this.cboOdontologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.cboTratamiento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlRecordatorio = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.lblNuevoRecordatorio = new System.Windows.Forms.Label();
            this.chkRecordarDiaAntes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMostrarPanel = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFiltroFecha = new System.Windows.Forms.Label();
            this.dtpFiltroFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboFiltroOdontologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboFiltroEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTabla = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHintCitas = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlDatosCita.SuspendLayout();
            this.pnlRecordatorio.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Citas";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblSubtitulo.Location = new System.Drawing.Point(23, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(352, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Agenda: registrar, reprogramar, cancelar y recordar citas";
            //
            // pnlDatosCita
            //
            this.pnlDatosCita.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosCita.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlDatosCita.BorderRadius = 10;
            this.pnlDatosCita.BorderThickness = 1;
            this.pnlDatosCita.Controls.Add(this.btnGuardar);
            this.pnlDatosCita.Controls.Add(this.btnEliminar);
            this.pnlDatosCita.Controls.Add(this.btnNuevo);
            this.pnlDatosCita.Controls.Add(this.txtObservaciones);
            this.pnlDatosCita.Controls.Add(this.lblObservaciones);
            this.pnlDatosCita.Controls.Add(this.pnlRecordatorio);
            this.pnlDatosCita.Controls.Add(this.cboEstado);
            this.pnlDatosCita.Controls.Add(this.lblEstado);
            this.pnlDatosCita.Controls.Add(this.dtpHora);
            this.pnlDatosCita.Controls.Add(this.lblHora);
            this.pnlDatosCita.Controls.Add(this.dtpFecha);
            this.pnlDatosCita.Controls.Add(this.lblFecha);
            this.pnlDatosCita.Controls.Add(this.cboTratamiento);
            this.pnlDatosCita.Controls.Add(this.lblTratamiento);
            this.pnlDatosCita.Controls.Add(this.cboOdontologo);
            this.pnlDatosCita.Controls.Add(this.lblOdontologo);
            this.pnlDatosCita.Controls.Add(this.cboPaciente);
            this.pnlDatosCita.Controls.Add(this.lblPaciente);
            this.pnlDatosCita.Controls.Add(this.lblDatosCita);
            this.pnlDatosCita.FillColor = System.Drawing.Color.White;
            this.pnlDatosCita.Location = new System.Drawing.Point(22, 80);
            this.pnlDatosCita.Name = "pnlDatosCita";
            this.pnlDatosCita.Size = new System.Drawing.Size(380, 616);
            this.pnlDatosCita.TabIndex = 2;
            //
            // lblDatosCita
            //
            this.lblDatosCita.AutoSize = true;
            this.lblDatosCita.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCita.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDatosCita.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblDatosCita.Location = new System.Drawing.Point(16, 14);
            this.lblDatosCita.Name = "lblDatosCita";
            this.lblDatosCita.Size = new System.Drawing.Size(117, 19);
            this.lblDatosCita.TabIndex = 0;
            this.lblDatosCita.Text = "Datos de la cita";
            //
            // lblPaciente
            //
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPaciente.Location = new System.Drawing.Point(16, 46);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(61, 15);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente *";
            //
            // cboPaciente
            //
            this.cboPaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaciente.ItemHeight = 30;
            this.cboPaciente.Location = new System.Drawing.Point(16, 66);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(348, 36);
            this.cboPaciente.TabIndex = 2;
            //
            // lblOdontologo
            //
            this.lblOdontologo.AutoSize = true;
            this.lblOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.lblOdontologo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdontologo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblOdontologo.Location = new System.Drawing.Point(16, 110);
            this.lblOdontologo.Name = "lblOdontologo";
            this.lblOdontologo.Size = new System.Drawing.Size(80, 15);
            this.lblOdontologo.TabIndex = 3;
            this.lblOdontologo.Text = "Odontólogo *";
            //
            // cboOdontologo
            //
            this.cboOdontologo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOdontologo.ItemHeight = 30;
            this.cboOdontologo.Location = new System.Drawing.Point(16, 130);
            this.cboOdontologo.Name = "cboOdontologo";
            this.cboOdontologo.Size = new System.Drawing.Size(348, 36);
            this.cboOdontologo.TabIndex = 4;
            //
            // lblTratamiento
            //
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTratamiento.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblTratamiento.Location = new System.Drawing.Point(16, 174);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(80, 15);
            this.lblTratamiento.TabIndex = 5;
            this.lblTratamiento.Text = "Tratamiento *";
            //
            // cboTratamiento
            //
            this.cboTratamiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTratamiento.ItemHeight = 30;
            this.cboTratamiento.Location = new System.Drawing.Point(16, 194);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(348, 36);
            this.cboTratamiento.TabIndex = 6;
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblFecha.Location = new System.Drawing.Point(16, 238);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha *";
            //
            // dtpFecha
            //
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(16, 258);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(170, 36);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.Value = new System.DateTime(2026, 11, 22, 0, 0, 0, 0);
            //
            // lblHora
            //
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblHora.Location = new System.Drawing.Point(194, 238);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 15);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora *";
            //
            // dtpHora
            //
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(194, 258);
            this.dtpHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(170, 36);
            this.dtpHora.TabIndex = 10;
            this.dtpHora.Value = new System.DateTime(2026, 11, 22, 16, 0, 0, 0);
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblEstado.Location = new System.Drawing.Point(16, 302);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            //
            // cboEstado
            //
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.ItemHeight = 30;
            this.cboEstado.Location = new System.Drawing.Point(16, 322);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(348, 36);
            this.cboEstado.TabIndex = 12;
            //
            // pnlRecordatorio
            //
            this.pnlRecordatorio.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecordatorio.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlRecordatorio.BorderRadius = 8;
            this.pnlRecordatorio.BorderThickness = 1;
            this.pnlRecordatorio.Controls.Add(this.chkMostrarPanel);
            this.pnlRecordatorio.Controls.Add(this.chkRecordarDiaAntes);
            this.pnlRecordatorio.Controls.Add(this.lblNuevoRecordatorio);
            this.pnlRecordatorio.Controls.Add(this.lblRecordatorio);
            this.pnlRecordatorio.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.pnlRecordatorio.Location = new System.Drawing.Point(16, 372);
            this.pnlRecordatorio.Name = "pnlRecordatorio";
            this.pnlRecordatorio.Size = new System.Drawing.Size(348, 88);
            this.pnlRecordatorio.TabIndex = 13;
            //
            // lblRecordatorio
            //
            this.lblRecordatorio.AutoSize = true;
            this.lblRecordatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRecordatorio.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblRecordatorio.Location = new System.Drawing.Point(10, 9);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(89, 17);
            this.lblRecordatorio.TabIndex = 0;
            this.lblRecordatorio.Text = "Recordatorio";
            //
            // lblNuevoRecordatorio
            //
            this.lblNuevoRecordatorio.AutoSize = true;
            this.lblNuevoRecordatorio.BackColor = System.Drawing.Color.FromArgb(241, 235, 250);
            this.lblNuevoRecordatorio.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblNuevoRecordatorio.ForeColor = System.Drawing.Color.FromArgb(122, 79, 181);
            this.lblNuevoRecordatorio.Location = new System.Drawing.Point(104, 11);
            this.lblNuevoRecordatorio.Name = "lblNuevoRecordatorio";
            this.lblNuevoRecordatorio.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblNuevoRecordatorio.Size = new System.Drawing.Size(48, 14);
            this.lblNuevoRecordatorio.TabIndex = 1;
            this.lblNuevoRecordatorio.Text = "NUEVO";
            //
            // chkRecordarDiaAntes
            //
            this.chkRecordarDiaAntes.AutoSize = true;
            this.chkRecordarDiaAntes.Checked = true;
            this.chkRecordarDiaAntes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecordarDiaAntes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRecordarDiaAntes.Location = new System.Drawing.Point(12, 36);
            this.chkRecordarDiaAntes.Name = "chkRecordarDiaAntes";
            this.chkRecordarDiaAntes.Size = new System.Drawing.Size(206, 19);
            this.chkRecordarDiaAntes.TabIndex = 2;
            this.chkRecordarDiaAntes.Text = "Recordar al paciente un día antes";
            //
            // chkMostrarPanel
            //
            this.chkMostrarPanel.AutoSize = true;
            this.chkMostrarPanel.Checked = true;
            this.chkMostrarPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMostrarPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMostrarPanel.Location = new System.Drawing.Point(12, 60);
            this.chkMostrarPanel.Name = "chkMostrarPanel";
            this.chkMostrarPanel.Size = new System.Drawing.Size(232, 19);
            this.chkMostrarPanel.TabIndex = 3;
            this.chkMostrarPanel.Text = "Mostrar en el panel el día de la cita";
            //
            // lblObservaciones
            //
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblObservaciones.Location = new System.Drawing.Point(16, 472);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(84, 15);
            this.lblObservaciones.TabIndex = 14;
            this.lblObservaciones.Text = "Observaciones";
            //
            // txtObservaciones
            //
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.DefaultText = "";
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservaciones.Location = new System.Drawing.Point(16, 492);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PlaceholderText = "";
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(348, 58);
            this.txtObservaciones.TabIndex = 15;
            //
            // btnNuevo
            //
            this.btnNuevo.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnNuevo.BorderRadius = 6;
            this.btnNuevo.BorderThickness = 1;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FillColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnNuevo.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnNuevo.Location = new System.Drawing.Point(16, 564);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 34);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnEliminar.BorderRadius = 6;
            this.btnEliminar.BorderThickness = 1;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FillColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(207, 64, 64);
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(252, 235, 235);
            this.btnEliminar.Location = new System.Drawing.Point(124, 564);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 34);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.BorderRadius = 6;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnGuardar.Location = new System.Drawing.Point(232, 564);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 34);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // lblFiltroFecha
            //
            this.lblFiltroFecha.AutoSize = true;
            this.lblFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblFiltroFecha.Location = new System.Drawing.Point(418, 89);
            this.lblFiltroFecha.Name = "lblFiltroFecha";
            this.lblFiltroFecha.Size = new System.Drawing.Size(40, 17);
            this.lblFiltroFecha.TabIndex = 3;
            this.lblFiltroFecha.Text = "Fecha";
            //
            // dtpFiltroFecha
            //
            this.dtpFiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFecha.Location = new System.Drawing.Point(464, 80);
            this.dtpFiltroFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFiltroFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(150, 36);
            this.dtpFiltroFecha.TabIndex = 4;
            this.dtpFiltroFecha.Value = new System.DateTime(2026, 11, 22, 0, 0, 0, 0);
            //
            // cboFiltroOdontologo
            //
            this.cboFiltroOdontologo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFiltroOdontologo.ItemHeight = 30;
            this.cboFiltroOdontologo.Location = new System.Drawing.Point(622, 80);
            this.cboFiltroOdontologo.Name = "cboFiltroOdontologo";
            this.cboFiltroOdontologo.Size = new System.Drawing.Size(196, 36);
            this.cboFiltroOdontologo.TabIndex = 5;
            //
            // cboFiltroEstado
            //
            this.cboFiltroEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFiltroEstado.ItemHeight = 30;
            this.cboFiltroEstado.Location = new System.Drawing.Point(826, 80);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(170, 36);
            this.cboFiltroEstado.TabIndex = 6;
            //
            // btnBuscar
            //
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnBuscar.BorderRadius = 6;
            this.btnBuscar.BorderThickness = 1;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FillColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnBuscar.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnBuscar.Location = new System.Drawing.Point(1004, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // pnlTabla
            //
            this.pnlTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabla.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabla.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlTabla.BorderRadius = 8;
            this.pnlTabla.BorderThickness = 1;
            this.pnlTabla.Controls.Add(this.dgvCitas);
            this.pnlTabla.FillColor = System.Drawing.Color.White;
            this.pnlTabla.Location = new System.Drawing.Point(418, 126);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pnlTabla.Size = new System.Drawing.Size(728, 540);
            this.pnlTabla.TabIndex = 8;
            //
            // dgvCitas
            //
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFecha,
            this.colHora,
            this.colPaciente,
            this.colTelefono,
            this.colTratamiento,
            this.colOdontologo,
            this.colEstado,
            this.colRecordatorio});
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(1, 4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.Size = new System.Drawing.Size(726, 532);
            this.dgvCitas.TabIndex = 0;
            this.dgvCitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellDoubleClick);
            //
            // colNumero
            //
            this.colNumero.FillWeight = 50F;
            this.colNumero.HeaderText = "N.°";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            //
            // colFecha
            //
            this.colFecha.FillWeight = 70F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            //
            // colHora
            //
            this.colHora.FillWeight = 45F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            //
            // colPaciente
            //
            this.colPaciente.FillWeight = 115F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            this.colPaciente.ReadOnly = true;
            //
            // colTelefono
            //
            this.colTelefono.FillWeight = 80F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            //
            // colTratamiento
            //
            this.colTratamiento.FillWeight = 110F;
            this.colTratamiento.HeaderText = "Tratamiento";
            this.colTratamiento.Name = "colTratamiento";
            this.colTratamiento.ReadOnly = true;
            //
            // colOdontologo
            //
            this.colOdontologo.FillWeight = 85F;
            this.colOdontologo.HeaderText = "Odontólogo";
            this.colOdontologo.Name = "colOdontologo";
            this.colOdontologo.ReadOnly = true;
            //
            // colEstado
            //
            this.colEstado.FillWeight = 90F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            //
            // colRecordatorio
            //
            this.colRecordatorio.FillWeight = 80F;
            this.colRecordatorio.HeaderText = "Recordatorio";
            this.colRecordatorio.Name = "colRecordatorio";
            this.colRecordatorio.ReadOnly = true;
            //
            // lblHintCitas
            //
            this.lblHintCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHintCitas.AutoSize = true;
            this.lblHintCitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHintCitas.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblHintCitas.Location = new System.Drawing.Point(418, 676);
            this.lblHintCitas.Name = "lblHintCitas";
            this.lblHintCitas.Size = new System.Drawing.Size(160, 15);
            this.lblHintCitas.TabIndex = 9;
            this.lblHintCitas.Text = "Doble clic para abrir la cita";
            //
            // lblRegistros
            //
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblRegistros.Location = new System.Drawing.Point(1000, 676);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(146, 15);
            this.lblRegistros.TabIndex = 10;
            this.lblRegistros.Text = "0 registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // frmCitas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.ClientSize = new System.Drawing.Size(1168, 726);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblHintCitas);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboFiltroEstado);
            this.Controls.Add(this.cboFiltroOdontologo);
            this.Controls.Add(this.dtpFiltroFecha);
            this.Controls.Add(this.lblFiltroFecha);
            this.Controls.Add(this.pnlDatosCita);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitas";
            this.Text = "DentoTacna — Citas";
            this.pnlDatosCita.ResumeLayout(false);
            this.pnlDatosCita.PerformLayout();
            this.pnlRecordatorio.ResumeLayout(false);
            this.pnlRecordatorio.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosCita;
        private System.Windows.Forms.Label lblDatosCita;
        private System.Windows.Forms.Label lblPaciente;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaciente;
        private System.Windows.Forms.Label lblOdontologo;
        private Guna.UI2.WinForms.Guna2ComboBox cboOdontologo;
        private System.Windows.Forms.Label lblTratamiento;
        private Guna.UI2.WinForms.Guna2ComboBox cboTratamiento;
        private System.Windows.Forms.Label lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cboEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlRecordatorio;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Label lblNuevoRecordatorio;
        private Guna.UI2.WinForms.Guna2CheckBox chkRecordarDiaAntes;
        private Guna.UI2.WinForms.Guna2CheckBox chkMostrarPanel;
        private System.Windows.Forms.Label lblObservaciones;
        private Guna.UI2.WinForms.Guna2TextBox txtObservaciones;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.Label lblFiltroFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFiltroFecha;
        private Guna.UI2.WinForms.Guna2ComboBox cboFiltroOdontologo;
        private Guna.UI2.WinForms.Guna2ComboBox cboFiltroEstado;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Panel pnlTabla;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordatorio;
        private System.Windows.Forms.Label lblHintCitas;
        private System.Windows.Forms.Label lblRegistros;
    }
}
