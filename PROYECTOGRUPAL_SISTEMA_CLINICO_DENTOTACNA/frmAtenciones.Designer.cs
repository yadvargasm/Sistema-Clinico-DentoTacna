namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmAtenciones
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboFiltroOdontologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAtenciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlRegistrarAtencion = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRegistrarAtencion = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cboPaciente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblOdontologo = new System.Windows.Forms.Label();
            this.cboOdontologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPieza = new System.Windows.Forms.Label();
            this.txtPieza = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.txtProcedimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).BeginInit();
            this.pnlRegistrarAtencion.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(79, 25);
            this.lblTitulo.Text = "Atenciones";
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
            this.lblSubtitulo.Size = new System.Drawing.Size(296, 15);
            this.lblSubtitulo.Text = "Registro clínico de las atenciones realizadas";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblDesde.Location = new System.Drawing.Point(20, 90);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(36, 15);
            this.lblDesde.Text = "Desde";
            this.lblDesde.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.BackColor = System.Drawing.Color.Transparent;
            this.dtpDesde.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpDesde.BorderRadius = 8;
            this.dtpDesde.BorderThickness = 1;
            this.dtpDesde.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpDesde.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpDesde.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpDesde.FillColor = System.Drawing.Color.White;
            this.dtpDesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpDesde.Location = new System.Drawing.Point(66, 80);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(140, 36);
            this.dtpDesde.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblHasta.Location = new System.Drawing.Point(218, 90);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(36, 15);
            this.lblHasta.Text = "Hasta";
            this.lblHasta.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BackColor = System.Drawing.Color.Transparent;
            this.dtpHasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpHasta.BorderRadius = 8;
            this.dtpHasta.BorderThickness = 1;
            this.dtpHasta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.dtpHasta.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpHasta.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.dtpHasta.Location = new System.Drawing.Point(262, 80);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(140, 36);
            this.dtpHasta.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpHasta.TabIndex = 4;
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
            this.cboFiltroOdontologo.Location = new System.Drawing.Point(414, 80);
            this.cboFiltroOdontologo.Name = "cboFiltroOdontologo";
            this.cboFiltroOdontologo.Size = new System.Drawing.Size(210, 36);
            this.cboFiltroOdontologo.StartIndex = 0;
            this.cboFiltroOdontologo.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnBuscar.BorderRadius = 8;
            this.btnBuscar.BorderThickness = 1;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FillColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnBuscar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnBuscar.Location = new System.Drawing.Point(636, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 36);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 6;
            // 
            // dgvAtenciones
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
            this.dgvAtenciones.AllowUserToAddRows = false;
            this.dgvAtenciones.AllowUserToDeleteRows = false;
            this.dgvAtenciones.AllowUserToResizeRows = false;
            this.dgvAtenciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtenciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtenciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtenciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAtenciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAtenciones.ColumnHeadersHeight = 40;
            this.dgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colPaciente,
            this.colOdontologo,
            this.colPieza,
            this.colMotivo,
            this.colDiagnostico,
            this.colProcedimiento});
            this.dgvAtenciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAtenciones.EnableHeadersVisualStyles = false;
            this.dgvAtenciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvAtenciones.Location = new System.Drawing.Point(20, 126);
            this.dgvAtenciones.MultiSelect = false;
            this.dgvAtenciones.Name = "dgvAtenciones";
            this.dgvAtenciones.ReadOnly = true;
            this.dgvAtenciones.RowHeadersVisible = false;
            this.dgvAtenciones.RowTemplate.Height = 38;
            this.dgvAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtenciones.Size = new System.Drawing.Size(742, 480);
            this.dgvAtenciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAtenciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvAtenciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvAtenciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvAtenciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAtenciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvAtenciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvAtenciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAtenciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAtenciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.dgvAtenciones.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAtenciones.ThemeStyle.ReadOnly = true;
            this.dgvAtenciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAtenciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAtenciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAtenciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvAtenciones.ThemeStyle.RowsStyle.Height = 38;
            this.dgvAtenciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvAtenciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvAtenciones.TabIndex = 7;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 70F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colPaciente
            // 
            this.colPaciente.FillWeight = 140F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            // 
            // colOdontologo
            // 
            this.colOdontologo.FillWeight = 105F;
            this.colOdontologo.HeaderText = "Odontólogo";
            this.colOdontologo.Name = "colOdontologo";
            // 
            // colPieza
            // 
            this.colPieza.FillWeight = 45F;
            this.colPieza.HeaderText = "Pieza";
            this.colPieza.Name = "colPieza";
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 100F;
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            // 
            // colDiagnostico
            // 
            this.colDiagnostico.FillWeight = 110F;
            this.colDiagnostico.HeaderText = "Diagnóstico";
            this.colDiagnostico.Name = "colDiagnostico";
            // 
            // colProcedimiento
            // 
            this.colProcedimiento.FillWeight = 120F;
            this.colProcedimiento.HeaderText = "Procedimiento";
            this.colProcedimiento.Name = "colProcedimiento";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.AutoSize = false;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblRegistros.Location = new System.Drawing.Point(562, 616);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(200, 15);
            this.lblRegistros.Text = "0 registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRegistros.TabIndex = 8;
            // 
            // pnlRegistrarAtencion
            // 
            this.pnlRegistrarAtencion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistrarAtencion.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrarAtencion.BorderRadius = 10;
            this.pnlRegistrarAtencion.Controls.Add(this.btnGuardar);
            this.pnlRegistrarAtencion.Controls.Add(this.btnNuevo);
            this.pnlRegistrarAtencion.Controls.Add(this.txtProcedimiento);
            this.pnlRegistrarAtencion.Controls.Add(this.lblProcedimiento);
            this.pnlRegistrarAtencion.Controls.Add(this.txtDiagnostico);
            this.pnlRegistrarAtencion.Controls.Add(this.lblDiagnostico);
            this.pnlRegistrarAtencion.Controls.Add(this.txtMotivo);
            this.pnlRegistrarAtencion.Controls.Add(this.lblMotivo);
            this.pnlRegistrarAtencion.Controls.Add(this.txtPieza);
            this.pnlRegistrarAtencion.Controls.Add(this.lblPieza);
            this.pnlRegistrarAtencion.Controls.Add(this.dtpFecha);
            this.pnlRegistrarAtencion.Controls.Add(this.lblFecha);
            this.pnlRegistrarAtencion.Controls.Add(this.cboOdontologo);
            this.pnlRegistrarAtencion.Controls.Add(this.lblOdontologo);
            this.pnlRegistrarAtencion.Controls.Add(this.cboPaciente);
            this.pnlRegistrarAtencion.Controls.Add(this.lblPaciente);
            this.pnlRegistrarAtencion.Controls.Add(this.lblRegistrarAtencion);
            this.pnlRegistrarAtencion.FillColor = System.Drawing.Color.White;
            this.pnlRegistrarAtencion.Location = new System.Drawing.Point(778, 80);
            this.pnlRegistrarAtencion.Name = "pnlRegistrarAtencion";
            this.pnlRegistrarAtencion.Size = new System.Drawing.Size(340, 556);
            this.pnlRegistrarAtencion.TabIndex = 9;
            // 
            // lblRegistrarAtencion
            // 
            this.lblRegistrarAtencion.AutoSize = true;
            this.lblRegistrarAtencion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarAtencion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarAtencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblRegistrarAtencion.Location = new System.Drawing.Point(16, 14);
            this.lblRegistrarAtencion.Name = "lblRegistrarAtencion";
            this.lblRegistrarAtencion.Size = new System.Drawing.Size(139, 20);
            this.lblRegistrarAtencion.Text = "Registrar atención";
            this.lblRegistrarAtencion.TabIndex = 0;
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
            this.cboPaciente.Size = new System.Drawing.Size(308, 36);
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
            this.cboOdontologo.Size = new System.Drawing.Size(308, 36);
            this.cboOdontologo.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblFecha.Location = new System.Drawing.Point(16, 180);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 15);
            this.lblFecha.Text = "Fecha *";
            this.lblFecha.TabIndex = 5;
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
            this.dtpFecha.Location = new System.Drawing.Point(16, 200);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(146, 36);
            this.dtpFecha.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.BackColor = System.Drawing.Color.Transparent;
            this.lblPieza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblPieza.Location = new System.Drawing.Point(178, 180);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(82, 15);
            this.lblPieza.Text = "Pieza dental";
            this.lblPieza.TabIndex = 7;
            // 
            // txtPieza
            // 
            this.txtPieza.BackColor = System.Drawing.Color.Transparent;
            this.txtPieza.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtPieza.BorderRadius = 8;
            this.txtPieza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPieza.DefaultText = "";
            this.txtPieza.FillColor = System.Drawing.Color.White;
            this.txtPieza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtPieza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtPieza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtPieza.Location = new System.Drawing.Point(178, 200);
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtPieza.PlaceholderText = "Ej.: 14";
            this.txtPieza.SelectedText = "";
            this.txtPieza.Size = new System.Drawing.Size(146, 36);
            this.txtPieza.TabIndex = 8;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblMotivo.Location = new System.Drawing.Point(16, 244);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(56, 15);
            this.lblMotivo.Text = "Motivo *";
            this.lblMotivo.TabIndex = 9;
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.Transparent;
            this.txtMotivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtMotivo.BorderRadius = 8;
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.FillColor = System.Drawing.Color.White;
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMotivo.Location = new System.Drawing.Point(16, 264);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(308, 36);
            this.txtMotivo.TabIndex = 10;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblDiagnostico.Location = new System.Drawing.Point(16, 308);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(88, 15);
            this.lblDiagnostico.Text = "Diagnóstico *";
            this.lblDiagnostico.TabIndex = 11;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.txtDiagnostico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtDiagnostico.BorderRadius = 8;
            this.txtDiagnostico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnostico.DefaultText = "";
            this.txtDiagnostico.FillColor = System.Drawing.Color.White;
            this.txtDiagnostico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtDiagnostico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtDiagnostico.Location = new System.Drawing.Point(16, 328);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtDiagnostico.PlaceholderText = "";
            this.txtDiagnostico.SelectedText = "";
            this.txtDiagnostico.Size = new System.Drawing.Size(308, 36);
            this.txtDiagnostico.TabIndex = 12;
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.AutoSize = true;
            this.lblProcedimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblProcedimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblProcedimiento.Location = new System.Drawing.Point(16, 372);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(166, 15);
            this.lblProcedimiento.Text = "Procedimiento / evolución";
            this.lblProcedimiento.TabIndex = 13;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.BackColor = System.Drawing.Color.Transparent;
            this.txtProcedimiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtProcedimiento.BorderRadius = 8;
            this.txtProcedimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcedimiento.DefaultText = "";
            this.txtProcedimiento.FillColor = System.Drawing.Color.White;
            this.txtProcedimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtProcedimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtProcedimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtProcedimiento.Location = new System.Drawing.Point(16, 392);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtProcedimiento.PlaceholderText = "";
            this.txtProcedimiento.SelectedText = "";
            this.txtProcedimiento.Size = new System.Drawing.Size(308, 90);
            this.txtProcedimiento.TabIndex = 14;
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
            this.btnNuevo.Location = new System.Drawing.Point(98, 500);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 36);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TabIndex = 15;
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
            this.btnGuardar.Location = new System.Drawing.Point(214, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TabIndex = 16;
            // 
            // frmAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1138, 731);
            this.Controls.Add(this.pnlRegistrarAtencion);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.dgvAtenciones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboFiltroOdontologo);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentoTacna Smart — Atenciones";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).EndInit();
            this.pnlRegistrarAtencion.ResumeLayout(false);
            this.pnlRegistrarAtencion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2ComboBox cboFiltroOdontologo;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAtenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcedimiento;
        private System.Windows.Forms.Label lblRegistros;
        private Guna.UI2.WinForms.Guna2Panel pnlRegistrarAtencion;
        private System.Windows.Forms.Label lblRegistrarAtencion;
        private System.Windows.Forms.Label lblPaciente;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaciente;
        private System.Windows.Forms.Label lblOdontologo;
        private Guna.UI2.WinForms.Guna2ComboBox cboOdontologo;
        private System.Windows.Forms.Label lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblPieza;
        private Guna.UI2.WinForms.Guna2TextBox txtPieza;
        private System.Windows.Forms.Label lblMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private System.Windows.Forms.Label lblDiagnostico;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblProcedimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtProcedimiento;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
    }
}