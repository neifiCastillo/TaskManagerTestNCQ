namespace TaskManager.WinForms.UI.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            SuspendLayout();
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 505);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.Image = (Image)resources.GetObject("DashboardForm.IconOptions.Image");
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion
    }
}