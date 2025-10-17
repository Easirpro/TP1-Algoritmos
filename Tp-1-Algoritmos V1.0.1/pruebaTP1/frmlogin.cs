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
            MessageBox.Show("Ingrese su usuario y contraseña para acceder.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btnenter_Click(object sender, EventArgs e)
        {
            //Luego de Source= va la direccion de donde se encuentra el archivo de Access
            string cadena= "provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Marcelo\\Desktop\\tp algoritmos 3-10\\TP1-Algoritmos-main\\Tp-1-Algoritmos\\bin\\Debug\\net8.0-windows\\tp_algoritmo.accdb";
            string consulta="SELECT * FROM datos WHERE nombre='"+Txtusuario.Text+"' AND password='"+Txtpass.Text+"'";           
            OleDbConnection conexion = new OleDbConnection(cadena);
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            comando.Parameters.AddWithValue("@Nombre", Txtusuario.Text);
            comando.Parameters.AddWithValue("@Password", Txtpass.Text);
            if (datos.Rows.Count==1)
            {
                string rol=datos.Rows[0]["Rol"].ToString();
                this.Hide();
                if (rol=="Administrador")
                {
                    frmAdmin form = new frmAdmin(Txtusuario.Text, rol);
                    form.ShowDialog();
                }
                else
                {
                    frmUser form = new frmUser();
                    form.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (Txtusuario.Text == DatosAdmin.Nombre && Txtpass.Text == DatosAdmin.Password)
            //{
            //    this.Hide();
            //    if (DatosAdmin.Rol == "Administrador")
            //    {
            //        frmAdmin form = new frmAdmin(Txtusuario.Text, DatosAdmin.Rol);
            //        form.ShowDialog();
            //    }
            //    else
            //    {
            //        frmUser form = new frmUser();
            //        form.ShowDialog();
            //    }
            //    this.Show();
            //}
            //else if (Txtusuario.Text == DatosUsuario.Nombre && Txtpass.Text == DatosUsuario.Password)
            //{
            //    this.Hide();
            //    if (DatosUsuario.Rol == "Administrador")
            //    {
            //        frmAdmin form = new frmAdmin(Txtusuario.Text, DatosAdmin.Rol);
            //        form.ShowDialog();
            //    }
            //    else
            //    {
            //        frmUser form = new frmUser();
            //        form.ShowDialog();
            //    }
            //    this.Show();
            //}
            //    else
            //    {

            //        {
            //            MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }

}
