namespace pruebaTP1
{
    partial class Frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            Lbluser = new Label();
            Txtusuario = new TextBox();
            Txtpass = new TextBox();
            Lblpass = new Label();
            Btnenter = new Button();
            Lnkrecu = new LinkLabel();
            SuspendLayout();
            // 
            // Lbluser
            // 
            resources.ApplyResources(Lbluser, "Lbluser");
            Lbluser.Name = "Lbluser";
            // 
            // Txtusuario
            // 
            resources.ApplyResources(Txtusuario, "Txtusuario");
            Txtusuario.BorderStyle = BorderStyle.FixedSingle;
            Txtusuario.Name = "Txtusuario";
            Txtusuario.TextChanged += Txtusuario_TextChanged_1;
            // 
            // Txtpass
            // 
            resources.ApplyResources(Txtpass, "Txtpass");
            Txtpass.Name = "Txtpass";
            Txtpass.Tag = "";
            // 
            // Lblpass
            // 
            resources.ApplyResources(Lblpass, "Lblpass");
            Lblpass.Name = "Lblpass";
            // 
            // Btnenter
            // 
            resources.ApplyResources(Btnenter, "Btnenter");
            Btnenter.Cursor = Cursors.Hand;
            Btnenter.Name = "Btnenter";
            Btnenter.UseVisualStyleBackColor = true;
            Btnenter.Click += Btnenter_Click;
            // 
            // Lnkrecu
            // 
            resources.ApplyResources(Lnkrecu, "Lnkrecu");
            Lnkrecu.Name = "Lnkrecu";
            Lnkrecu.TabStop = true;
            Lnkrecu.LinkClicked += lnkrecu_LinkClicked;
            // 
            // Frmlogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Lnkrecu);
            Controls.Add(Btnenter);
            Controls.Add(Txtpass);
            Controls.Add(Lblpass);
            Controls.Add(Txtusuario);
            Controls.Add(Lbluser);
            HelpButton = true;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Frmlogin";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbluser;
        private TextBox Txtusuario;
        private TextBox Txtpass;
        private Label Lblpass;
        private Button Btnenter;
        private LinkLabel Lnkrecu;
    }
}
