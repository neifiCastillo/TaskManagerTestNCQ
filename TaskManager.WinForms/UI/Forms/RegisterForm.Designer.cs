namespace TaskManager.WinForms.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblpasswordComfir = new DevExpress.XtraEditors.LabelControl();
            txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            lbluserComplet = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            lblpassword = new DevExpress.XtraEditors.LabelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            lbluser = new DevExpress.XtraEditors.LabelControl();
            lblcrearAcount = new DevExpress.XtraEditors.LabelControl();
            lblsubCreat = new DevExpress.XtraEditors.LabelControl();
            lblquestion = new DevExpress.XtraEditors.LabelControl();
            lblInit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblpasswordComfir
            // 
            lblpasswordComfir.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblpasswordComfir.Appearance.Options.UseFont = true;
            lblpasswordComfir.Location = new Point(148, 382);
            lblpasswordComfir.Margin = new Padding(4);
            lblpasswordComfir.Name = "lblpasswordComfir";
            lblpasswordComfir.Size = new Size(207, 25);
            lblpasswordComfir.TabIndex = 23;
            lblpasswordComfir.Text = "Comfirmar Contraseña:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(148, 414);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Properties.Appearance.Options.UseFont = true;
            txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            txtConfirmPassword.Size = new Size(302, 34);
            txtConfirmPassword.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(148, 244);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtFullName.Properties.Appearance.Options.UseFont = true;
            txtFullName.Size = new Size(302, 34);
            txtFullName.TabIndex = 2;
            // 
            // lbluserComplet
            // 
            lbluserComplet.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbluserComplet.Appearance.Options.UseFont = true;
            lbluserComplet.Location = new Point(148, 212);
            lbluserComplet.Margin = new Padding(4);
            lbluserComplet.Name = "lbluserComplet";
            lbluserComplet.Size = new Size(168, 25);
            lbluserComplet.TabIndex = 20;
            lbluserComplet.Text = "Nombre completo:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 327);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(302, 34);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(148, 160);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Size = new Size(302, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblpassword
            // 
            lblpassword.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblpassword.Appearance.Options.UseFont = true;
            lblpassword.Location = new Point(148, 295);
            lblpassword.Margin = new Padding(4);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(106, 25);
            lblpassword.TabIndex = 17;
            lblpassword.Text = "Contraseña:";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.SeaGreen;
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.ForeColor = Color.White;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Appearance.Options.UseForeColor = true;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(148, 486);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(302, 55);
            btnSave.TabIndex = 5;
            btnSave.Text = "Registrarme  ";
            btnSave.Click += btnSave_Click;
            // 
            // lbluser
            // 
            lbluser.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbluser.Appearance.Options.UseFont = true;
            lbluser.Location = new Point(148, 128);
            lbluser.Margin = new Padding(4);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(178, 25);
            lbluser.TabIndex = 15;
            lbluser.Text = "Nombre de usuario:";
            // 
            // lblcrearAcount
            // 
            lblcrearAcount.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcrearAcount.Appearance.ForeColor = Color.SeaGreen;
            lblcrearAcount.Appearance.Options.UseFont = true;
            lblcrearAcount.Appearance.Options.UseForeColor = true;
            lblcrearAcount.Location = new Point(145, 0);
            lblcrearAcount.Margin = new Padding(4);
            lblcrearAcount.Name = "lblcrearAcount";
            lblcrearAcount.Size = new Size(325, 60);
            lblcrearAcount.TabIndex = 24;
            lblcrearAcount.Text = "CREAR CUENTA";
            // 
            // lblsubCreat
            // 
            lblsubCreat.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsubCreat.Appearance.Options.UseFont = true;
            lblsubCreat.Location = new Point(190, 59);
            lblsubCreat.Margin = new Padding(4);
            lblsubCreat.Name = "lblsubCreat";
            lblsubCreat.Size = new Size(226, 28);
            lblsubCreat.TabIndex = 25;
            lblsubCreat.Text = "Regístrate para continuar ";
            // 
            // lblquestion
            // 
            lblquestion.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquestion.Appearance.ForeColor = Color.Gray;
            lblquestion.Appearance.Options.UseFont = true;
            lblquestion.Appearance.Options.UseForeColor = true;
            lblquestion.Location = new Point(178, 580);
            lblquestion.Margin = new Padding(4);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(130, 21);
            lblquestion.TabIndex = 26;
            lblquestion.Text = "¿Ya tienes cuenta? ";
            // 
            // lblInit
            // 
            lblInit.Appearance.Font = new Font("Segoe UI", 9.75F);
            lblInit.Appearance.ForeColor = SystemColors.MenuHighlight;
            lblInit.Appearance.Options.UseFont = true;
            lblInit.Appearance.Options.UseForeColor = true;
            lblInit.Location = new Point(312, 580);
            lblInit.Margin = new Padding(4);
            lblInit.Name = "lblInit";
            lblInit.Size = new Size(84, 21);
            lblInit.TabIndex = 27;
            lblInit.Text = "Inicia sesión";
            lblInit.Click += lblInit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 665);
            Controls.Add(lblInit);
            Controls.Add(lblquestion);
            Controls.Add(lblsubCreat);
            Controls.Add(lblcrearAcount);
            Controls.Add(lblpasswordComfir);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtFullName);
            Controls.Add(lbluserComplet);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblpassword);
            Controls.Add(btnSave);
            Controls.Add(lbluser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IconOptions.Image = (Image)resources.GetObject("RegisterForm.IconOptions.Image");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblpasswordComfir;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl lbluserComplet;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblpassword;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lbluser;
        private DevExpress.XtraEditors.LabelControl lblcrearAcount;
        private DevExpress.XtraEditors.LabelControl lblsubCreat;
        private DevExpress.XtraEditors.LabelControl lblquestion;
        private DevExpress.XtraEditors.LabelControl lblInit;
    }
}