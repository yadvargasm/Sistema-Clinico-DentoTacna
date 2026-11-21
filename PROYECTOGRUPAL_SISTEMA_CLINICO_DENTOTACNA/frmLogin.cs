using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar == true)
            {
                txtContrasenia.UseSystemPasswordChar = false;
                btnMostrar.Text = "Ocultar";
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                btnMostrar.Text = "Mostrar";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasenia.Text;
            string rol = cboRol.Text;

            if (usuario == "" || contrasena == "" || rol == "")
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "DentoTacna Smart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            frmPrincipal frm = new frmPrincipal(usuario, rol);

            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
