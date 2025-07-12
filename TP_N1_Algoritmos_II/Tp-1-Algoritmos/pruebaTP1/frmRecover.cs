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
    public partial class frmRecover : Form
    {
        string correo = DatosAdmin.Email;
        public frmRecover()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmRecover_Keydown;
        }
        private void frmRecover_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            lblError.Text = "";
            lblError.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(correo))
            {
                lblError.Text = "Por favor, ingrese su correo.";
                lblError.Visible = true;
                return;
            }

            if (correo != DatosAdmin.Email && correo != DatosUsuario.Email)
            {
                lblError.Text = "El correo no está registrado";
                lblError.Visible = true;
                return;
            }

            lblCodigoIngresar.Visible = true;
            txtCodigo.Visible = true;
            btnVerificarCodigo.Visible = true;
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                lblError.Text = "Por favor, ingrese el codigo enviado.";
                lblError.Visible = true;
                return;
            }

            if (codigo != "1234")
            {
                lblError.Text = "El codigo es incorrecto";
                lblError.Visible = true;
                return;
            }

            lblnewPass.Visible = true;
            txtnewPass.Visible = true;
            lblconfirmar.Visible = true;
            txtconfirmar.Visible = true;
            btnconfirmar.Visible = true;
        }

        private void btnconfirmar_Click_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            string paso1 = txtnewPass.Text;
            string paso2 = txtconfirmar.Text;

            if (string.IsNullOrEmpty(paso1) || string.IsNullOrEmpty(paso2))
            {
                lblError.Text = "Los campos deben estar completos";
                lblError.Visible = true;
                return;
            }
            if (paso1 != paso2)
            {
                lblError.Text = "Las contraseñas no coinciden";
                return;
            }
            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (correo == DatosAdmin.Email)
            {
                DatosAdmin.Password = paso1;
            }
            if(correo == DatosUsuario.Email)
            {
                DatosUsuario.Password = paso1;
            }
            this.Close();
        }

        private void frmRecover_Load(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
