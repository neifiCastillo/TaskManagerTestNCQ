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
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(233, 202);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(108, 13);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Comfirmar Contraseña";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(347, 199);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(127, 20);
            txtConfirmPassword.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(347, 139);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(127, 20);
            txtFullName.TabIndex = 21;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(233, 142);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(83, 13);
            labelControl3.TabIndex = 20;
            labelControl3.Text = "Nombre completo";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(347, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(127, 20);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(347, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(127, 20);
            txtUsername.TabIndex = 18;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(233, 171);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 13);
            labelControl2.TabIndex = 17;
            labelControl2.Text = "Contraseña";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(305, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 20);
            btnSave.TabIndex = 16;
            btnSave.Text = "Registrarme  ";
            btnSave.Click += btnSave_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(233, 114);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(90, 13);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Nombre de usuario";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(labelControl4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtFullName);
            Controls.Add(labelControl3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelControl2);
            Controls.Add(btnSave);
            Controls.Add(labelControl1);
            IconOptions.Image = (Image)resources.GetObject("RegisterForm.IconOptions.Image");
            Name = "RegisterForm";
            Text = "Registro de usuarios";
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
    }
}