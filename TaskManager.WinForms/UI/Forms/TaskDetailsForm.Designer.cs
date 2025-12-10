namespace TaskManager.WinForms.UI.Forms
{
    partial class TaskDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailsForm));
            lblAdmistration = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            lblId = new Label();
            label10 = new Label();
            txtNotes = new DevExpress.XtraEditors.MemoEdit();
            lblAct = new Label();
            lblCreat = new Label();
            lblAsigUser = new Label();
            lblDate = new Label();
            lblPriority = new Label();
            lblStatus = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelControlDetalles = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblAdmistration
            // 
            lblAdmistration.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmistration.Appearance.ForeColor = Color.SeaGreen;
            lblAdmistration.Appearance.Options.UseFont = true;
            lblAdmistration.Appearance.Options.UseForeColor = true;
            lblAdmistration.Location = new Point(12, 12);
            lblAdmistration.Name = "lblAdmistration";
            lblAdmistration.Size = new Size(0, 47);
            lblAdmistration.TabIndex = 26;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(txtDescription);
            groupControl1.Controls.Add(lblId);
            groupControl1.Controls.Add(label10);
            groupControl1.Controls.Add(txtNotes);
            groupControl1.Controls.Add(lblAct);
            groupControl1.Controls.Add(lblCreat);
            groupControl1.Controls.Add(lblAsigUser);
            groupControl1.Controls.Add(lblDate);
            groupControl1.Controls.Add(lblPriority);
            groupControl1.Controls.Add(lblStatus);
            groupControl1.Controls.Add(label9);
            groupControl1.Controls.Add(label8);
            groupControl1.Controls.Add(label7);
            groupControl1.Controls.Add(label6);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Location = new Point(12, 68);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(498, 495);
            groupControl1.TabIndex = 27;
            groupControl1.Text = "Informacion ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(111, 96);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(382, 57);
            txtDescription.TabIndex = 21;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.Location = new Point(38, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(40, 21);
            lblId.TabIndex = 20;
            lblId.Text = "lblId";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(12, 49);
            label10.Name = "label10";
            label10.Size = new Size(30, 21);
            label10.TabIndex = 19;
            label10.Text = "ID:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(21, 413);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(305, 55);
            txtNotes.TabIndex = 17;
            // 
            // lblAct
            // 
            lblAct.AutoSize = true;
            lblAct.Font = new Font("Segoe UI", 12F);
            lblAct.Location = new Point(109, 354);
            lblAct.Name = "lblAct";
            lblAct.Size = new Size(49, 21);
            lblAct.TabIndex = 16;
            lblAct.Text = "lblAct";
            // 
            // lblCreat
            // 
            lblCreat.AutoSize = true;
            lblCreat.Font = new Font("Segoe UI", 12F);
            lblCreat.Location = new Point(76, 316);
            lblCreat.Name = "lblCreat";
            lblCreat.Size = new Size(64, 21);
            lblCreat.TabIndex = 15;
            lblCreat.Text = "lblCreat";
            // 
            // lblAsigUser
            // 
            lblAsigUser.AutoSize = true;
            lblAsigUser.Font = new Font("Segoe UI", 12F);
            lblAsigUser.Location = new Point(113, 276);
            lblAsigUser.Name = "lblAsigUser";
            lblAsigUser.Size = new Size(89, 21);
            lblAsigUser.TabIndex = 14;
            lblAsigUser.Text = "lblAsigUser";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(168, 237);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 21);
            lblDate.TabIndex = 13;
            lblDate.Text = "lblDate";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.Location = new Point(89, 200);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(78, 21);
            lblPriority.TabIndex = 12;
            lblPriority.Text = "lblPriority";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(71, 161);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 21);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "lblStatus";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(14, 388);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 8;
            label9.Text = "Notas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(14, 353);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 7;
            label8.Text = "Actualizada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 315);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 6;
            label7.Text = "Creada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(14, 276);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 5;
            label6.Text = "Asignada A:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(14, 236);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 4;
            label5.Text = "Fecha Compromiso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 200);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Prioridad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // labelControlDetalles
            // 
            labelControlDetalles.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControlDetalles.Appearance.ForeColor = Color.SeaGreen;
            labelControlDetalles.Appearance.Options.UseFont = true;
            labelControlDetalles.Appearance.Options.UseForeColor = true;
            labelControlDetalles.Location = new Point(14, 10);
            labelControlDetalles.Name = "labelControlDetalles";
            labelControlDetalles.Size = new Size(344, 47);
            labelControlDetalles.TabIndex = 28;
            labelControlDetalles.Text = "DETALLES DE TAREA";
            // 
            // TaskDetailsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 581);
            Controls.Add(labelControlDetalles);
            Controls.Add(groupControl1);
            Controls.Add(lblAdmistration);
            IconOptions.Image = (Image)resources.GetObject("TaskDetailsForm.IconOptions.Image");
            Name = "TaskDetailsForm";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAdmistration;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControlDetalles;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblDate;
        private Label lblPriority;
        private Label lblStatus;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
        private Label lblAct;
        private Label lblCreat;
        private Label lblAsigUser;
        private Label lblId;
        private Label label10;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}