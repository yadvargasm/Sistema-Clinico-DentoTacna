namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlCargos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCargos = new System.Windows.Forms.Label();
            this.lblCargosPaciente = new System.Windows.Forms.Label();
            this.dgvCargos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPagosHoy = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPagosHoy = new System.Windows.Forms.Label();
            this.dgvPagosHoy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConceptoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidadPagos = new System.Windows.Forms.Label();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.pnlRegistrarPago = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRegistrarPago = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cboMetodo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.txtRecibo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlResumen = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalPagarTexto = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblVueltoTexto = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.pnlPagosHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosHoy)).BeginInit();
            this.pnlRegistrarPago.SuspendLayout();
            this.pnlResumen.SuspendLayout();
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
            this.lblTitulo.Text = "Pagos";
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
            this.lblSubtitulo.Size = new System.Drawing.Size(186, 15);
            this.lblSubtitulo.Text = "Cobros y saldos de pacientes";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // pnlCargos
            // 
            this.pnlCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCargos.BackColor = System.Drawing.Color.Transparent;
            this.pnlCargos.BorderRadius = 10;
            this.pnlCargos.Controls.Add(this.dgvCargos);
            this.pnlCargos.Controls.Add(this.lblCargosPaciente);
            this.pnlCargos.Controls.Add(this.lblCargos);
            this.pnlCargos.FillColor = System.Drawing.Color.White;
            this.pnlCargos.Location = new System.Drawing.Point(20, 80);
            this.pnlCargos.Name = "pnlCargos";
            this.pnlCargos.Size = new System.Drawing.Size(742, 250);
            this.pnlCargos.TabIndex = 1;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.BackColor = System.Drawing.Color.Transparent;
            this.lblCargos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblCargos.Location = new System.Drawing.Point(16, 14);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(131, 20);
            this.lblCargos.Text = "Cargos pendientes";
            this.lblCargos.TabIndex = 0;
            // 
            // lblCargosPaciente
            // 
            this.lblCargosPaciente.AutoSize = true;
            this.lblCargosPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblCargosPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargosPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblCargosPaciente.Location = new System.Drawing.Point(162, 17);
            this.lblCargosPaciente.Name = "lblCargosPaciente";
            this.lblCargosPaciente.Size = new System.Drawing.Size(160, 15);
            this.lblCargosPaciente.Text = "— Seleccione un paciente";
            this.lblCargosPaciente.TabIndex = 1;
            // 
            // dgvCargos
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
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;
            this.dgvCargos.AllowUserToResizeRows = false;
            this.dgvCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCargos.ColumnHeadersHeight = 40;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colConcepto,
            this.colPieza,
            this.colFechaCargo,
            this.colImporte});
            this.dgvCargos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCargos.EnableHeadersVisualStyles = false;
            this.dgvCargos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvCargos.Location = new System.Drawing.Point(16, 48);
            this.dgvCargos.MultiSelect = false;
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.RowTemplate.Height = 38;
            this.dgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargos.Size = new System.Drawing.Size(710, 186);
            this.dgvCargos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCargos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCargos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvCargos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCargos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCargos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvCargos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvCargos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCargos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCargos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.dgvCargos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCargos.ThemeStyle.ReadOnly = true;
            this.dgvCargos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCargos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCargos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCargos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCargos.ThemeStyle.RowsStyle.Height = 38;
            this.dgvCargos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvCargos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvCargos.TabIndex = 2;
            // 
            // colSel
            // 
            this.colSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSel.HeaderText = "";
            this.colSel.MinimumWidth = 36;
            this.colSel.Name = "colSel";
            this.colSel.Width = 36;
            // 
            // colConcepto
            // 
            this.colConcepto.FillWeight = 220F;
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            // 
            // colPieza
            // 
            this.colPieza.FillWeight = 60F;
            this.colPieza.HeaderText = "Pieza";
            this.colPieza.Name = "colPieza";
            // 
            // colFechaCargo
            // 
            this.colFechaCargo.FillWeight = 90F;
            this.colFechaCargo.HeaderText = "Fecha";
            this.colFechaCargo.Name = "colFechaCargo";
            // 
            // colImporte
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.colImporte.FillWeight = 90F;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            // 
            // pnlPagosHoy
            // 
            this.pnlPagosHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPagosHoy.BackColor = System.Drawing.Color.Transparent;
            this.pnlPagosHoy.BorderRadius = 10;
            this.pnlPagosHoy.Controls.Add(this.lblTotalDia);
            this.pnlPagosHoy.Controls.Add(this.lblCantidadPagos);
            this.pnlPagosHoy.Controls.Add(this.dgvPagosHoy);
            this.pnlPagosHoy.Controls.Add(this.lblPagosHoy);
            this.pnlPagosHoy.FillColor = System.Drawing.Color.White;
            this.pnlPagosHoy.Location = new System.Drawing.Point(20, 346);
            this.pnlPagosHoy.Name = "pnlPagosHoy";
            this.pnlPagosHoy.Size = new System.Drawing.Size(742, 290);
            this.pnlPagosHoy.TabIndex = 2;
            // 
            // lblPagosHoy
            // 
            this.lblPagosHoy.AutoSize = true;
            this.lblPagosHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblPagosHoy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagosHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblPagosHoy.Location = new System.Drawing.Point(16, 14);
            this.lblPagosHoy.Name = "lblPagosHoy";
            this.lblPagosHoy.Size = new System.Drawing.Size(94, 20);
            this.lblPagosHoy.Text = "Pagos de hoy";
            this.lblPagosHoy.TabIndex = 0;
            // 
            // dgvPagosHoy
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagosHoy.AllowUserToAddRows = false;
            this.dgvPagosHoy.AllowUserToDeleteRows = false;
            this.dgvPagosHoy.AllowUserToResizeRows = false;
            this.dgvPagosHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPagosHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagosHoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosHoy.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagosHoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagosHoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPagosHoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPagosHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPagosHoy.ColumnHeadersHeight = 40;
            this.dgvPagosHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPagosHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHora,
            this.colRecibo,
            this.colPaciente,
            this.colConceptoPago,
            this.colMetodo,
            this.colImportePago});
            this.dgvPagosHoy.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPagosHoy.EnableHeadersVisualStyles = false;
            this.dgvPagosHoy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPagosHoy.Location = new System.Drawing.Point(16, 48);
            this.dgvPagosHoy.MultiSelect = false;
            this.dgvPagosHoy.Name = "dgvPagosHoy";
            this.dgvPagosHoy.ReadOnly = true;
            this.dgvPagosHoy.RowHeadersVisible = false;
            this.dgvPagosHoy.RowTemplate.Height = 38;
            this.dgvPagosHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosHoy.Size = new System.Drawing.Size(710, 194);
            this.dgvPagosHoy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagosHoy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvPagosHoy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvPagosHoy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvPagosHoy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagosHoy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPagosHoy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvPagosHoy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPagosHoy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagosHoy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.dgvPagosHoy.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPagosHoy.ThemeStyle.ReadOnly = true;
            this.dgvPagosHoy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagosHoy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPagosHoy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagosHoy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvPagosHoy.ThemeStyle.RowsStyle.Height = 38;
            this.dgvPagosHoy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvPagosHoy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.dgvPagosHoy.TabIndex = 1;
            // 
            // colHora
            // 
            this.colHora.FillWeight = 55F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // colRecibo
            // 
            this.colRecibo.FillWeight = 80F;
            this.colRecibo.HeaderText = "N.° recibo";
            this.colRecibo.Name = "colRecibo";
            // 
            // colPaciente
            // 
            this.colPaciente.FillWeight = 150F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            // 
            // colConceptoPago
            // 
            this.colConceptoPago.FillWeight = 120F;
            this.colConceptoPago.HeaderText = "Concepto";
            this.colConceptoPago.Name = "colConceptoPago";
            // 
            // colMetodo
            // 
            this.colMetodo.FillWeight = 85F;
            this.colMetodo.HeaderText = "Método";
            this.colMetodo.Name = "colMetodo";
            // 
            // colImportePago
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImportePago.DefaultCellStyle = dataGridViewCellStyle8;
            this.colImportePago.FillWeight = 80F;
            this.colImportePago.HeaderText = "Importe";
            this.colImportePago.Name = "colImportePago";
            // 
            // lblCantidadPagos
            // 
            this.lblCantidadPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidadPagos.AutoSize = true;
            this.lblCantidadPagos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadPagos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblCantidadPagos.Location = new System.Drawing.Point(16, 258);
            this.lblCantidadPagos.Name = "lblCantidadPagos";
            this.lblCantidadPagos.Size = new System.Drawing.Size(49, 15);
            this.lblCantidadPagos.Text = "0 pagos";
            this.lblCantidadPagos.TabIndex = 2;
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDia.AutoSize = false;
            this.lblTotalDia.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblTotalDia.Location = new System.Drawing.Point(426, 256);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(300, 17);
            this.lblTotalDia.Text = "Total del día: S/ 0.00";
            this.lblTotalDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalDia.TabIndex = 3;
            // 
            // pnlRegistrarPago
            // 
            this.pnlRegistrarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrarPago.BorderRadius = 10;
            this.pnlRegistrarPago.Controls.Add(this.btnCobrar);
            this.pnlRegistrarPago.Controls.Add(this.btnCancelar);
            this.pnlRegistrarPago.Controls.Add(this.pnlResumen);
            this.pnlRegistrarPago.Controls.Add(this.txtMonto);
            this.pnlRegistrarPago.Controls.Add(this.lblMonto);
            this.pnlRegistrarPago.Controls.Add(this.txtRecibo);
            this.pnlRegistrarPago.Controls.Add(this.lblRecibo);
            this.pnlRegistrarPago.Controls.Add(this.cboMetodo);
            this.pnlRegistrarPago.Controls.Add(this.lblMetodo);
            this.pnlRegistrarPago.Controls.Add(this.txtPaciente);
            this.pnlRegistrarPago.Controls.Add(this.lblPaciente);
            this.pnlRegistrarPago.Controls.Add(this.lblRegistrarPago);
            this.pnlRegistrarPago.FillColor = System.Drawing.Color.White;
            this.pnlRegistrarPago.Location = new System.Drawing.Point(778, 80);
            this.pnlRegistrarPago.Name = "pnlRegistrarPago";
            this.pnlRegistrarPago.Size = new System.Drawing.Size(340, 460);
            this.pnlRegistrarPago.TabIndex = 3;
            // 
            // lblRegistrarPago
            // 
            this.lblRegistrarPago.AutoSize = true;
            this.lblRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblRegistrarPago.Location = new System.Drawing.Point(16, 14);
            this.lblRegistrarPago.Name = "lblRegistrarPago";
            this.lblRegistrarPago.Size = new System.Drawing.Size(109, 20);
            this.lblRegistrarPago.Text = "Registrar pago";
            this.lblRegistrarPago.TabIndex = 0;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblPaciente.Location = new System.Drawing.Point(16, 52);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(56, 15);
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.TabIndex = 1;
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txtPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtPaciente.BorderRadius = 8;
            this.txtPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaciente.DefaultText = "";
            this.txtPaciente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtPaciente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtPaciente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtPaciente.Location = new System.Drawing.Point(16, 72);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtPaciente.PlaceholderText = "Seleccione un paciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.SelectedText = "";
            this.txtPaciente.Size = new System.Drawing.Size(308, 36);
            this.txtPaciente.TabIndex = 2;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblMetodo.Location = new System.Drawing.Point(16, 116);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(108, 15);
            this.lblMetodo.Text = "Método de pago *";
            this.lblMetodo.TabIndex = 3;
            // 
            // cboMetodo
            // 
            this.cboMetodo.BackColor = System.Drawing.Color.Transparent;
            this.cboMetodo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.cboMetodo.BorderRadius = 8;
            this.cboMetodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboMetodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboMetodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cboMetodo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.cboMetodo.ItemHeight = 30;
            this.cboMetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Yape / Plin",
            "Transferencia"});
            this.cboMetodo.Location = new System.Drawing.Point(16, 136);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(308, 36);
            this.cboMetodo.StartIndex = 0;
            this.cboMetodo.TabIndex = 4;
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.BackColor = System.Drawing.Color.Transparent;
            this.lblRecibo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblRecibo.Location = new System.Drawing.Point(16, 180);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(69, 15);
            this.lblRecibo.Text = "N.° recibo";
            this.lblRecibo.TabIndex = 5;
            // 
            // txtRecibo
            // 
            this.txtRecibo.BackColor = System.Drawing.Color.Transparent;
            this.txtRecibo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtRecibo.BorderRadius = 8;
            this.txtRecibo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibo.DefaultText = "";
            this.txtRecibo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtRecibo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtRecibo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtRecibo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtRecibo.Location = new System.Drawing.Point(16, 200);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtRecibo.PlaceholderText = "Se genera al cobrar";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.SelectedText = "";
            this.txtRecibo.Size = new System.Drawing.Size(308, 36);
            this.txtRecibo.TabIndex = 6;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblMonto.Location = new System.Drawing.Point(16, 244);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(140, 15);
            this.lblMonto.Text = "Monto recibido (S/) *";
            this.lblMonto.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Transparent;
            this.txtMonto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.txtMonto.BorderRadius = 8;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.FillColor = System.Drawing.Color.White;
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.txtMonto.Location = new System.Drawing.Point(16, 264);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.txtMonto.PlaceholderText = "0.00";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(308, 36);
            this.txtMonto.TabIndex = 8;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.Transparent;
            this.pnlResumen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.pnlResumen.BorderRadius = 8;
            this.pnlResumen.BorderThickness = 1;
            this.pnlResumen.Controls.Add(this.lblVuelto);
            this.pnlResumen.Controls.Add(this.lblVueltoTexto);
            this.pnlResumen.Controls.Add(this.lblTotalPagar);
            this.pnlResumen.Controls.Add(this.lblTotalPagarTexto);
            this.pnlResumen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlResumen.Location = new System.Drawing.Point(16, 316);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(308, 72);
            this.pnlResumen.TabIndex = 9;
            // 
            // lblTotalPagarTexto
            // 
            this.lblTotalPagarTexto.AutoSize = true;
            this.lblTotalPagarTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagarTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagarTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblTotalPagarTexto.Location = new System.Drawing.Point(12, 12);
            this.lblTotalPagarTexto.Name = "lblTotalPagarTexto";
            this.lblTotalPagarTexto.Size = new System.Drawing.Size(101, 20);
            this.lblTotalPagarTexto.Text = "Total a pagar";
            this.lblTotalPagarTexto.TabIndex = 0;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = false;
            this.lblTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.lblTotalPagar.Location = new System.Drawing.Point(150, 10);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(146, 20);
            this.lblTotalPagar.Text = "S/ 0.00";
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPagar.TabIndex = 1;
            // 
            // lblVueltoTexto
            // 
            this.lblVueltoTexto.AutoSize = true;
            this.lblVueltoTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblVueltoTexto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueltoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblVueltoTexto.Location = new System.Drawing.Point(12, 44);
            this.lblVueltoTexto.Name = "lblVueltoTexto";
            this.lblVueltoTexto.Size = new System.Drawing.Size(43, 15);
            this.lblVueltoTexto.Text = "Vuelto";
            this.lblVueltoTexto.TabIndex = 2;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = false;
            this.lblVuelto.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.lblVuelto.Location = new System.Drawing.Point(150, 42);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(146, 15);
            this.lblVuelto.Text = "S/ 0.00";
            this.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVuelto.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnCancelar.Location = new System.Drawing.Point(98, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TabIndex = 10;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCobrar.BorderRadius = 8;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(128)))));
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.btnCobrar.Location = new System.Drawing.Point(214, 404);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(110, 36);
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TabIndex = 11;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1138, 731);
            this.Controls.Add(this.pnlRegistrarPago);
            this.Controls.Add(this.pnlPagosHoy);
            this.Controls.Add(this.pnlCargos);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentoTacna Smart — Pagos";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlCargos.ResumeLayout(false);
            this.pnlCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.pnlPagosHoy.ResumeLayout(false);
            this.pnlPagosHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosHoy)).EndInit();
            this.pnlRegistrarPago.ResumeLayout(false);
            this.pnlRegistrarPago.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlCargos;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Label lblCargosPaciente;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCargos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private Guna.UI2.WinForms.Guna2Panel pnlPagosHoy;
        private System.Windows.Forms.Label lblPagosHoy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPagosHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConceptoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportePago;
        private System.Windows.Forms.Label lblCantidadPagos;
        private System.Windows.Forms.Label lblTotalDia;
        private Guna.UI2.WinForms.Guna2Panel pnlRegistrarPago;
        private System.Windows.Forms.Label lblRegistrarPago;
        private System.Windows.Forms.Label lblPaciente;
        private Guna.UI2.WinForms.Guna2TextBox txtPaciente;
        private System.Windows.Forms.Label lblMetodo;
        private Guna.UI2.WinForms.Guna2ComboBox cboMetodo;
        private System.Windows.Forms.Label lblRecibo;
        private Guna.UI2.WinForms.Guna2TextBox txtRecibo;
        private System.Windows.Forms.Label lblMonto;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private Guna.UI2.WinForms.Guna2Panel pnlResumen;
        private System.Windows.Forms.Label lblTotalPagarTexto;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblVueltoTexto;
        private System.Windows.Forms.Label lblVuelto;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnCobrar;
    }
}