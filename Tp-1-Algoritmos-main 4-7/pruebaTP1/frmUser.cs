using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaTP1
{

    public partial class frmUser : Form
    {
        private void frmUser_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public frmUser()
        {
            InitializeComponent();
            this.AcceptButton = btnGuardar;
            this.AcceptButton = btnCancelar;
            this.AcceptButton = btnModificar;
            this.KeyPreview = true;
            this.KeyDown += frmUser_Keydown;

            MostrarDatosUsuario();
            HabilitarEdicion(false);

        }
        private void MostrarDatosUsuario()
        {
            txtNombre.Text = DatosUsuario.Nombre;
            txtApellido.Text = DatosUsuario.Apellido;
            txtDni.Text = DatosUsuario.Dni;
            txtTelefono.Text = DatosUsuario.Telefono;
            txtEmail.Text = DatosUsuario.Email;
            txtPasswordUsuario.Text = DatosUsuario.Password;
        }
        private void HabilitarEdicion(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtDni.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            txtPasswordUsuario.ReadOnly = !habilitar;
            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DatosUsuario.Nombre = txtNombre.Text;
            DatosUsuario.Apellido = txtApellido.Text;
            DatosUsuario.Dni = txtDni.Text;
            DatosUsuario.Telefono = txtTelefono.Text;
            DatosUsuario.Email = txtEmail.Text;
            DatosUsuario.Password = txtPasswordUsuario.Text;

            HabilitarEdicion(false);
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MostrarDatosUsuario();
            HabilitarEdicion(false);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }
    }
}
