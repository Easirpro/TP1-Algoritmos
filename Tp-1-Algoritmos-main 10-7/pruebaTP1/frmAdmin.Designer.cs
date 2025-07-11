namespace pruebaTP1
{
    partial class frmAdmin
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            grpRol = new GroupBox();
            rdbUser = new RadioButton();
            rdbAdmin = new RadioButton();
            cmbListUser = new ComboBox();
            txtPasswordUsuario = new TextBox();
            lblPasswordUsuario = new Label();
            btnCancelar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
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
            grpRol.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.AutoSize = true;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(186, 470);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 27);
            btnAgregar.TabIndex = 74;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpRol
            // 
            grpRol.Controls.Add(rdbUser);
            grpRol.Controls.Add(rdbAdmin);
            grpRol.Location = new Point(119, 372);
            grpRol.Name = "grpRol";
            grpRol.Size = new Size(148, 80);
            grpRol.TabIndex = 73;
            grpRol.TabStop = false;
            grpRol.Text = "Roles";
            grpRol.Enter += grpRol_Enter;
            // 
            // rdbUser
            // 
            rdbUser.AutoSize = true;
            rdbUser.Location = new Point(23, 44);
            rdbUser.Name = "rdbUser";
            rdbUser.Size = new Size(65, 19);
            rdbUser.TabIndex = 1;
            rdbUser.TabStop = true;
            rdbUser.Text = "Usuario";
            rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            rdbAdmin.AutoSize = true;
            rdbAdmin.Location = new Point(23, 19);
            rdbAdmin.Name = "rdbAdmin";
            rdbAdmin.Size = new Size(101, 19);
            rdbAdmin.TabIndex = 0;
            rdbAdmin.TabStop = true;
            rdbAdmin.Text = "Administrador";
            rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // cmbListUser
            // 
            cmbListUser.FormattingEnabled = true;
            cmbListUser.Location = new Point(122, 57);
            cmbListUser.Name = "cmbListUser";
            cmbListUser.Size = new Size(121, 23);
            cmbListUser.TabIndex = 72;
            cmbListUser.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPasswordUsuario.Location = new Point(153, 331);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.PlaceholderText = "Ingrese contraseña";
            txtPasswordUsuario.Size = new Size(147, 23);
            txtPasswordUsuario.TabIndex = 68;
            // 
            // lblPasswordUsuario
            // 
            lblPasswordUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPasswordUsuario.AutoSize = true;
            lblPasswordUsuario.Location = new Point(75, 339);
            lblPasswordUsuario.Name = "lblPasswordUsuario";
            lblPasswordUsuario.Size = new Size(70, 15);
            lblPasswordUsuario.TabIndex = 67;
            lblPasswordUsuario.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.AutoSize = true;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(273, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 27);
            btnCancelar.TabIndex = 71;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.AutoSize = true;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(96, 470);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 27);
            btnModificar.TabIndex = 70;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.AutoSize = true;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(15, 470);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 27);
            btnGuardar.TabIndex = 69;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(153, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese un email";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 66;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(77, 290);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 65;
            lblEmail.Text = "E-mail:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(153, 240);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese un teléfono";
            txtTelefono.Size = new Size(147, 23);
            txtTelefono.TabIndex = 64;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTelefono.AutoSize = true;
            lblTelefono.Cursor = Cursors.IBeam;
            lblTelefono.Location = new Point(75, 243);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 63;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Location = new Point(153, 199);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(147, 23);
            txtDni.TabIndex = 62;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(77, 202);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 61;
            lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(153, 157);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su Apellido";
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 60;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(75, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 59;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(153, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su Nombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 58;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 57;
            lblNombre.Text = "Nombre:\r\n";
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloUsuario.Location = new Point(123, 21);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(120, 21);
            lblTituloUsuario.TabIndex = 56;
            lblTituloUsuario.Text = "Administrador";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 518);
            Controls.Add(btnAgregar);
            Controls.Add(grpRol);
            Controls.Add(cmbListUser);
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
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            grpRol.ResumeLayout(false);
            grpRol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private GroupBox grpRol;
        private RadioButton rdbUser;
        private RadioButton rdbAdmin;
        private ComboBox cmbListUser;
        private TextBox txtPasswordUsuario;
        private Label lblPasswordUsuario;
        private Button btnCancelar;
        private Button btnModificar;
        private Button btnGuardar;
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
    }
}