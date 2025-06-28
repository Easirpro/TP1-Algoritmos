namespace pruebaTP1
{
    partial class Frmlogin : Form
    {
            // Correcting the error CS0111: Duplicate constructor definitions with the same parameter types.
        // The constructors `Frmlogin(string admin)` and `Frmlogin(string user)` are conflicting.
        // To resolve this, we will merge them into a single constructor and use an additional parameter to differentiate the behavior.

        //public Frmlogin(string name, bool isAdmin)
        //{
        //    InitializeComponent();
        //    this.Text = isAdmin ? "Bienvenido Administrador " + name : "Bienvenido Usuario " + name;
        //}

        public Frmlogin()
        {
            InitializeComponent();
            VerificarCampos();
            Txtpass.TextChanged += Txtpass_TextChanged;
            Txtusuario.TextChanged += Txtusuario_TextChanged;
            this.HelpButtonClicked += Helpbutton1_Click;
        }
        private void LimpiarCamposYMostrar()
        {
            Txtusuario.Clear();
            Txtpass.Clear();
            this.Show();
            Txtusuario.Focus();
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
            LimpiarCamposYMostrar();
        }
        

        private void VerificarCampos()
        {
            Btnenter.Enabled = Txtusuario.Text.Length > 3 && Txtpass.Text.Length > 3;
        }

        private void Txtusuario_TextChanged(object? sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void Txtpass_TextChanged(object? sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void ChbTerm_CheckedChanged(object? sender, EventArgs e)
        {
        }

        private void Txtusuario_TextChanged_1(object? sender, EventArgs e)
        {
        }

        private void Btnenter_Click(object sender, EventArgs e)
        {
            if (Txtusuario.Text == "admin" && Txtpass.Text == "1234")
            {
                MessageBox.Show("Bienvenido Administrador", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                  
                frmAdmin form = new frmAdmin();
                this.Hide();
                form.ShowDialog();
                LimpiarCamposYMostrar();
            }
            else if (Txtusuario.Text == "user" && Txtpass.Text == "1234")
            {
                MessageBox.Show("Bienvenido Usuario", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

               
                frmUser form = new();
                this.Hide();
                form.ShowDialog();
                LimpiarCamposYMostrar();
            
        }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposYMostrar();
            }
        }
    }
}