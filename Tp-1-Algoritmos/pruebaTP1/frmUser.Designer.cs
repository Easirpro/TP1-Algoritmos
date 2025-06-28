
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
            lblTituloUsuario = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnCancelar = new Button();
            lblPasswordUsuario = new Label();
            txtPasswordUsuario = new TextBox();
            SuspendLayout();
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloUsuario.Location = new Point(81, 27);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(169, 21);
            lblTituloUsuario.TabIndex = 0;
            lblTituloUsuario.Text = "DATOS DEL USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(51, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:\r\n";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(129, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su Nombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(51, 134);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(129, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su Apellido";
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(53, 176);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Location = new Point(129, 173);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(147, 23);
            txtDni.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTelefono.AutoSize = true;
            lblTelefono.Cursor = Cursors.IBeam;
            lblTelefono.Location = new Point(51, 217);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(129, 214);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese un teléfono";
            txtTelefono.Size = new Size(147, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(53, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(129, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese un email";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.AutoSize = true;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(22, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 25);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
           // btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.AutoSize = true;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(129, 370);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 25);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.AutoSize = true;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(240, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 25);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPasswordUsuario
            // 
            lblPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPasswordUsuario.AutoSize = true;
            lblPasswordUsuario.Location = new Point(51, 313);
            lblPasswordUsuario.Name = "lblPasswordUsuario";
            lblPasswordUsuario.Size = new Size(70, 15);
            lblPasswordUsuario.TabIndex = 11;
            lblPasswordUsuario.Text = "Contraseña:";
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPasswordUsuario.Location = new Point(129, 305);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.PlaceholderText = "Ingrese contraseña";
            txtPasswordUsuario.Size = new Size(147, 23);
            txtPasswordUsuario.TabIndex = 12;
            // 
            // frmPantallaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 430);
            Controls.Add(txtPasswordUsuario);
            Controls.Add(lblPasswordUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
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
            Name = "frmPantallaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTituloUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnCancelar;
        private Label lblPasswordUsuario;
        private TextBox txtPasswordUsuario;
    }
}