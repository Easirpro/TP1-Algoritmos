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
        string correoVerificado;
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
            correoVerificado = correo;

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
            string nuevaPass = txtnewPass.Text;
            string confirmarPass = txtconfirmar.Text;

            if (string.IsNullOrEmpty(nuevaPass) || string.IsNullOrEmpty(confirmarPass))
            {
                lblError.Text = "Los campos deben estar completos";
                lblError.Visible = true;
                return;
            }
            if (nuevaPass != confirmarPass)
            {
                lblError.Text = "Las contraseñas no coinciden";
                return;
            }
            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (correoVerificado == DatosAdmin.Email )
            {
                DatosAdmin.Password = nuevaPass;
            }
            else if(correoVerificado == DatosUsuario.Email)
            {
                DatosUsuario.Password = nuevaPass;
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
