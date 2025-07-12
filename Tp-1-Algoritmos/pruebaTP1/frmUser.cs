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
        private Usuario usuario;

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
            BtnSave.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

      
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MostrarDatosUsuario();
            HabilitarEdicion(false);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPasswordUsuario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtDni.Text, out _) || !long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El DNI y el Teléfono deben ser numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos al menos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El Teléfono debe tener entre 8 a 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatosUsuario.Nombre = txtNombre.Text;
            DatosUsuario.Apellido = txtApellido.Text;
            DatosUsuario.Dni = txtDni.Text;
            DatosUsuario.Telefono = txtTelefono.Text;
            DatosUsuario.Email = txtEmail.Text;
            DatosUsuario.Password = txtPasswordUsuario.Text;

            HabilitarEdicion(false);

            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
