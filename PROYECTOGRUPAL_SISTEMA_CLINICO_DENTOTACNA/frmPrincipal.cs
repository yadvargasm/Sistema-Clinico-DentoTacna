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
    public partial class frmPrincipal : Form
    {
        private readonly Color colorMenu = Color.FromArgb(15, 124, 128);
        private readonly Color colorMenuActivo = Color.FromArgb(9, 89, 93);

        private Form formularioActual;

        public frmPrincipal()
        {
            InitializeComponent();
            MarcarBotonActivo(btnInicio);
        }

        public frmPrincipal(string nombreUsuario, string rolUsuario) : this()
        {
            lblNombreUsuario.Text = nombreUsuario;
            lblRolUsuario.Text = rolUsuario;
        }

        // Muestra un formulario dentro del área de contenido, encima del panel principal.
        private void AbrirFormulario(Form formulario, Guna.UI2.WinForms.Guna2Button boton)
        {
            CerrarFormularioActual();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Bounds = pnlArea.ClientRectangle;
            formulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pnlArea.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();

            formularioActual = formulario;
            MarcarBotonActivo(boton);
        }

        private void CerrarFormularioActual()
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
                formularioActual.Dispose();
                formularioActual = null;
            }
        }

        private void MarcarBotonActivo(Guna.UI2.WinForms.Guna2Button activo)
        {
            var botones = new[] { btnInicio, btnCitas, btnPacientes, btnAtenciones, btnPagos, btnAsistente, btnMantenimiento };

            foreach (var boton in botones)
            {
                bool esActivo = boton == activo;
                boton.FillColor = esActivo ? colorMenuActivo : colorMenu;
                boton.Font = new Font("Segoe UI", 9.75F, esActivo ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CerrarFormularioActual();
            MarcarBotonActivo(btnInicio);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCitas(), btnCitas);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacientes(), btnPacientes);
        }

        private void btnAtenciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAtenciones(), btnAtenciones);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPagos(), btnPagos);
        }

        private void btnAsistente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAsistente(), btnAsistente);
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMantenimiento(), btnMantenimiento);
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCitas(), btnCitas);
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacientes(), btnPacientes);
        }
    }
}
