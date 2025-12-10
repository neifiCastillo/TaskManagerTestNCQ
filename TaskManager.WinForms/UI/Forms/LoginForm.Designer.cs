namespace TaskManager.WinForms.UI
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lbluser = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            lblpassword = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            lblRegister = new DevExpress.XtraEditors.LabelControl();
            lblquestion = new DevExpress.XtraEditors.LabelControl();
            lblsubLogin = new DevExpress.XtraEditors.LabelControl();
            lbllogin = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluser.Appearance.Options.UseFont = true;
            lbluser.Location = new Point(20, 134);
            lbluser.Margin = new Padding(4);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(65, 25);
            lbluser.TabIndex = 0;
            lbluser.Text = "Usuario";
            // 
            // btnLogin
            // 
            btnLogin.Appearance.BackColor = Color.SeaGreen;
            btnLogin.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Appearance.ForeColor = Color.White;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(20, 313);
            btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(326, 62);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblpassword
            // 
            lblpassword.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Appearance.Options.UseFont = true;
            lblpassword.Location = new Point(20, 219);
            lblpassword.Margin = new Padding(4);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(97, 25);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 166);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.BackColor = Color.White;
            txtUsername.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Properties.Appearance.Options.UseBackColor = true;
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Properties.MaxLength = 10;
            txtUsername.Size = new Size(326, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 247);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.BackColor = Color.White;
            txtPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Properties.Appearance.Options.UseBackColor = true;
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.MaxLength = 10;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(326, 34);
            txtPassword.TabIndex = 2;
            // 
            // alertControl1
            // 
            alertControl1.AutoFormDelay = 2000;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(lblRegister);
            panelControl1.Controls.Add(lblquestion);
            panelControl1.Controls.Add(txtPassword);
            panelControl1.Controls.Add(txtUsername);
            panelControl1.Controls.Add(btnLogin);
            panelControl1.Controls.Add(lblsubLogin);
            panelControl1.Controls.Add(lbllogin);
            panelControl1.Controls.Add(lblpassword);
            panelControl1.Controls.Add(lbluser);
            panelControl1.Location = new Point(1, 1);
            panelControl1.Margin = new Padding(4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(379, 660);
            panelControl1.TabIndex = 6;
            // 
            // lblRegister
            // 
            lblRegister.Appearance.Font = new Font("Segoe UI", 9.75F);
            lblRegister.Appearance.ForeColor = SystemColors.MenuHighlight;
            lblRegister.Appearance.Options.UseFont = true;
            lblRegister.Appearance.Options.UseForeColor = true;
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Location = new Point(174, 412);
            lblRegister.Margin = new Padding(4);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(128, 21);
            lblRegister.TabIndex = 4;
            lblRegister.Text = " ¡Regístrate ahora!";
            lblRegister.Click += lblRegister_Click;
            // 
            // lblquestion
            // 
            lblquestion.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquestion.Appearance.ForeColor = Color.Gray;
            lblquestion.Appearance.Options.UseFont = true;
            lblquestion.Appearance.Options.UseForeColor = true;
            lblquestion.Location = new Point(46, 412);
            lblquestion.Margin = new Padding(4);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(130, 21);
            lblquestion.TabIndex = 9;
            lblquestion.Text = "¿No tienes cuenta?";
            // 
            // lblsubLogin
            // 
            lblsubLogin.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsubLogin.Appearance.Options.UseFont = true;
            lblsubLogin.Location = new Point(20, 66);
            lblsubLogin.Margin = new Padding(4);
            lblsubLogin.Name = "lblsubLogin";
            lblsubLogin.Size = new Size(256, 28);
            lblsubLogin.TabIndex = 8;
            lblsubLogin.Text = "Administrar fácilmente tareas";
            // 
            // lbllogin
            // 
            lbllogin.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.Appearance.ForeColor = Color.SeaGreen;
            lbllogin.Appearance.Options.UseFont = true;
            lbllogin.Appearance.Options.UseForeColor = true;
            lbllogin.Location = new Point(15, 6);
            lbllogin.Margin = new Padding(4);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(136, 60);
            lbllogin.TabIndex = 7;
            lbllogin.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 661);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IconOptions.Image = (Image)resources.GetObject("LoginForm.IconOptions.Image");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbluser;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl lblpassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblsubLogin;
        private DevExpress.XtraEditors.LabelControl lbllogin;
        private DevExpress.XtraEditors.LabelControl lblquestion;
        private DevExpress.XtraEditors.LabelControl lblRegister;
    }
}