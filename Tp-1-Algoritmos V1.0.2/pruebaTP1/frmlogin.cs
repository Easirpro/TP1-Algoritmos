using System.Data;
using System.Data.OleDb;
namespace pruebaTP1
{

    partial class Frmlogin : Form
    {

        public Frmlogin()
        {

            InitializeComponent();
            Txtpass.TextChanged += Txtpass_TextChanged;
            Txtusuario.TextChanged += Txtusuario_TextChanged;
            this.HelpButtonClicked += Helpbutton1_Click;
            this.AcceptButton = Btnenter;
        }

        private void Helpbutton1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Ingrese su currentUser y contraseña para acceder.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkrecu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecover form = new frmRecover();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void Txtusuario_TextChanged(object? sender, EventArgs e)
        {
        }
        private void Txtpass_TextChanged(object? sender, EventArgs e)
        {
        }
        private void Txtusuario_TextChanged_1(object? sender, EventArgs e)
        {
        }
        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
        private void Btnenter_Click(object sender, EventArgs e)
        {
            using var conexion = new DBAccess().GetConnection(); 
            string consulta = "SELECT * FROM datos WHERE nombre='" + Txtusuario.Text + "' AND password='" + Txtpass.Text + "'";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            if (datos.Rows.Count == 1)
            {
                string rol = datos.Rows[0]["Rol"].ToString();
                this.Hide();
                if (rol == "Administrador")
                {
                    frmAdmin form = new frmAdmin(Txtusuario.Text, rol);
                    form.ShowDialog();
                }
                else
                {
                    User currentUser = new User
                    {
                        Nombre = datos.Rows[0]["nombre"].ToString(),
                        Apellido = datos.Rows[0]["apellido"].ToString(),
                        Dni = datos.Rows[0]["dni"].ToString(),
                        Telefono = datos.Rows[0]["telefono"].ToString(),
                        Email = datos.Rows[0]["email"].ToString(),
                        Password = datos.Rows[0]["password"].ToString(),
                        Rol = datos.Rows[0]["Rol"].ToString()
                    };
                    frmUser form = new frmUser(currentUser);
                    form.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}