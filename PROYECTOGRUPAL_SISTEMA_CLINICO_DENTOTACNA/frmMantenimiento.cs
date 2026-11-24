using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmMantenimiento : Form
    {
        clsOdontologo_N objOdontologo = new clsOdontologo_N();
        clsEspecialidad_N objEspecialidad = new clsEspecialidad_N();
        clsTratamiento_N objTratamiento = new clsTratamiento_N();

        private int idOdontologo = -1;
        private int idTratamiento = -1;
        public frmMantenimiento()
        {
            InitializeComponent();
        }
        private void mtdListarOdontologos()
        {
            dgvOdontologos.DataSource =
                objOdontologo.mtdListarOdontologos();

            dgvOdontologos.ClearSelection();
            dgvOdontologos.CurrentCell = null;
        }
        private void mtdListarTratamientos()
        {
            dgvTratamientos.DataSource =
                objTratamiento.mtdListarTratamientos();

            dgvTratamientos.ClearSelection();
            dgvTratamientos.CurrentCell = null;
        }
        private void mtdListarEspecialidades()
        {
            cmbEspecialidad.DataSource =
                objEspecialidad.mtdListarEspecialidades();

            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool mtdValidarOdontologo()
        {
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string cop = txtCop.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (nombres == "")
            {
                MessageBox.Show("Ingrese los nombres");
                txtNombres.Focus();
                return false;
            }

            if (apellidos == "")
            {
                MessageBox.Show("Ingrese los apellidos.");
                txtApellidos.Focus();
                return false;
            }

            if (cop == "")
            {
                MessageBox.Show("Ingrese el número COP.");
                txtCop.Focus();
                return false;
            }


            if (telefono.Length != 9 ||
                telefono[0] != '9')
            {
                MessageBox.Show(
                    "El teléfono debe tener exactamente " +
                    "9 dígitos y comenzar con 9.");
                txtTelefono.Focus();
                return false;
            }

            if (cmbEspecialidad.SelectedIndex == -1 ||
                cmbEspecialidad.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione una especialidad.");
                cmbEspecialidad.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardarOdontologo_Click(object sender, EventArgs e)
        {
            if (!mtdValidarOdontologo())
                return;

            try
            {
                clsOdontologo odontologo = new clsOdontologo();

                odontologo.nombres = txtNombres.Text.Trim();
                odontologo.apellidos = txtApellidos.Text.Trim();
                odontologo.numeroCOP = txtCop.Text.Trim();
                odontologo.telefono = txtTelefono.Text.Trim();

                odontologo.idEspecialidad =
                    Convert.ToInt32(cmbEspecialidad.SelectedValue);

                objOdontologo.mtdRegistrarOdontologo(odontologo);

                MessageBox.Show(
                    "Odontólogo registrado correctamente.");

                mtdListarOdontologos();
                mtdLimpiarOdontologo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idOdontologo == -1)
            {
                MessageBox.Show(
                    "Seleccione un odontólogo para actualizar.");
                return;
            }

            if (!mtdValidarOdontologo())
                return;

            try
            {
                clsOdontologo odontologo = new clsOdontologo();

                odontologo.idOdontologo = idOdontologo;
                odontologo.nombres = txtNombres.Text.Trim();
                odontologo.apellidos = txtApellidos.Text.Trim();
                odontologo.numeroCOP = txtCop.Text.Trim();
                odontologo.telefono = txtTelefono.Text.Trim();

                odontologo.idEspecialidad =
                    Convert.ToInt32(cmbEspecialidad.SelectedValue);

                objOdontologo.mtdActualizarOdontologo(odontologo);

                MessageBox.Show(
                    "Odontólogo actualizado correctamente.");

                mtdListarOdontologos();
                mtdLimpiarOdontologo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarOdontologo_Click(object sender, EventArgs e)
        {
            if (idOdontologo == -1)
            {
                MessageBox.Show(
                    "Seleccione un odontólogo para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este odontólogo?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                objOdontologo.mtdEliminarOdontologo(idOdontologo);

                MessageBox.Show(
                    "Operación realizada correctamente.");

                mtdListarOdontologos();
                mtdLimpiarOdontologo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOdontologos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvOdontologos.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;

            idOdontologo = Convert.ToInt32(
                fila.Cells["IdOdontologo"].Value);

            txtNombres.Text = Convert.ToString(
                fila.Cells["Nombres"].Value);

            txtApellidos.Text = Convert.ToString(
                fila.Cells["Apellidos"].Value);

            txtCop.Text = Convert.ToString(
                fila.Cells["NumeroCOP"].Value);

            txtTelefono.Text = Convert.ToString(
                fila.Cells["Telefono"].Value);

            cmbEspecialidad.SelectedValue =Convert.ToInt32(fila.Cells["IdEspecialidad"].Value);
            
        }
        private void mtdLimpiarOdontologo()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCop.Clear();
            txtTelefono.Clear();

            cmbEspecialidad.SelectedIndex = -1;
            idOdontologo = -1;

            dgvOdontologos.ClearSelection();
            dgvOdontologos.CurrentCell = null;
        }
        private bool mtdValidarTratamiento()
        {
            string nombre = txtNombreTratamiento.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string textoPrecio = txtPrecio.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre del tratamiento.");
                txtNombreTratamiento.Focus();
                return false;
            }

            if (textoPrecio == "")
            {
                MessageBox.Show("Ingrese el precio");
                txtPrecio.Focus();
                return false;
            }

            if(descripcion=="")
            {
                MessageBox.Show("Ingrese la descripción del tratamiento");
                txtDescripcion.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio<=0)
            {
                MessageBox.Show("Ingrese un precio válido");
                txtPrecio.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardarTratamiento_Click(object sender, EventArgs e)
        {

            if (!mtdValidarTratamiento())
                return;

            try
            {
                clsTratamiento tratamiento = new clsTratamiento();

                tratamiento.nombre =
                    txtNombreTratamiento.Text.Trim();

                tratamiento.descripcion =
                    txtDescripcion.Text.Trim();

                tratamiento.precio = Convert.ToDecimal(txtPrecio.Text);

                tratamiento.duracionMin =
                    Convert.ToInt32(nudDuracion.Value);

                objTratamiento.mtdRegistrarTratamiento(tratamiento);

                MessageBox.Show(
                    "Tratamiento registrado correctamente.");

                mtdListarTratamientos();
                mtdLimpiarTratamiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizarTratamiento_Click(object sender, EventArgs e)
        {
            if (idTratamiento == -1)
            {
                MessageBox.Show(
                    "Seleccione un tratamiento para actualizar");
                return;
            }

            decimal precio;

            if (!mtdValidarTratamiento())
                return;

            try
            {
                clsTratamiento tratamiento = new clsTratamiento();

                tratamiento.idTratamiento = idTratamiento;

                tratamiento.nombre =
                    txtNombreTratamiento.Text.Trim();

                tratamiento.descripcion =
                    txtDescripcion.Text.Trim();

                tratamiento.precio = Convert.ToDecimal(txtPrecio.Text);

                tratamiento.duracionMin =
                    Convert.ToInt32(nudDuracion.Value);

                objTratamiento.mtdActualizarTratamiento(tratamiento);

                MessageBox.Show(
                    "Tratamiento actualizado correctamente.");

                mtdListarTratamientos();
                mtdLimpiarTratamiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarTratamiento_Click(object sender, EventArgs e)
        {
            if (idTratamiento == -1)
            {
                MessageBox.Show(
                    "Seleccione un tratamiento para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este tratamiento?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                objTratamiento.mtdEliminarTratamiento(idTratamiento);

                MessageBox.Show(
                    "Operación realizada correctamente.");

                mtdListarTratamientos();
                mtdLimpiarTratamiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =dgvTratamientos.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;

            idTratamiento = Convert.ToInt32(
                fila.Cells["IdTratamiento"].Value);

            txtNombreTratamiento.Text = Convert.ToString(
                fila.Cells["Nombre"].Value);

            txtDescripcion.Text = Convert.ToString(
                fila.Cells["Descripcion"].Value);

            decimal precio = Convert.ToDecimal(
                fila.Cells["Precio"].Value);

            txtPrecio.Text = precio.ToString(
                "0.00", CultureInfo.InvariantCulture);

            decimal duracion = Convert.ToDecimal(
                fila.Cells["DuracionMin"].Value);

            nudDuracion.Value = duracion;
        }
        private void mtdLimpiarTratamiento()
        {
            txtNombreTratamiento.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();

            nudDuracion.Value = 30;
            idTratamiento = -1;

            dgvTratamientos.ClearSelection();
            dgvTratamientos.CurrentCell = null;
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            mtdListarEspecialidades();
            mtdListarOdontologos();
            mtdLimpiarOdontologo();
            mtdLimpiarTratamiento();
            mtdListarTratamientos();
            dgvOdontologos.Columns["IdOdontologo"].Visible = false;
            dgvOdontologos.Columns["IdEspecialidad"].Visible = false;
            dgvTratamientos.Columns["IdTratamiento"].Visible = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !='.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiarDatOd_Click(object sender, EventArgs e)
        {
            mtdLimpiarOdontologo();
        }

        private void btnLimpiarDatTrat_Click(object sender, EventArgs e)
        {
            mtdLimpiarTratamiento();
        }

        private void txtNombreTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
