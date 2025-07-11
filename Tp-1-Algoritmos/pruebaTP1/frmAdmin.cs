using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pruebaTP1
{
    public partial class frmAdmin : Form
    {
        bool esNuevo = false;
        string nombreUsuarioLogueado;
        string rolUsuarioLogueado;

        public frmAdmin(string nombreUsuario, string rolUsuario)
        {
            InitializeComponent();
            nombreUsuarioLogueado = nombreUsuario;
            rolUsuarioLogueado = rolUsuario;

            cmbListUser.Items.Add(DatosAdmin.Nombre);
            cmbListUser.Items.Add(DatosUsuario.Nombre);
            foreach (var usuario in Usuarios.Lista)
            {
                if (!cmbListUser.Items.Contains(usuario.Nombre))
                    cmbListUser.Items.Add(usuario.Nombre);
            }
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
            if (nombreUsuarioLogueado == DatosAdmin.Nombre && rolUsuarioLogueado == "Administrador")
            {
                txtPasswordUsuario.Text = DatosAdmin.Password;
                txtPasswordUsuario.ReadOnly = false;
            }
            else
            {
                txtPasswordUsuario.Text = "******";
                txtPasswordUsuario.ReadOnly = true;
            }
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
            rdbUser.Checked = DatosUsuario.Rol == "Usuario";
            rdbAdmin.Checked = DatosUsuario.Rol == "Administrador";

            if (nombreUsuarioLogueado == DatosUsuario.Nombre && rolUsuarioLogueado == DatosUsuario.Rol)
            {
                txtPasswordUsuario.Text = DatosUsuario.Password;
                txtPasswordUsuario.ReadOnly = false;
            }
            else
            {
                txtPasswordUsuario.Text = "******";
                txtPasswordUsuario.ReadOnly = true;
            }

        }

        private void HabilitarEdicion(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtDni.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            rdbUser.Enabled = habilitar;
            rdbAdmin.Enabled = habilitar;
            BtnSave.Enabled = habilitar;
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
                else
                {
                    var usuario = Usuarios.Lista.FirstOrDefault(u => u.Nombre == selectedOption);
                    if (usuario != null)
                    {
                        txtNombre.Text = usuario.Nombre;
                        txtApellido.Text = usuario.Apellido;
                        txtDni.Text = usuario.Dni;
                        txtTelefono.Text = usuario.Telefono;
                        txtEmail.Text = usuario.Email;
                        txtPasswordUsuario.Text = usuario.Password;
                        rdbUser.Checked = usuario.Rol == "Usuario";
                        rdbAdmin.Checked = usuario.Rol == "Administrador";
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPasswordUsuario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(txtDni.Text, out _) || !long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El DNI y el Teléfono deben ser numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDni.Text.Length < 7 || txtDni.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener 7 o 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El Teléfono debe tener entre 8 a 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else if (cmbListUser.SelectedItem.ToString() == DatosUsuario.Nombre)
            {
                DatosUsuario.Nombre = txtNombre.Text;
                DatosUsuario.Apellido = txtApellido.Text;
                DatosUsuario.Dni = txtDni.Text;
                DatosUsuario.Telefono = txtTelefono.Text;
                DatosUsuario.Email = txtEmail.Text;
                DatosAdmin.Password = txtPasswordUsuario.Text;
                DatosUsuario.Rol = rdbUser.Checked ? "Usuario" : "Administrador";
            }
            if (esNuevo)
            {
                string nombreNuevo = txtNombre.Text;
                int index = cmbListUser.Items.IndexOf("Usuario Nuevo");
                if (index != -1)
                {
                    cmbListUser.Items[index] = nombreNuevo;
                    cmbListUser.SelectedIndex = index;
                }
                else if (!cmbListUser.Items.Contains(nombreNuevo))
                {
                    cmbListUser.Items.Add(nombreNuevo);
                    cmbListUser.SelectedItem = nombreNuevo;
                }
                if (!Usuarios.Lista.Any(u => u.Dni == txtDni.Text))
                {
                    Usuario nuevoUsuario = new Usuario
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Dni = txtDni.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text,
                        Password = txtPasswordUsuario.Text,
                        Rol = rdbUser.Checked ? "Usuario" : "Administrador"
                    };
                    Usuarios.Lista.Add(nuevoUsuario);
                }
                esNuevo = false;
            }
            HabilitarEdicion(false);
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreNuevo = "Usuario Nuevo";
            if (!cmbListUser.Items.Contains(nombreNuevo))
            {
                cmbListUser.Items.Add(nombreNuevo);
            }
            cmbListUser.SelectedItem = nombreNuevo;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtPasswordUsuario.Text = "";
            rdbUser.Checked = true;
            rdbAdmin.Checked = false;

            HabilitarEdicion(true);
            esNuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            string nombreNuevo = "Usuario Nuevo";
            if (cmbListUser.Items.Contains(nombreNuevo))
            {
                cmbListUser.Items.Remove(nombreNuevo);
            }

            cmbListUser.SelectedItem = DatosAdmin.Nombre;
            MostrarDatosAdmin();
            HabilitarEdicion(false);
        }
    }
}

