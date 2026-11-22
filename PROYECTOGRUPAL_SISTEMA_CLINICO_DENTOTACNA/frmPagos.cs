using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmPagos : Form
    {
        private int siguienteRecibo = 4519;
        private readonly Dictionary<Control, int> posicionOriginal = new Dictionary<Control, int>();

        public frmPagos()
        {
            InitializeComponent();
            Tema.Aplicar(this);
            Tema.PintarEtiquetas(dgvPagosHoy, "colTipo");

            cboMetodo.Items.AddRange(DatosDemo.MetodosPago);
            cboMetodo.SelectedIndex = 0;

            // Controles que suben cuando no se pide N.° de operación (pago en efectivo).
            foreach (Control c in new Control[] { lblRecibo, txtRecibo, lblMonto, txtMonto, pnlResumen, btnCancelar, btnCobrar })
                posicionOriginal[c] = c.Top;

            // TODO (pendiente BD): leer cargos pendientes del paciente (vw_CargoSaldo) y pagos del día (vw_Pagos).
            foreach (object[] c in DatosDemo.SaldosPlan)
            {
                decimal total = (decimal)c[4], cuenta = (decimal)c[5];
                dgvCargos.Rows.Add(c[0], c[1], c[2], c[3], Tema.Dinero(total), Tema.Dinero(cuenta), Tema.Dinero(total - cuenta));
            }
            dgvCargos.ClearSelection();
            foreach (object[] p in DatosDemo.PagosHoy)
                dgvPagosHoy.Rows.Add(p[0], p[1], p[2], p[3], p[4], p[5], p[6], Tema.Dinero((decimal)p[7]));
            dgvPagosHoy.ClearSelection();

            cboMetodo.SelectedIndexChanged += (s, e) => ActualizarFormulario();
            rbPagoTotal.CheckedChanged += (s, e) => ActualizarFormulario();
            txtMonto.TextChanged += (s, e) => ActualizarFormulario();

            ActualizarFormulario();
            ActualizarResumenDia();
        }

        private decimal TotalSeleccionado()
        {
            decimal total = 0;
            foreach (DataGridViewRow f in dgvCargos.Rows)
            {
                if (Convert.ToBoolean(f.Cells[colSel.Index].Value))
                    total += Tema.Numero(Convert.ToString(f.Cells[colSaldo.Index].Value).Replace(" ", ""));
            }
            return total;
        }

        private void ActualizarFormulario()
        {
            string metodo = Convert.ToString(cboMetodo.SelectedItem);
            bool pideOperacion = metodo != "Efectivo";
            pnlOperacion.Visible = pideOperacion;
            txtOperacion.PlaceholderText = metodo == "Tarjeta" ? "Últimos 4 dígitos / voucher" : "N.° de operación para verificar";
            foreach (var par in posicionOriginal)
                par.Key.Top = pideOperacion ? par.Value : par.Value - 64;
            pnlRegistrarPago.Height = pideOperacion ? 548 : 484;
            pnlPasarela.Top = pnlRegistrarPago.Bottom + 14;

            decimal seleccionado = TotalSeleccionado();
            decimal monto = Tema.Numero(txtMonto.Text);
            lblSeleccionado.Text = Tema.Dinero(seleccionado);

            if (rbACuenta.Checked)
            {
                lblVueltoTexto.Text = "Saldo que queda";
                lblVuelto.Text = Tema.Dinero(Math.Max(seleccionado - monto, 0));
                btnCobrar.Text = "Registrar a cuenta " + Tema.Dinero(Math.Min(monto, seleccionado));
            }
            else
            {
                lblVueltoTexto.Text = "Vuelto";
                lblVuelto.Text = Tema.Dinero(Math.Max(monto - seleccionado, 0));
                btnCobrar.Text = "Cobrar " + Tema.Dinero(seleccionado);
            }
        }

        private void ActualizarResumenDia()
        {
            decimal total = 0, efectivo = 0, tarjeta = 0, billetera = 0, transferencia = 0;
            foreach (DataGridViewRow f in dgvPagosHoy.Rows)
            {
                decimal v = Tema.Numero(Convert.ToString(f.Cells[colImportePago.Index].Value).Replace(" ", ""));
                total += v;
                switch (Convert.ToString(f.Cells[colMetodo.Index].Value))
                {
                    case "Efectivo": efectivo += v; break;
                    case "Tarjeta": tarjeta += v; break;
                    case "Yape":
                    case "Plin": billetera += v; break;
                    default: transferencia += v; break;
                }
            }
            int n = dgvPagosHoy.Rows.Count;
            lblResumenMetodos.Text = n + (n == 1 ? " pago" : " pagos") + " · Efectivo " + Tema.Dinero(efectivo) + " · Tarjeta " + Tema.Dinero(tarjeta) +
                                     " · Yape/Plin " + Tema.Dinero(billetera) + " · Transferencia " + Tema.Dinero(transferencia);
            lblTotalDia.Text = "Total del día: " + Tema.Dinero(total);
        }

        // El check de la tabla se aplica apenas se marca (sin esperar a salir de la celda).
        private void dgvCargos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCargos.IsCurrentCellDirty) dgvCargos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvCargos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colSel.Index) ActualizarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rbPagoTotal.Checked = true;
            cboMetodo.SelectedIndex = 0;
            txtOperacion.Clear();
            txtMonto.Clear();
            ActualizarFormulario();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            decimal seleccionado = TotalSeleccionado();
            decimal monto = Tema.Numero(txtMonto.Text);
            string metodo = Convert.ToString(cboMetodo.SelectedItem);

            if (seleccionado <= 0) { Aviso("Marque al menos un cargo para cobrar."); return; }
            if (monto <= 0) { Aviso("Ingrese el monto recibido."); txtMonto.Focus(); return; }
            if (metodo != "Efectivo" && txtOperacion.Text.Trim() == "") { Aviso("Ingrese el N.° de operación para poder verificar el pago."); txtOperacion.Focus(); return; }
            if (rbPagoTotal.Checked && monto < seleccionado) { Aviso("El monto recibido es menor al total. Use \"A cuenta\" para un pago parcial."); return; }

            // TODO (pendiente BD): registrar Pago + PagoDetalle con la Capa de Negocio.
            decimal aplicado = Math.Min(monto, seleccionado);
            decimal porRepartir = aplicado;
            var conceptos = new List<string>();
            foreach (DataGridViewRow f in dgvCargos.Rows)
            {
                if (!Convert.ToBoolean(f.Cells[colSel.Index].Value) || porRepartir <= 0) continue;
                decimal total = Tema.Numero(Convert.ToString(f.Cells[colTotal.Index].Value).Replace(" ", ""));
                decimal cuenta = Tema.Numero(Convert.ToString(f.Cells[colCuenta.Index].Value).Replace(" ", ""));
                decimal abono = Math.Min(total - cuenta, porRepartir);
                porRepartir -= abono;
                cuenta += abono;
                f.Cells[colCuenta.Index].Value = Tema.Dinero(cuenta);
                f.Cells[colSaldo.Index].Value = Tema.Dinero(total - cuenta);
                if (total - cuenta <= 0) f.Cells[colSel.Index].Value = false;
                conceptos.Add(Convert.ToString(f.Cells[colConcepto.Index].Value) + " " + Convert.ToString(f.Cells[colPieza.Index].Value));
            }

            string recibo = "R-" + siguienteRecibo.ToString("000000");
            dgvPagosHoy.Rows.Insert(0, DateTime.Now.ToString("HH:mm"), recibo, "María Elena Castillo", string.Join(", ", conceptos),
                rbPagoTotal.Checked ? "Total" : "A cuenta", metodo, metodo == "Efectivo" ? "—" : txtOperacion.Text.Trim(), Tema.Dinero(aplicado));
            dgvPagosHoy.ClearSelection();
            siguienteRecibo++;
            txtRecibo.Text = "R-" + siguienteRecibo.ToString("000000");
            txtOperacion.Clear();
            txtMonto.Clear();
            ActualizarResumenDia();
            ActualizarFormulario();
            Tema.Aviso(this, "Pago registrado con recibo " + recibo);
        }

        private static void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "DentoTacna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
