
namespace pruebaTP1
{
    partial class frmRecover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnconfirmar = new Button();
            txtconfirmar = new TextBox();
            lblconfirmar = new Label();
            txtnewPass = new TextBox();
            lblnewPass = new Label();
            btnVerificarCodigo = new Button();
            txtCodigo = new TextBox();
            lblCodigoIngresar = new Label();
            lblError = new Label();
            btnEnviarCodigo = new Button();
            txtCorreo = new TextBox();
            lblCorreoIngresar = new Label();
            SuspendLayout();
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(87, 319);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(108, 23);
            btnconfirmar.TabIndex = 27;
            btnconfirmar.Text = "Confirmar";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Visible = false;
            btnconfirmar.Click += btnconfirmar_Click_1;
            // 
            // txtconfirmar
            // 
            txtconfirmar.Location = new Point(70, 290);
            txtconfirmar.Name = "txtconfirmar";
            txtconfirmar.Size = new Size(154, 23);
            txtconfirmar.TabIndex = 26;
            txtconfirmar.Visible = false;
            // 
            // lblconfirmar
            // 
            lblconfirmar.Location = new Point(70, 268);
            lblconfirmar.Name = "lblconfirmar";
            lblconfirmar.Size = new Size(164, 19);
            lblconfirmar.TabIndex = 25;
            lblconfirmar.Text = "Confirmar contraseña";
            lblconfirmar.Visible = false;
            // 
            // txtnewPass
            // 
            txtnewPass.Location = new Point(70, 242);
            txtnewPass.Name = "txtnewPass";
            txtnewPass.Size = new Size(154, 23);
            txtnewPass.TabIndex = 24;
            txtnewPass.Visible = false;
            // 
            // lblnewPass
            // 
            lblnewPass.Location = new Point(70, 220);
            lblnewPass.Name = "lblnewPass";
            lblnewPass.Size = new Size(164, 19);
            lblnewPass.TabIndex = 23;
            lblnewPass.Text = "Nueva contraseña";
            lblnewPass.Visible = false;
            // 
            // btnVerificarCodigo
            // 
            btnVerificarCodigo.Location = new Point(87, 194);
            btnVerificarCodigo.Name = "btnVerificarCodigo";
            btnVerificarCodigo.Size = new Size(108, 23);
            btnVerificarCodigo.TabIndex = 22;
            btnVerificarCodigo.Text = "Verificar";
            btnVerificarCodigo.UseVisualStyleBackColor = true;
            btnVerificarCodigo.Visible = false;
            btnVerificarCodigo.Click += btnVerificarCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(70, 165);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 21;
            txtCodigo.Visible = false;
            // 
            // lblCodigoIngresar
            // 
            lblCodigoIngresar.Location = new Point(70, 143);
            lblCodigoIngresar.Name = "lblCodigoIngresar";
            lblCodigoIngresar.Size = new Size(164, 19);
            lblCodigoIngresar.TabIndex = 20;
            lblCodigoIngresar.Text = "Ingrese el código recibido";
            lblCodigoIngresar.Visible = false;
            // 
            // lblError
            // 
            lblError.BackColor = Color.WhiteSmoke;
            lblError.FlatStyle = FlatStyle.System;
            lblError.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = SystemColors.ActiveCaptionText;
            lblError.Location = new Point(34, 9);
            lblError.Name = "lblError";
            lblError.Size = new Size(242, 57);
            lblError.TabIndex = 19;
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            lblError.Click += lblError_Click;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(87, 117);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(108, 23);
            btnEnviarCodigo.TabIndex = 18;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(70, 88);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(154, 23);
            txtCorreo.TabIndex = 17;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // lblCorreoIngresar
            // 
            lblCorreoIngresar.Location = new Point(70, 66);
            lblCorreoIngresar.Name = "lblCorreoIngresar";
            lblCorreoIngresar.Size = new Size(164, 19);
            lblCorreoIngresar.TabIndex = 16;
            lblCorreoIngresar.Text = "Ingrese su correo electrónico";
            // 
            // frmRecover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 359);
            Controls.Add(btnconfirmar);
            Controls.Add(txtconfirmar);
            Controls.Add(lblconfirmar);
            Controls.Add(txtnewPass);
            Controls.Add(lblnewPass);
            Controls.Add(btnVerificarCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigoIngresar);
            Controls.Add(lblError);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreoIngresar);
            MaximizeBox = false;
            Name = "frmRecover";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recupero de Contraseña";
            Load += frmRecover_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirmar;
        private TextBox txtconfirmar;
        private Label lblconfirmar;
        private TextBox txtnewPass;
        private Label lblnewPass;
        private Button btnVerificarCodigo;
        private TextBox txtCodigo;
        private Label lblCodigoIngresar;
        private Label lblError;
        private Button btnEnviarCodigo;
        private TextBox txtCorreo;
        private Label lblCorreoIngresar;
    }
}