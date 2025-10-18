

namespace pruebaTP1
{
    partial class frmUser
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
            txtPasswordUsuario = new TextBox();
            lblPasswordUsuario = new Label();
            btnCancelar = new Button();
            btnModificar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTituloUsuario = new Label();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPasswordUsuario.Location = new Point(134, 309);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.PlaceholderText = "Ingrese contraseña";
            txtPasswordUsuario.Size = new Size(147, 23);
            txtPasswordUsuario.TabIndex = 28;
            // 
            // lblPasswordUsuario
            // 
            lblPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPasswordUsuario.AutoSize = true;
            lblPasswordUsuario.Location = new Point(56, 317);
            lblPasswordUsuario.Name = "lblPasswordUsuario";
            lblPasswordUsuario.Size = new Size(70, 15);
            lblPasswordUsuario.TabIndex = 27;
            lblPasswordUsuario.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.AutoSize = true;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(215, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 33);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.AutoSize = true;
            btnModificar.BackColor = SystemColors.Control;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(128, 360);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 33);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(134, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese un email";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(58, 268);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(134, 218);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese un teléfono";
            txtTelefono.Size = new Size(147, 23);
            txtTelefono.TabIndex = 24;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTelefono.AutoSize = true;
            lblTelefono.Cursor = Cursors.IBeam;
            lblTelefono.Location = new Point(56, 221);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Location = new Point(134, 177);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(147, 23);
            txtDni.TabIndex = 22;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(58, 180);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 21;
            lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(134, 135);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su Apellido";
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(56, 138);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 19;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(134, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su Nombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(56, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre:\r\n";
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloUsuario.Location = new Point(86, 31);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(169, 21);
            lblTituloUsuario.TabIndex = 16;
            lblTituloUsuario.Text = "DATOS DEL USUARIO";
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSave.BackColor = SystemColors.Control;
            BtnSave.FlatStyle = FlatStyle.Popup;
            BtnSave.ForeColor = SystemColors.ControlText;
            BtnSave.Location = new Point(27, 360);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(84, 33);
            BtnSave.TabIndex = 30;
            BtnSave.Text = "GUARDAR";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 398);
            Controls.Add(BtnSave);
            Controls.Add(txtPasswordUsuario);
            Controls.Add(lblPasswordUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloUsuario);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Usuario";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox txtPasswordUsuario;
        private Label lblPasswordUsuario;
        private Button btnCancelar;
        private Button btnModificar;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTituloUsuario;
        private Button BtnSave;
    }
}