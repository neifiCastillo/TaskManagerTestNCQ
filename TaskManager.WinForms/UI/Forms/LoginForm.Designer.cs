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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnRegister = new DevExpress.XtraEditors.SimpleButton();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(components);
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(223, 94);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(36, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Usuario";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(219, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 20);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Click += btnLogin_Click;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(223, 145);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 13);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Contraseña";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(326, 263);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(64, 20);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrarme     ";
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(285, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(127, 20);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(285, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(118, 20);
            txtPassword.TabIndex = 5;
            // 
            // alertControl1
            // 
            alertControl1.AutoFormDelay = 2000;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(labelControl2);
            Controls.Add(btnLogin);
            Controls.Add(labelControl1);
            IconOptions.Image = (Image)resources.GetObject("LoginForm.IconOptions.Image");
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}