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
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            lblInicio = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(127, 310);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(163, 20);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Comfirmar Contraseña:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(127, 336);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Properties.Appearance.Options.UseFont = true;
            txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            txtConfirmPassword.Size = new Size(259, 28);
            txtConfirmPassword.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(127, 198);
            txtFullName.Name = "txtFullName";
            txtFullName.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtFullName.Properties.Appearance.Options.UseFont = true;
            txtFullName.Size = new Size(259, 28);
            txtFullName.TabIndex = 21;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(127, 172);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(132, 20);
            labelControl3.TabIndex = 20;
            labelControl3.Text = "Nombre completo:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(259, 28);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(127, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Size = new Size(259, 28);
            txtUsername.TabIndex = 18;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(127, 240);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(83, 20);
            labelControl2.TabIndex = 17;
            labelControl2.Text = "Contraseña:";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.SeaGreen;
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.ForeColor = Color.White;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Appearance.Options.UseForeColor = true;
            btnSave.Location = new Point(127, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(259, 45);
            btnSave.TabIndex = 16;
            btnSave.Text = "Registrarme  ";
            btnSave.Click += btnSave_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(127, 104);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(139, 20);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Nombre de usuario:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.SeaGreen;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(124, 0);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(262, 47);
            labelControl5.TabIndex = 24;
            labelControl5.Text = "CREAR CUENTA";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(163, 48);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(181, 21);
            labelControl6.TabIndex = 25;
            labelControl6.Text = "Regístrate para continuar ";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl7.Appearance.ForeColor = Color.Gray;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new Point(153, 471);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(110, 17);
            labelControl7.TabIndex = 26;
            labelControl7.Text = "¿Ya tienes cuenta? ";
            // 
            // lblInicio
            // 
            lblInicio.Appearance.Font = new Font("Segoe UI", 9.75F);
            lblInicio.Appearance.ForeColor = SystemColors.MenuHighlight;
            lblInicio.Appearance.Options.UseFont = true;
            lblInicio.Appearance.Options.UseForeColor = true;
            lblInicio.Location = new Point(267, 471);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(70, 17);
            lblInicio.TabIndex = 27;
            lblInicio.Text = "Inicia sesión";
            lblInicio.Click += lblInicio_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 540);
            Controls.Add(lblInicio);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtFullName);
            Controls.Add(labelControl3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelControl2);
            Controls.Add(btnSave);
            Controls.Add(labelControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IconOptions.Image = (Image)resources.GetObject("RegisterForm.IconOptions.Image");
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

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblInicio;
    }
}