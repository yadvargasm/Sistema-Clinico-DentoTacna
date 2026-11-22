namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    partial class frmPagos
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
            this.pnlCargos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCargos = new System.Windows.Forms.Label();
            this.dgvCargos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPagosHoy = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPagosHoy = new System.Windows.Forms.Label();
            this.dgvPagosHoy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConceptoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResumenMetodos = new System.Windows.Forms.Label();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.pnlRegistrarPago = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRegistrarPago = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.rbPagoTotal = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbACuenta = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cboMetodo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlOperacion = new System.Windows.Forms.Panel();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtOperacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.txtRecibo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlResumen = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSeleccionadoTexto = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.lblVueltoTexto = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPasarela = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPasarela = new System.Windows.Forms.Label();
            this.tagProximaVersion = new Guna.UI2.WinForms.Guna2Button();
            this.lblPasarelaDesc = new System.Windows.Forms.Label();
            this.pnlCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.pnlPagosHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosHoy)).BeginInit();
            this.pnlRegistrarPago.SuspendLayout();
            this.pnlOperacion.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.pnlPasarela.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(32, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pagos";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblSubtitulo.Location = new System.Drawing.Point(23, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(286, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Cobros, pagos a cuenta y saldos de pacientes";
            //
            // pnlCargos
            //
            this.pnlCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlCargos.BackColor = System.Drawing.Color.Transparent;
            this.pnlCargos.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlCargos.BorderRadius = 10;
            this.pnlCargos.BorderThickness = 1;
            this.pnlCargos.Controls.Add(this.dgvCargos);
            this.pnlCargos.Controls.Add(this.lblCargos);
            this.pnlCargos.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCargos.Location = new System.Drawing.Point(22, 80);
            this.pnlCargos.Name = "pnlCargos";
            this.pnlCargos.Size = new System.Drawing.Size(758, 232);
            this.pnlCargos.TabIndex = 2;
            //
            // lblCargos
            //
            this.lblCargos.AutoSize = true;
            this.lblCargos.BackColor = System.Drawing.Color.Transparent;
            this.lblCargos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCargos.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblCargos.Location = new System.Drawing.Point(16, 14);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(416, 17);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "Saldos del plan de tratamiento — María Elena Castillo (HC-00482)";
            //
            // dgvCargos
            //
            this.dgvCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colConcepto,
            this.colPieza,
            this.colFechaCargo,
            this.colTotal,
            this.colCuenta,
            this.colSaldo});
            this.dgvCargos.Location = new System.Drawing.Point(16, 44);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.Size = new System.Drawing.Size(726, 172);
            this.dgvCargos.TabIndex = 1;
            this.dgvCargos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellValueChanged);
            this.dgvCargos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCargos_CurrentCellDirtyStateChanged);
            //
            // colSel
            //
            this.colSel.FillWeight = 22F;
            this.colSel.HeaderText = "";
            this.colSel.Name = "colSel";
            //
            // colConcepto
            //
            this.colConcepto.FillWeight = 150F;
            this.colConcepto.HeaderText = "Tratamiento";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            //
            // colPieza
            //
            this.colPieza.FillWeight = 40F;
            this.colPieza.HeaderText = "Pieza";
            this.colPieza.Name = "colPieza";
            this.colPieza.ReadOnly = true;
            //
            // colFechaCargo
            //
            this.colFechaCargo.FillWeight = 70F;
            this.colFechaCargo.HeaderText = "Fecha";
            this.colFechaCargo.Name = "colFechaCargo";
            this.colFechaCargo.ReadOnly = true;
            //
            // colTotal
            //
            this.colTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.FillWeight = 70F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            //
            // colCuenta
            //
            this.colCuenta.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCuenta.FillWeight = 70F;
            this.colCuenta.HeaderText = "A cuenta";
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.ReadOnly = true;
            //
            // colSaldo
            //
            this.colSaldo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSaldo.FillWeight = 70F;
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            //
            // pnlPagosHoy
            //
            this.pnlPagosHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlPagosHoy.BackColor = System.Drawing.Color.Transparent;
            this.pnlPagosHoy.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlPagosHoy.BorderRadius = 10;
            this.pnlPagosHoy.BorderThickness = 1;
            this.pnlPagosHoy.Controls.Add(this.lblTotalDia);
            this.pnlPagosHoy.Controls.Add(this.lblResumenMetodos);
            this.pnlPagosHoy.Controls.Add(this.dgvPagosHoy);
            this.pnlPagosHoy.Controls.Add(this.lblPagosHoy);
            this.pnlPagosHoy.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlPagosHoy.Location = new System.Drawing.Point(22, 326);
            this.pnlPagosHoy.Name = "pnlPagosHoy";
            this.pnlPagosHoy.Size = new System.Drawing.Size(758, 380);
            this.pnlPagosHoy.TabIndex = 3;
            //
            // lblPagosHoy
            //
            this.lblPagosHoy.AutoSize = true;
            this.lblPagosHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblPagosHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPagosHoy.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblPagosHoy.Location = new System.Drawing.Point(16, 14);
            this.lblPagosHoy.Name = "lblPagosHoy";
            this.lblPagosHoy.Size = new System.Drawing.Size(78, 17);
            this.lblPagosHoy.TabIndex = 0;
            this.lblPagosHoy.Text = "Pagos de hoy";
            //
            // dgvPagosHoy
            //
            this.dgvPagosHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.dgvPagosHoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHora,
            this.colRecibo,
            this.colPaciente,
            this.colConceptoPago,
            this.colTipo,
            this.colMetodo,
            this.colOperacion,
            this.colImportePago});
            this.dgvPagosHoy.Location = new System.Drawing.Point(16, 44);
            this.dgvPagosHoy.Name = "dgvPagosHoy";
            this.dgvPagosHoy.ReadOnly = true;
            this.dgvPagosHoy.RowHeadersVisible = false;
            this.dgvPagosHoy.Size = new System.Drawing.Size(726, 290);
            this.dgvPagosHoy.TabIndex = 1;
            //
            // colHora
            //
            this.colHora.FillWeight = 45F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            //
            // colRecibo
            //
            this.colRecibo.FillWeight = 70F;
            this.colRecibo.HeaderText = "N.° recibo";
            this.colRecibo.Name = "colRecibo";
            this.colRecibo.ReadOnly = true;
            //
            // colPaciente
            //
            this.colPaciente.FillWeight = 120F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            this.colPaciente.ReadOnly = true;
            //
            // colConceptoPago
            //
            this.colConceptoPago.FillWeight = 100F;
            this.colConceptoPago.HeaderText = "Concepto";
            this.colConceptoPago.Name = "colConceptoPago";
            this.colConceptoPago.ReadOnly = true;
            //
            // colTipo
            //
            this.colTipo.FillWeight = 70F;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            //
            // colMetodo
            //
            this.colMetodo.FillWeight = 70F;
            this.colMetodo.HeaderText = "Método";
            this.colMetodo.Name = "colMetodo";
            this.colMetodo.ReadOnly = true;
            //
            // colOperacion
            //
            this.colOperacion.FillWeight = 80F;
            this.colOperacion.HeaderText = "N.° operación";
            this.colOperacion.Name = "colOperacion";
            this.colOperacion.ReadOnly = true;
            //
            // colImportePago
            //
            this.colImportePago.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImportePago.FillWeight = 70F;
            this.colImportePago.HeaderText = "Importe";
            this.colImportePago.Name = "colImportePago";
            this.colImportePago.ReadOnly = true;
            //
            // lblResumenMetodos
            //
            this.lblResumenMetodos.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.lblResumenMetodos.BackColor = System.Drawing.Color.Transparent;
            this.lblResumenMetodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResumenMetodos.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblResumenMetodos.Location = new System.Drawing.Point(16, 346);
            this.lblResumenMetodos.Name = "lblResumenMetodos";
            this.lblResumenMetodos.Size = new System.Drawing.Size(520, 17);
            this.lblResumenMetodos.TabIndex = 2;
            this.lblResumenMetodos.Text = "0 pagos";
            //
            // lblTotalDia
            //
            this.lblTotalDia.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotalDia.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalDia.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblTotalDia.Location = new System.Drawing.Point(542, 344);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(200, 20);
            this.lblTotalDia.TabIndex = 3;
            this.lblTotalDia.Text = "Total del día: S/ 0.00";
            this.lblTotalDia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // pnlRegistrarPago
            //
            this.pnlRegistrarPago.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrarPago.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlRegistrarPago.BorderRadius = 10;
            this.pnlRegistrarPago.BorderThickness = 1;
            this.pnlRegistrarPago.Controls.Add(this.btnCobrar);
            this.pnlRegistrarPago.Controls.Add(this.btnCancelar);
            this.pnlRegistrarPago.Controls.Add(this.pnlResumen);
            this.pnlRegistrarPago.Controls.Add(this.txtMonto);
            this.pnlRegistrarPago.Controls.Add(this.lblMonto);
            this.pnlRegistrarPago.Controls.Add(this.txtRecibo);
            this.pnlRegistrarPago.Controls.Add(this.lblRecibo);
            this.pnlRegistrarPago.Controls.Add(this.pnlOperacion);
            this.pnlRegistrarPago.Controls.Add(this.cboMetodo);
            this.pnlRegistrarPago.Controls.Add(this.lblMetodo);
            this.pnlRegistrarPago.Controls.Add(this.rbACuenta);
            this.pnlRegistrarPago.Controls.Add(this.rbPagoTotal);
            this.pnlRegistrarPago.Controls.Add(this.lblTipoPago);
            this.pnlRegistrarPago.Controls.Add(this.txtPaciente);
            this.pnlRegistrarPago.Controls.Add(this.lblPaciente);
            this.pnlRegistrarPago.Controls.Add(this.lblRegistrarPago);
            this.pnlRegistrarPago.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlRegistrarPago.Location = new System.Drawing.Point(796, 80);
            this.pnlRegistrarPago.Name = "pnlRegistrarPago";
            this.pnlRegistrarPago.Size = new System.Drawing.Size(350, 548);
            this.pnlRegistrarPago.TabIndex = 4;
            //
            // lblRegistrarPago
            //
            this.lblRegistrarPago.AutoSize = true;
            this.lblRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarPago.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblRegistrarPago.Location = new System.Drawing.Point(16, 14);
            this.lblRegistrarPago.Name = "lblRegistrarPago";
            this.lblRegistrarPago.Size = new System.Drawing.Size(91, 17);
            this.lblRegistrarPago.TabIndex = 0;
            this.lblRegistrarPago.Text = "Registrar pago";
            //
            // lblPaciente
            //
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPaciente.Location = new System.Drawing.Point(16, 46);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 17);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente";
            //
            // txtPaciente
            //
            this.txtPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaciente.DefaultText = "María Elena Castillo — HC-00482";
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPaciente.Location = new System.Drawing.Point(16, 66);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PlaceholderText = "";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.SelectedText = "";
            this.txtPaciente.Size = new System.Drawing.Size(318, 36);
            this.txtPaciente.TabIndex = 2;
            //
            // lblTipoPago
            //
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoPago.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblTipoPago.Location = new System.Drawing.Point(16, 110);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(91, 17);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo de pago *";
            //
            // rbPagoTotal
            //
            this.rbPagoTotal.AutoSize = true;
            this.rbPagoTotal.Checked = true;
            this.rbPagoTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbPagoTotal.Location = new System.Drawing.Point(16, 134);
            this.rbPagoTotal.Name = "rbPagoTotal";
            this.rbPagoTotal.Size = new System.Drawing.Size(88, 19);
            this.rbPagoTotal.TabIndex = 4;
            this.rbPagoTotal.TabStop = true;
            this.rbPagoTotal.Text = "Pago total";
            //
            // rbACuenta
            //
            this.rbACuenta.AutoSize = true;
            this.rbACuenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbACuenta.Location = new System.Drawing.Point(130, 134);
            this.rbACuenta.Name = "rbACuenta";
            this.rbACuenta.Size = new System.Drawing.Size(139, 19);
            this.rbACuenta.TabIndex = 5;
            this.rbACuenta.TabStop = true;
            this.rbACuenta.Text = "A cuenta (parcial)";
            //
            // lblMetodo
            //
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblMetodo.Location = new System.Drawing.Point(16, 164);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(104, 17);
            this.lblMetodo.TabIndex = 6;
            this.lblMetodo.Text = "Método de pago *";
            //
            // cboMetodo
            //
            this.cboMetodo.BackColor = System.Drawing.Color.Transparent;
            this.cboMetodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboMetodo.ItemHeight = 30;
            this.cboMetodo.Location = new System.Drawing.Point(16, 184);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(318, 36);
            this.cboMetodo.TabIndex = 7;
            //
            // pnlOperacion
            //
            this.pnlOperacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlOperacion.Controls.Add(this.txtOperacion);
            this.pnlOperacion.Controls.Add(this.lblOperacion);
            this.pnlOperacion.Location = new System.Drawing.Point(16, 228);
            this.pnlOperacion.Name = "pnlOperacion";
            this.pnlOperacion.Size = new System.Drawing.Size(318, 60);
            this.pnlOperacion.TabIndex = 8;
            //
            // lblOperacion
            //
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblOperacion.Location = new System.Drawing.Point(0, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(117, 17);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "N.° de operación *";
            //
            // txtOperacion
            //
            this.txtOperacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOperacion.DefaultText = "";
            this.txtOperacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOperacion.Location = new System.Drawing.Point(0, 20);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.PlaceholderText = "N.° de operación para verificar";
            this.txtOperacion.SelectedText = "";
            this.txtOperacion.Size = new System.Drawing.Size(318, 36);
            this.txtOperacion.TabIndex = 1;
            //
            // lblRecibo
            //
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.BackColor = System.Drawing.Color.Transparent;
            this.lblRecibo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecibo.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblRecibo.Location = new System.Drawing.Point(16, 292);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(65, 17);
            this.lblRecibo.TabIndex = 9;
            this.lblRecibo.Text = "N.° recibo";
            //
            // txtRecibo
            //
            this.txtRecibo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibo.DefaultText = "R-004519";
            this.txtRecibo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRecibo.Location = new System.Drawing.Point(16, 312);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.PlaceholderText = "";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.SelectedText = "";
            this.txtRecibo.Size = new System.Drawing.Size(318, 36);
            this.txtRecibo.TabIndex = 10;
            //
            // lblMonto
            //
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblMonto.Location = new System.Drawing.Point(16, 356);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(136, 17);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto recibido (S/) *";
            //
            // txtMonto
            //
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "220.00";
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMonto.Location = new System.Drawing.Point(16, 376);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(318, 36);
            this.txtMonto.TabIndex = 12;
            //
            // pnlResumen
            //
            this.pnlResumen.BackColor = System.Drawing.Color.Transparent;
            this.pnlResumen.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlResumen.BorderRadius = 8;
            this.pnlResumen.BorderThickness = 1;
            this.pnlResumen.Controls.Add(this.lblVuelto);
            this.pnlResumen.Controls.Add(this.lblVueltoTexto);
            this.pnlResumen.Controls.Add(this.lblSeleccionado);
            this.pnlResumen.Controls.Add(this.lblSeleccionadoTexto);
            this.pnlResumen.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.pnlResumen.Location = new System.Drawing.Point(16, 422);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(318, 62);
            this.pnlResumen.TabIndex = 13;
            //
            // lblSeleccionadoTexto
            //
            this.lblSeleccionadoTexto.AutoSize = true;
            this.lblSeleccionadoTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionadoTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionadoTexto.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblSeleccionadoTexto.Location = new System.Drawing.Point(12, 8);
            this.lblSeleccionadoTexto.Name = "lblSeleccionadoTexto";
            this.lblSeleccionadoTexto.Size = new System.Drawing.Size(78, 17);
            this.lblSeleccionadoTexto.TabIndex = 0;
            this.lblSeleccionadoTexto.Text = "Seleccionado";
            //
            // lblSeleccionado
            //
            this.lblSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionado.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.lblSeleccionado.Location = new System.Drawing.Point(158, 8);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(148, 21);
            this.lblSeleccionado.TabIndex = 1;
            this.lblSeleccionado.Text = "S/ 0.00";
            this.lblSeleccionado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // lblVueltoTexto
            //
            this.lblVueltoTexto.AutoSize = true;
            this.lblVueltoTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblVueltoTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVueltoTexto.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblVueltoTexto.Location = new System.Drawing.Point(12, 37);
            this.lblVueltoTexto.Name = "lblVueltoTexto";
            this.lblVueltoTexto.Size = new System.Drawing.Size(39, 17);
            this.lblVueltoTexto.TabIndex = 2;
            this.lblVueltoTexto.Text = "Vuelto";
            //
            // lblVuelto
            //
            this.lblVuelto.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVuelto.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblVuelto.Location = new System.Drawing.Point(158, 37);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(148, 17);
            this.lblVuelto.TabIndex = 3;
            this.lblVuelto.Text = "S/ 0.00";
            this.lblVuelto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(202, 213, 218);
            this.btnCancelar.BorderRadius = 6;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 42, 48);
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 247, 247);
            this.btnCancelar.Location = new System.Drawing.Point(16, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnCobrar
            //
            this.btnCobrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCobrar.BorderRadius = 6;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FillColor = System.Drawing.Color.FromArgb(15, 124, 128);
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.HoverState.FillColor = System.Drawing.Color.FromArgb(11, 100, 104);
            this.btnCobrar.Location = new System.Drawing.Point(144, 496);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(190, 36);
            this.btnCobrar.TabIndex = 15;
            this.btnCobrar.Text = "Cobrar S/ 0.00";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            //
            // pnlPasarela
            //
            this.pnlPasarela.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlPasarela.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasarela.BorderColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.pnlPasarela.BorderRadius = 10;
            this.pnlPasarela.BorderThickness = 1;
            this.pnlPasarela.Controls.Add(this.lblPasarelaDesc);
            this.pnlPasarela.Controls.Add(this.tagProximaVersion);
            this.pnlPasarela.Controls.Add(this.lblPasarela);
            this.pnlPasarela.FillColor = System.Drawing.Color.FromArgb(247, 250, 251);
            this.pnlPasarela.Location = new System.Drawing.Point(796, 642);
            this.pnlPasarela.Name = "pnlPasarela";
            this.pnlPasarela.Size = new System.Drawing.Size(350, 86);
            this.pnlPasarela.TabIndex = 5;
            //
            // lblPasarela
            //
            this.lblPasarela.AutoSize = true;
            this.lblPasarela.BackColor = System.Drawing.Color.Transparent;
            this.lblPasarela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPasarela.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPasarela.Location = new System.Drawing.Point(16, 10);
            this.lblPasarela.Name = "lblPasarela";
            this.lblPasarela.Size = new System.Drawing.Size(169, 17);
            this.lblPasarela.TabIndex = 0;
            this.lblPasarela.Text = "Pasarela de pagos en línea";
            //
            // tagProximaVersion
            //
            this.tagProximaVersion.BackColor = System.Drawing.Color.Transparent;
            this.tagProximaVersion.BorderRadius = 10;
            this.tagProximaVersion.FillColor = System.Drawing.Color.FromArgb(238, 242, 244);
            this.tagProximaVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tagProximaVersion.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.tagProximaVersion.HoverState.FillColor = System.Drawing.Color.FromArgb(238, 242, 244);
            this.tagProximaVersion.Location = new System.Drawing.Point(214, 8);
            this.tagProximaVersion.Name = "tagProximaVersion";
            this.tagProximaVersion.Size = new System.Drawing.Size(120, 22);
            this.tagProximaVersion.TabIndex = 1;
            this.tagProximaVersion.TabStop = false;
            this.tagProximaVersion.Text = "Próxima versión";
            //
            // lblPasarelaDesc
            //
            this.lblPasarelaDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblPasarelaDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPasarelaDesc.ForeColor = System.Drawing.Color.FromArgb(107, 122, 131);
            this.lblPasarelaDesc.Location = new System.Drawing.Point(16, 32);
            this.lblPasarelaDesc.Name = "lblPasarelaDesc";
            this.lblPasarelaDesc.Size = new System.Drawing.Size(318, 46);
            this.lblPasarelaDesc.TabIndex = 2;
            this.lblPasarelaDesc.Text = "Cobro con tarjeta y Yape desde el sistema, con verificación automática del pago. Por ahora el pago se registra a mano con su N.° de operación.";
            //
            // frmPagos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(238, 243, 245);
            this.ClientSize = new System.Drawing.Size(1168, 726);
            this.Controls.Add(this.pnlPasarela);
            this.Controls.Add(this.pnlRegistrarPago);
            this.Controls.Add(this.pnlPagosHoy);
            this.Controls.Add(this.pnlCargos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.Text = "DentoTacna — Pagos";
            this.pnlPasarela.ResumeLayout(false);
            this.pnlPasarela.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.pnlOperacion.ResumeLayout(false);
            this.pnlOperacion.PerformLayout();
            this.pnlRegistrarPago.ResumeLayout(false);
            this.pnlRegistrarPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosHoy)).EndInit();
            this.pnlPagosHoy.ResumeLayout(false);
            this.pnlPagosHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.pnlCargos.ResumeLayout(false);
            this.pnlCargos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlCargos;
        private System.Windows.Forms.Label lblCargos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCargos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private Guna.UI2.WinForms.Guna2Panel pnlPagosHoy;
        private System.Windows.Forms.Label lblPagosHoy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPagosHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConceptoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportePago;
        private System.Windows.Forms.Label lblResumenMetodos;
        private System.Windows.Forms.Label lblTotalDia;
        private Guna.UI2.WinForms.Guna2Panel pnlRegistrarPago;
        private System.Windows.Forms.Label lblRegistrarPago;
        private System.Windows.Forms.Label lblPaciente;
        private Guna.UI2.WinForms.Guna2TextBox txtPaciente;
        private System.Windows.Forms.Label lblTipoPago;
        private Guna.UI2.WinForms.Guna2RadioButton rbPagoTotal;
        private Guna.UI2.WinForms.Guna2RadioButton rbACuenta;
        private System.Windows.Forms.Label lblMetodo;
        private Guna.UI2.WinForms.Guna2ComboBox cboMetodo;
        private System.Windows.Forms.Panel pnlOperacion;
        private System.Windows.Forms.Label lblOperacion;
        private Guna.UI2.WinForms.Guna2TextBox txtOperacion;
        private System.Windows.Forms.Label lblRecibo;
        private Guna.UI2.WinForms.Guna2TextBox txtRecibo;
        private System.Windows.Forms.Label lblMonto;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private Guna.UI2.WinForms.Guna2Panel pnlResumen;
        private System.Windows.Forms.Label lblSeleccionadoTexto;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label lblVueltoTexto;
        private System.Windows.Forms.Label lblVuelto;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnCobrar;
        private Guna.UI2.WinForms.Guna2Panel pnlPasarela;
        private System.Windows.Forms.Label lblPasarela;
        private Guna.UI2.WinForms.Guna2Button tagProximaVersion;
        private System.Windows.Forms.Label lblPasarelaDesc;
    }
}
