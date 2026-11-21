namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new Guna.UI2.WinForms.Guna2Panel();
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
            this.dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHintCitas = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(41, 25);
            this.lblTitulo.Text = "Citas";
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
            this.lblSubtitulo.Size = new System.Drawing.Size(257, 15);
            this.lblSubtitulo.Text = "Registrar, reprogramar y cancelar citas";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // pnlDatosCita
            // 
            this.pnlDatosCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDatosCita.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosCita.BorderRadius = 10;
            this.pnlDatosCita.Controls.Add(this.btnGuardar);
            this.pnlDatosCita.Controls.Add(this.btnEliminar);
            this.pnlDatosCita.Controls.Add(this.btnNuevo);
            this.pnlDatosCita.Controls.Add(this.txtObservaciones);
            this.pnlDatosCita.Controls.Add(this.lblObservaciones);
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
            this.pnlDatosCita.Location = new System.Drawing.Point(20, 80);
            this.pnlDatosCita.Name = "pnlDatosCita";
            this.pnlDatosCita.Size = new System.Drawing.Size(380, 556);
            this.pnlDatosCita.TabIndex = 1;
            // 
            // lblDatosCita
            // 
            this.lblDatosCita.AutoSize = true;
            this.lblDatosCita.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblDatosCita.Location = new System.Drawing.Point(16, 14);
            this.lblDatosCita.Name = "lblDatosCita";
            this.lblDatosCita.Size = new System.Drawing.Size(124, 20);
            this.lblDatosCita.Text = "Datos de la cita";
            this.lblDatosCita.TabIndex = 0;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblPaciente.Location = new System.Drawing.Point(16, 52);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(69, 15);
            this.lblPaciente.Text = "Paciente *";
            this.lblPaciente.TabIndex = 1;
            // 
            // cboPaciente
            // 
            this.cboPaciente.BackColor = System.Drawing.Color.Transparent;
            this.cboPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboPaciente.BorderRadius = 8;
            this.cboPaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboPaciente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboPaciente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboPaciente.ItemHeight = 30;
            this.cboPaciente.Location = new System.Drawing.Point(16, 72);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(348, 36);
            this.cboPaciente.TabIndex = 2;
            // 
            // lblOdontologo
            // 
            this.lblOdontologo.AutoSize = true;
            this.lblOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.lblOdontologo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdontologo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblOdontologo.Location = new System.Drawing.Point(16, 116);
            this.lblOdontologo.Name = "lblOdontologo";
            this.lblOdontologo.Size = new System.Drawing.Size(82, 15);
            this.lblOdontologo.Text = "Odontólogo *";
            this.lblOdontologo.TabIndex = 3;
            // 
            // cboOdontologo
            // 
            this.cboOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.cboOdontologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboOdontologo.BorderRadius = 8;
            this.cboOdontologo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOdontologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOdontologo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboOdontologo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboOdontologo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOdontologo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboOdontologo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboOdontologo.ItemHeight = 30;
            this.cboOdontologo.Location = new System.Drawing.Point(16, 136);
            this.cboOdontologo.Name = "cboOdontologo";
            this.cboOdontologo.Size = new System.Drawing.Size(348, 36);
            this.cboOdontologo.TabIndex = 4;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblTratamiento.Location = new System.Drawing.Point(16, 180);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(88, 15);
            this.lblTratamiento.Text = "Tratamiento *";
            this.lblTratamiento.TabIndex = 5;
            // 
            // cboTratamiento
            // 
            this.cboTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.cboTratamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboTratamiento.BorderRadius = 8;
            this.cboTratamiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTratamiento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboTratamiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboTratamiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboTratamiento.ItemHeight = 30;
            this.cboTratamiento.Location = new System.Drawing.Point(16, 200);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(348, 36);
            this.cboTratamiento.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblFecha.Location = new System.Drawing.Point(16, 244);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 15);
            this.lblFecha.Text = "Fecha *";
            this.lblFecha.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpFecha.BorderRadius = 8;
            this.dtpFecha.BorderThickness = 1;
            this.dtpFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpFecha.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpFecha.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpFecha.Location = new System.Drawing.Point(16, 264);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(168, 36);
            this.dtpFecha.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblHora.Location = new System.Drawing.Point(196, 244);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 15);
            this.lblHora.Text = "Hora *";
            this.lblHora.TabIndex = 9;
            // 
            // dtpHora
            // 
            this.dtpHora.BackColor = System.Drawing.Color.Transparent;
            this.dtpHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpHora.BorderRadius = 8;
            this.dtpHora.BorderThickness = 1;
            this.dtpHora.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpHora.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpHora.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.FillColor = System.Drawing.Color.White;
            this.dtpHora.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpHora.Location = new System.Drawing.Point(196, 264);
            this.dtpHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(168, 36);
            this.dtpHora.Value = new System.DateTime(2026, 11, 20, 9, 0, 0, 0);
            this.dtpHora.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblEstado.Location = new System.Drawing.Point(16, 308);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 15);
            this.lblEstado.Text = "Estado";
            this.lblEstado.TabIndex = 11;
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.Transparent;
            this.cboEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboEstado.BorderRadius = 8;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboEstado.ItemHeight = 30;
            this.cboEstado.Items.AddRange(new object[] {
            "Programada",
            "Confirmada",
            "En consulta",
            "Atendida",
            "Cancelada"});
            this.cboEstado.Location = new System.Drawing.Point(16, 328);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(348, 36);
            this.cboEstado.StartIndex = 0;
            this.cboEstado.TabIndex = 12;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblObservaciones.Location = new System.Drawing.Point(16, 372);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(88, 15);
            this.lblObservaciones.Text = "Observaciones";
            this.lblObservaciones.TabIndex = 13;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.txtObservaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtObservaciones.BorderRadius = 8;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.DefaultText = "";
            this.txtObservaciones.FillColor = System.Drawing.Color.White;
            this.txtObservaciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtObservaciones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtObservaciones.Location = new System.Drawing.Point(16, 392);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtObservaciones.PlaceholderText = "Indicaciones, alergias o comentarios de la cita";
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(348, 90);
            this.txtObservaciones.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnNuevo.BorderRadius = 8;
            this.btnNuevo.BorderThickness = 1;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FillColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnNuevo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnNuevo.Location = new System.Drawing.Point(22, 500);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 36);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnEliminar.BorderRadius = 8;
            this.btnEliminar.BorderThickness = 1;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FillColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEliminar.Location = new System.Drawing.Point(138, 500);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnGuardar.Location = new System.Drawing.Point(254, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TabIndex = 17;
            // 
            // lblFiltroFecha
            // 
            this.lblFiltroFecha.AutoSize = true;
            this.lblFiltroFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblFiltroFecha.Location = new System.Drawing.Point(416, 90);
            this.lblFiltroFecha.Name = "lblFiltroFecha";
            this.lblFiltroFecha.Size = new System.Drawing.Size(36, 15);
            this.lblFiltroFecha.Text = "Fecha";
            this.lblFiltroFecha.TabIndex = 2;
            // 
            // dtpFiltroFecha
            // 
            this.dtpFiltroFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFiltroFecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpFiltroFecha.BorderRadius = 8;
            this.dtpFiltroFecha.BorderThickness = 1;
            this.dtpFiltroFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpFiltroFecha.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpFiltroFecha.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpFiltroFecha.FillColor = System.Drawing.Color.White;
            this.dtpFiltroFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpFiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpFiltroFecha.Location = new System.Drawing.Point(460, 80);
            this.dtpFiltroFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFiltroFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(150, 36);
            this.dtpFiltroFecha.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpFiltroFecha.TabIndex = 3;
            // 
            // cboFiltroOdontologo
            // 
            this.cboFiltroOdontologo.BackColor = System.Drawing.Color.Transparent;
            this.cboFiltroOdontologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboFiltroOdontologo.BorderRadius = 8;
            this.cboFiltroOdontologo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFiltroOdontologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroOdontologo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroOdontologo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroOdontologo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroOdontologo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboFiltroOdontologo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroOdontologo.ItemHeight = 30;
            this.cboFiltroOdontologo.Items.AddRange(new object[] {
            "Todos los odontólogos"});
            this.cboFiltroOdontologo.Location = new System.Drawing.Point(620, 80);
            this.cboFiltroOdontologo.Name = "cboFiltroOdontologo";
            this.cboFiltroOdontologo.Size = new System.Drawing.Size(200, 36);
            this.cboFiltroOdontologo.StartIndex = 0;
            this.cboFiltroOdontologo.TabIndex = 4;
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.BackColor = System.Drawing.Color.Transparent;
            this.cboFiltroEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboFiltroEstado.BorderRadius = 8;
            this.cboFiltroEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboFiltroEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboFiltroEstado.ItemHeight = 30;
            this.cboFiltroEstado.Items.AddRange(new object[] {
            "Todos los estados",
            "Programada",
            "Confirmada",
            "En consulta",
            "Atendida",
            "Cancelada"});
            this.cboFiltroEstado.Location = new System.Drawing.Point(830, 80);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(160, 36);
            this.cboFiltroEstado.StartIndex = 0;
            this.cboFiltroEstado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnBuscar.BorderRadius = 8;
            this.btnBuscar.BorderThickness = 1;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FillColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnBuscar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnBuscar.Location = new System.Drawing.Point(1000, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 36);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 6;
            // 
            // dgvCitas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.ColumnHeadersHeight = 40;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFecha,
            this.colHora,
            this.colPaciente,
            this.colTelefono,
            this.colTratamiento,
            this.colOdontologo,
            this.colEstado});
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitas.EnableHeadersVisualStyles = false;
            this.dgvCitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvCitas.Location = new System.Drawing.Point(416, 126);
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowTemplate.Height = 38;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(702, 480);
            this.dgvCitas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCitas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCitas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvCitas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCitas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCitas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvCitas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvCitas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCitas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.dgvCitas.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCitas.ThemeStyle.ReadOnly = true;
            this.dgvCitas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCitas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCitas.ThemeStyle.RowsStyle.Height = 38;
            this.dgvCitas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvCitas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCitas.TabIndex = 7;
            // 
            // colNumero
            // 
            this.colNumero.FillWeight = 50F;
            this.colNumero.HeaderText = "N.°";
            this.colNumero.Name = "colNumero";
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 75F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colHora
            // 
            this.colHora.FillWeight = 55F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // colPaciente
            // 
            this.colPaciente.FillWeight = 150F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 85F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colTratamiento
            // 
            this.colTratamiento.FillWeight = 130F;
            this.colTratamiento.HeaderText = "Tratamiento";
            this.colTratamiento.Name = "colTratamiento";
            // 
            // colOdontologo
            // 
            this.colOdontologo.FillWeight = 110F;
            this.colOdontologo.HeaderText = "Odontólogo";
            this.colOdontologo.Name = "colOdontologo";
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 85F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // lblHintCitas
            // 
            this.lblHintCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHintCitas.AutoSize = true;
            this.lblHintCitas.BackColor = System.Drawing.Color.Transparent;
            this.lblHintCitas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblHintCitas.Location = new System.Drawing.Point(416, 618);
            this.lblHintCitas.Name = "lblHintCitas";
            this.lblHintCitas.Size = new System.Drawing.Size(192, 15);
            this.lblHintCitas.Text = "Doble clic para abrir la cita";
            this.lblHintCitas.TabIndex = 8;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.AutoSize = false;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblRegistros.Location = new System.Drawing.Point(918, 616);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(200, 15);
            this.lblRegistros.Text = "0 registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRegistros.TabIndex = 9;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1138, 731);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblHintCitas);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboFiltroEstado);
            this.Controls.Add(this.cboFiltroOdontologo);
            this.Controls.Add(this.dtpFiltroFecha);
            this.Controls.Add(this.lblFiltroFecha);
            this.Controls.Add(this.pnlDatosCita);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentoTacna Smart — Citas";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDatosCita.ResumeLayout(false);
            this.pnlDatosCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblHintCitas;
        private System.Windows.Forms.Label lblRegistros;
    }
}