using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pruebaTP1
{
    public partial class frmAdmin : Form
    {
        private void frmAdmin_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public frmAdmin()
        {
            InitializeComponent();
            this.KeyDown += frmAdmin_Keydown;
            this.KeyPreview = true;

            cmbListUser.Items.Add(DatosAdmin.Nombre);
            cmbListUser.Items.Add(DatosUsuario.Nombre);
            cmbListUser.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbListUser.SelectedIndex = 0;

            MostrarDatosAdmin();
            HabilitarEdicion(false);
        }
        private void MostrarDatosAdmin()
        {
            txtNombre.Text = DatosAdmin.Nombre;
            txtApellido.Text = DatosAdmin.Apellido;
            txtDni.Text = DatosAdmin.Dni;
            txtTelefono.Text = DatosAdmin.Telefono;
            txtEmail.Text = DatosAdmin.Email;
            txtPasswordUsuario.Text = DatosAdmin.Password;
            rdbAdmin.Checked = DatosAdmin.Rol == "Administrador";
            rdbUser.Checked = DatosAdmin.Rol == "Usuario";
        }
        private void MostrarDatosUsuario()
        {
            txtNombre.Text = DatosUsuario.Nombre;
            txtApellido.Text = DatosUsuario.Apellido;
            txtDni.Text = DatosUsuario.Dni;
            txtTelefono.Text = DatosUsuario.Telefono;
            txtEmail.Text = DatosUsuario.Email;
            txtPasswordUsuario.Text = DatosUsuario.Password;
            rdbUser.Checked = DatosUsuario.Rol == "Usuario";
            rdbAdmin.Checked = DatosUsuario.Rol == "Administrador";
        }
        private void HabilitarEdicion(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtDni.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            txtPasswordUsuario.ReadOnly = !habilitar;

            rdbUser.Enabled = habilitar;
            rdbAdmin.Enabled = habilitar;

            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }
        private void MostrarDatos()
        {
            if (cmbListUser.SelectedItem != null)
            {
                string selectedOption = cmbListUser.SelectedItem.ToString();
                if (selectedOption == DatosAdmin.Nombre)
                {
                    MostrarDatosAdmin();
                }
                else if (selectedOption == DatosUsuario.Nombre)
                {
                    MostrarDatosUsuario();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
            if (txtDni.Text.Length != 8 || txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El DNI y el Teléfono deben tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbListUser.SelectedItem.ToString() == DatosAdmin.Nombre)
            {
                DatosAdmin.Nombre = txtNombre.Text;
                DatosAdmin.Apellido = txtApellido.Text;
                DatosAdmin.Dni = txtDni.Text;
                DatosAdmin.Telefono = txtTelefono.Text;
                DatosAdmin.Email = txtEmail.Text;
                DatosAdmin.Password = txtPasswordUsuario.Text;

                DatosAdmin.Rol = "Administrador";
                //Mantiene el rol del Admin inicial (Aclaracion: para no perder el admin de la "app")
            }
            else if (cmbListUser.SelectedItem.ToString() == DatosUsuario.Nombre)
            {
                DatosUsuario.Nombre = txtNombre.Text;
                DatosUsuario.Apellido = txtApellido.Text;
                DatosUsuario.Dni = txtDni.Text;
                DatosUsuario.Telefono = txtTelefono.Text;
                DatosUsuario.Email = txtEmail.Text;
                DatosUsuario.Password = txtPasswordUsuario.Text;

                DatosUsuario.Rol = rdbUser.Checked ? "Usuario" : "Administrador";
            }

            HabilitarEdicion(false);
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarDatosAdmin();
            HabilitarEdicion(false);
        }

        private void grpRol_Enter(object sender, EventArgs e)
        {

        }
    }
}
