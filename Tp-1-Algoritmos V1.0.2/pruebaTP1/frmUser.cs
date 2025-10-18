using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pruebaTP1
{
    public partial class frmUser : Form
    {
        private User usuario; // campo privado para guardar el usuario logueado

        // Constructor que recibe el objeto Usuario desde frmLogin
        public frmUser(User usuario)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmUser_Keydown;

            this.usuario = usuario;

            MostrarDatosUsuario();   // carga los datos en los controles
            HabilitarEdicion(false); // deshabilita edición al inicio
        }

        private void frmUser_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        //Muestra los datos del usuario en los TextBox
        private void MostrarDatosUsuario()
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtDni.Text = usuario.Dni;
            txtTelefono.Text = usuario.Telefono;
            txtEmail.Text = usuario.Email;
            txtPasswordUsuario.Text = usuario.Password;
        }

        //Habilita o deshabilita la edición de los campos
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordUsuario.Text))
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
                MessageBox.Show("El DNI debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El Teléfono debe tener entre 8 y 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Actualizar el objeto usuario con los nuevos datos
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Dni = txtDni.Text;
            usuario.Telefono = txtTelefono.Text;
            usuario.Email = txtEmail.Text;
            usuario.Password = txtPasswordUsuario.Text;
            DBAccess db = new DBAccess();
            OleDbConnection conexion = db.GetConnection();
            conexion.Open();
            //Consulta para actualizar los datos del usuario
            string query = "UPDATE datos SET " +
                "nombre = '" + usuario.Nombre + "', " +
                "apellido = '" + usuario.Apellido + "', " +
                "telefono = '" + usuario.Telefono + "', " +
                "email = '" + usuario.Email + "', " +
                "[password] = '" + usuario.Password + "' " +
                "WHERE dni = " + usuario.Dni;


            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery(); 
            conexion.Close();


            HabilitarEdicion(false);
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MostrarDatosUsuario();   
            HabilitarEdicion(false); 
        }
    }
}