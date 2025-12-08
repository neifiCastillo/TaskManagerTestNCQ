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
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            lblRegister = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(17, 109);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(53, 20);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Usuario";
            // 
            // btnLogin
            // 
            btnLogin.Appearance.BackColor = Color.SeaGreen;
            btnLogin.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Appearance.ForeColor = Color.White;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.Location = new Point(17, 254);
            btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(279, 50);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Click += btnLogin_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(17, 178);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(77, 20);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(17, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.BackColor = Color.White;
            txtUsername.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Properties.Appearance.Options.UseBackColor = true;
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Size = new Size(279, 28);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(17, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.BackColor = Color.White;
            txtPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Properties.Appearance.Options.UseBackColor = true;
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(279, 28);
            txtPassword.TabIndex = 5;
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
            panelControl1.Controls.Add(labelControl5);
            panelControl1.Controls.Add(txtPassword);
            panelControl1.Controls.Add(txtUsername);
            panelControl1.Controls.Add(btnLogin);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Location = new Point(1, 1);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(325, 536);
            panelControl1.TabIndex = 6;
            // 
            // lblRegister
            // 
            lblRegister.Appearance.Font = new Font("Segoe UI", 9.75F);
            lblRegister.Appearance.ForeColor = SystemColors.MenuHighlight;
            lblRegister.Appearance.Options.UseFont = true;
            lblRegister.Appearance.Options.UseForeColor = true;
            lblRegister.Location = new Point(149, 335);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(109, 17);
            lblRegister.TabIndex = 10;
            lblRegister.Text = " ¡Regístrate ahora!";
            lblRegister.Click += lblRegister_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.Gray;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(39, 335);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(110, 17);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "¿No tienes cuenta?";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(17, 54);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(206, 21);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Administrar fácilmente tareas";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = Color.SeaGreen;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(13, 5);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(109, 47);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 537);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IconOptions.Image = (Image)resources.GetObject("LoginForm.IconOptions.Image");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblRegister;
    }
}