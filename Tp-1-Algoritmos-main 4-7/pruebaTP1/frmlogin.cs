namespace pruebaTP1
{
    partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
            VerificarCampos();
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
            VerificarCampos();
        }

        private void Txtpass_TextChanged(object? sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void Txtusuario_TextChanged_1(object? sender, EventArgs e)
        {
        }

        private void Btnenter_Click(object sender, EventArgs e)
        {
            if (Txtusuario.Text == DatosAdmin.Nombre && Txtpass.Text == DatosAdmin.Password)
        {
        this.Hide();
        if (DatosAdmin.Rol == "Administrador")
        {
            frmAdmin form = new frmAdmin();
            form.ShowDialog();
        }
        else
        {
            frmUser form = new frmUser();
            form.ShowDialog();
        }
        this.Show();
        }
        else if (Txtusuario.Text == DatosUsuario.Nombre && Txtpass.Text == DatosUsuario.Password)
        {
        this.Hide();
        if (DatosUsuario.Rol == "Administrador")
        {
            frmAdmin form = new frmAdmin();
            form.Show();
        }
        else
        {
            frmUser form = new frmUser();
            form.Show();
        }
        this.Show();
        }
        else
        {
        MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
