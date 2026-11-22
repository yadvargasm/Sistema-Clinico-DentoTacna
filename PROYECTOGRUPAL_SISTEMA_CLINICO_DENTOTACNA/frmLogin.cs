using System;
using System.Windows.Forms;

namespace PROYECTOGRUPAL_SISTEMA_CLINICO_DENTOTACNA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Tema.Aplicar(this);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = !txtContrasenia.UseSystemPasswordChar;
            btnMostrar.Text = txtContrasenia.UseSystemPasswordChar ? "Mostrar" : "Ocultar";
        }

        // Enter en usuario pasa a la contraseña; Enter en la contraseña ingresa.
        private void txtCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            if (sender == txtUsuario)
                txtContrasenia.Focus();
            else
                btnIngresar.PerformClick();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim().ToLowerInvariant();
            string contrasena = txtContrasenia.Text;

            // TODO (pendiente BD): validar contra dbo.Usuario con SHA-256 + sal desde la Capa de Negocio.
            // Mientras tanto se aceptan los usuarios de prueba del prototipo con cualquier contraseña.
            string[] datos = BuscarUsuarioPrueba(usuario);
            if (datos == null || contrasena == "")
            {
                pnlError.Visible = true;
                return;
            }

            pnlError.Visible = false;
            var principal = new frmPrincipal(datos[0], datos[1], datos[2], datos[3]);

            Hide();
            principal.ShowDialog();

            if (principal.CerroSesion)
            {
                txtContrasenia.Clear();
                Show();
                txtContrasenia.Focus();
            }
            else
            {
                Close();
            }
        }

        private static string[] BuscarUsuarioPrueba(string usuario)
        {
            foreach (string[] u in DatosDemo.Usuarios)
            {
                if (u[0] == usuario) return u;
            }
            return null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
