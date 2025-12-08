namespace TaskManager.WinForms.UI
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtDescription = new DevExpress.XtraEditors.TextEdit();
            gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            gridLookUpUsers = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            gridLookUpStatus = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridLookUpPriority = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            dateDueDate = new DevExpress.XtraEditors.DateEdit();
            memoNotes = new DevExpress.XtraEditors.MemoEdit();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl5).BeginInit();
            layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLookUpStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit3View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
            layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtDescription);
            layoutControl1.Controls.Add(gridLookUpEdit1);
            layoutControl1.Location = new Point(3, 39);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(978, 174, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(476, 45);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(89, 12);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(375, 20);
            txtDescription.StyleController = layoutControl1;
            txtDescription.TabIndex = 0;
            // 
            // gridLookUpEdit1
            // 
            gridLookUpEdit1.Location = new Point(416, 12);
            gridLookUpEdit1.Name = "gridLookUpEdit1";
            gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEdit1.Properties.PopupView = gridView1;
            gridLookUpEdit1.Size = new Size(50, 20);
            gridLookUpEdit1.StyleController = layoutControl1;
            gridLookUpEdit1.TabIndex = 28;
            // 
            // gridView1
            // 
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(476, 45);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.Control = txtDescription;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(456, 25);
            layoutControlItem1.Text = "Descripción:";
            layoutControlItem1.TextSize = new Size(65, 15);
            // 
            // gridLookUpUsers
            // 
            gridLookUpUsers.Location = new Point(72, 60);
            gridLookUpUsers.Name = "gridLookUpUsers";
            gridLookUpUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpUsers.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpUsers.Size = new Size(392, 20);
            gridLookUpUsers.StyleController = layoutControl5;
            gridLookUpUsers.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.DetailHeight = 303;
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 686;
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControl5
            // 
            layoutControl5.Controls.Add(gridLookUpStatus);
            layoutControl5.Controls.Add(gridLookUpUsers);
            layoutControl5.Controls.Add(gridLookUpPriority);
            layoutControl5.Location = new Point(2, 78);
            layoutControl5.Name = "layoutControl5";
            layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(739, 12, 650, 400);
            layoutControl5.Root = layoutControlGroup4;
            layoutControl5.Size = new Size(476, 102);
            layoutControl5.TabIndex = 8;
            layoutControl5.Text = "layoutControl5";
            // 
            // gridLookUpStatus
            // 
            gridLookUpStatus.Location = new Point(72, 36);
            gridLookUpStatus.Name = "gridLookUpStatus";
            gridLookUpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpStatus.Properties.PopupView = gridLookUpEdit3View;
            gridLookUpStatus.Size = new Size(392, 20);
            gridLookUpStatus.StyleController = layoutControl5;
            gridLookUpStatus.TabIndex = 28;
            // 
            // gridLookUpEdit3View
            // 
            gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gridLookUpPriority
            // 
            gridLookUpPriority.Location = new Point(72, 12);
            gridLookUpPriority.Name = "gridLookUpPriority";
            gridLookUpPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpPriority.Properties.PopupView = gridLookUpEdit2View;
            gridLookUpPriority.Size = new Size(392, 20);
            gridLookUpPriority.StyleController = layoutControl5;
            gridLookUpPriority.TabIndex = 4;
            // 
            // gridLookUpEdit2View
            // 
            gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup4
            // 
            layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup4.GroupBordersVisible = false;
            layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem6, emptySpaceItem3, layoutControlItem2, layoutControlItem3 });
            layoutControlGroup4.Name = "Root";
            layoutControlGroup4.Size = new Size(476, 102);
            layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Font = new Font("Segoe UI", 9F);
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.Control = gridLookUpPriority;
            layoutControlItem6.Location = new Point(0, 0);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(456, 24);
            layoutControlItem6.Text = "Prioridad";
            layoutControlItem6.TextSize = new Size(48, 15);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.Location = new Point(0, 72);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(456, 10);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Font = new Font("Segoe UI", 9F);
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.Control = gridLookUpStatus;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(456, 24);
            layoutControlItem2.Text = "Estado";
            layoutControlItem2.TextSize = new Size(48, 15);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AppearanceItemCaption.Font = new Font("Segoe UI", 9F);
            layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem3.Control = gridLookUpUsers;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(456, 24);
            layoutControlItem3.Text = "Usuarios";
            layoutControlItem3.TextSize = new Size(48, 15);
            // 
            // layoutControl4
            // 
            layoutControl4.Controls.Add(dateDueDate);
            layoutControl4.Controls.Add(memoNotes);
            layoutControl4.Location = new Point(2, 168);
            layoutControl4.Name = "layoutControl4";
            layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(339, 352, 650, 400);
            layoutControl4.Root = layoutControlGroup3;
            layoutControl4.Size = new Size(477, 104);
            layoutControl4.TabIndex = 4;
            layoutControl4.Text = "layoutControl4";
            // 
            // dateDueDate
            // 
            dateDueDate.EditValue = null;
            dateDueDate.Location = new Point(147, 12);
            dateDueDate.Name = "dateDueDate";
            dateDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDueDate.Size = new Size(318, 20);
            dateDueDate.StyleController = layoutControl4;
            dateDueDate.TabIndex = 0;
            // 
            // memoNotes
            // 
            memoNotes.Location = new Point(147, 36);
            memoNotes.Name = "memoNotes";
            memoNotes.Size = new Size(318, 56);
            memoNotes.StyleController = layoutControl4;
            memoNotes.TabIndex = 2;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem5 });
            layoutControlGroup3.Name = "Root";
            layoutControlGroup3.Size = new Size(477, 104);
            layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Font = new Font("Segoe UI", 9F);
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.Control = dateDueDate;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(457, 24);
            layoutControlItem4.Text = "Fecha de Compromiso:";
            layoutControlItem4.TextSize = new Size(123, 15);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Font = new Font("Segoe UI", 9F);
            layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem5.Control = memoNotes;
            layoutControlItem5.Location = new Point(0, 24);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(457, 60);
            layoutControlItem5.Text = "Notas:";
            layoutControlItem5.TextSize = new Size(123, 15);
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.SeaGreen;
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.ForeColor = Color.White;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Appearance.Options.UseForeColor = true;
            btnSave.Location = new Point(62, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = Color.Silver;
            btnCancel.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.ForeColor = Color.White;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Appearance.Options.UseForeColor = true;
            btnCancel.Location = new Point(228, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.SeaGreen;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(10, 8);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(255, 47);
            labelControl5.TabIndex = 26;
            labelControl5.Text = "CREAR TAREAS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(layoutControl1);
            groupBox1.Controls.Add(layoutControl5);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(layoutControl4);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 436);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 505);
            Controls.Add(groupBox1);
            Controls.Add(labelControl5);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.Image = (Image)resources.GetObject("TaskForm.IconOptions.Image");
            MaximizeBox = false;
            Name = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl5).EndInit();
            layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLookUpStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit3View).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
            layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraEditors.DateEdit dateDueDate;
        private DevExpress.XtraEditors.MemoEdit memoNotes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpPriority;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}