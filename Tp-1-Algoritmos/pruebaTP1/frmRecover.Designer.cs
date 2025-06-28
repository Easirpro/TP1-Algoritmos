
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
            lblCorreoIngresar = new Label();
            txtCorreo = new TextBox();
            btnEnviarCodigo = new Button();
            lblError = new Label();
            lblCodigoIngresar = new Label();
            txtCodigo = new TextBox();
            btnVerificarCodigo = new Button();
            lblnewPass = new Label();
            txtnewPass = new TextBox();
            lblconfirmar = new Label();
            txtconfirmar = new TextBox();
            btnconfirmar = new Button();
            SuspendLayout();
            // 
            // lblCorreoIngresar
            // 
            lblCorreoIngresar.Location = new Point(75, 66);
            lblCorreoIngresar.Name = "lblCorreoIngresar";
            lblCorreoIngresar.Size = new Size(164, 19);
            lblCorreoIngresar.TabIndex = 0;
            lblCorreoIngresar.Text = "Ingrese su correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(75, 88);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(154, 23);
            txtCorreo.TabIndex = 1;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(92, 114);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(108, 23);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click_1;
            // 
            // lblError
            // 
            lblError.BackColor = Color.WhiteSmoke;
            lblError.FlatStyle = FlatStyle.System;
            lblError.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = SystemColors.ActiveCaptionText;
            lblError.Location = new Point(41, 9);
            lblError.Name = "lblError";
            lblError.Size = new Size(242, 57);
            lblError.TabIndex = 6;
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            lblError.Click += lblError_Click;
            // 
            // lblCodigoIngresar
            // 
            lblCodigoIngresar.Location = new Point(75, 140);
            lblCodigoIngresar.Name = "lblCodigoIngresar";
            lblCodigoIngresar.Size = new Size(164, 19);
            lblCodigoIngresar.TabIndex = 7;
            lblCodigoIngresar.Text = "Ingrese el código recibido";
            lblCodigoIngresar.Visible = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(75, 162);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 8;
            txtCodigo.Visible = false;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // btnVerificarCodigo
            // 
            btnVerificarCodigo.Location = new Point(92, 191);
            btnVerificarCodigo.Name = "btnVerificarCodigo";
            btnVerificarCodigo.Size = new Size(108, 23);
            btnVerificarCodigo.TabIndex = 9;
            btnVerificarCodigo.Text = "Verificar";
            btnVerificarCodigo.UseVisualStyleBackColor = true;
            btnVerificarCodigo.Visible = false;
            btnVerificarCodigo.Click += btnVerificarCodigo_Click_1;
            // 
            // lblnewPass
            // 
            lblnewPass.Location = new Point(75, 217);
            lblnewPass.Name = "lblnewPass";
            lblnewPass.Size = new Size(164, 19);
            lblnewPass.TabIndex = 11;
            lblnewPass.Text = "Nueva contraseña";
            lblnewPass.Visible = false;
            // 
            // txtnewPass
            // 
            txtnewPass.Location = new Point(75, 239);
            txtnewPass.Name = "txtnewPass";
            txtnewPass.Size = new Size(154, 23);
            txtnewPass.TabIndex = 12;
            txtnewPass.Visible = false;
            txtnewPass.TextChanged += txtnewPass_TextChanged;
            // 
            // lblconfirmar
            // 
            lblconfirmar.Location = new Point(75, 265);
            lblconfirmar.Name = "lblconfirmar";
            lblconfirmar.Size = new Size(164, 19);
            lblconfirmar.TabIndex = 13;
            lblconfirmar.Text = "Confirmar contraseña";
            lblconfirmar.Visible = false;
            // 
            // txtconfirmar
            // 
            txtconfirmar.Location = new Point(75, 287);
            txtconfirmar.Name = "txtconfirmar";
            txtconfirmar.Size = new Size(154, 23);
            txtconfirmar.TabIndex = 14;
            txtconfirmar.Visible = false;
            txtconfirmar.TextChanged += txtconfirmar_TextChanged;
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(92, 316);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(108, 23);
            btnconfirmar.TabIndex = 15;
            btnconfirmar.Text = "Confirmar";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Visible = false;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // frmRecover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 393);
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


        //private void btnEnviarCodigo_Click(object sender, EventArgs e)
        //{
        //    
        //    throw new NotImplementedException();
        //}

        //private void btnVerificarCodigo_Click(object sender, EventArgs e)
        //{
        //     
        //    throw new NotImplementedException();
        //}

        //private void btnconfirmar_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private Label lblCorreoIngresar;
        private TextBox txtCorreo;
        private Button btnEnviarCodigo;
        private Label lblError;
        private Label lblCodigoIngresar;
        private TextBox txtCodigo;
        private Button btnVerificarCodigo;
        private Label lblnewPass;
        private TextBox txtnewPass;
        private Label lblconfirmar;
        private TextBox txtconfirmar;
        private Button btnconfirmar;
    }
}