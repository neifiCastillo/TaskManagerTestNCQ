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
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            comboPriority = new DevExpress.XtraEditors.LookUpEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            comboStatus = new DevExpress.XtraEditors.LookUpEdit();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            gridLookUpUsers = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            dateDueDate = new DevExpress.XtraEditors.DateEdit();
            memoNotes = new DevExpress.XtraEditors.MemoEdit();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
            layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtDescription);
            layoutControl1.Location = new Point(10, 61);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(978, 174, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(633, 46);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(82, 12);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(539, 20);
            txtDescription.StyleController = layoutControl1;
            txtDescription.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(633, 46);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtDescription;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(613, 26);
            layoutControlItem1.Text = "Descripción:";
            layoutControlItem1.TextSize = new Size(58, 13);
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(comboPriority);
            layoutControl2.Location = new Point(10, 112);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1151, 239, 650, 400);
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new Size(598, 47);
            layoutControl2.TabIndex = 1;
            layoutControl2.Text = "layoutControl2";
            // 
            // comboPriority
            // 
            comboPriority.Location = new Point(70, 12);
            comboPriority.Name = "comboPriority";
            comboPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboPriority.Size = new Size(499, 20);
            comboPriority.StyleController = layoutControl2;
            comboPriority.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1 });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new Size(581, 54);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = comboPriority;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(561, 24);
            layoutControlItem2.Text = "Prioridad:";
            layoutControlItem2.TextSize = new Size(46, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new Point(0, 24);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(561, 10);
            // 
            // layoutControl3
            // 
            layoutControl3.Controls.Add(comboStatus);
            layoutControl3.Location = new Point(10, 164);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(629, 0, 650, 400);
            layoutControl3.Root = layoutControlGroup2;
            layoutControl3.Size = new Size(563, 47);
            layoutControl3.TabIndex = 2;
            layoutControl3.Text = "layoutControl3";
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(61, 12);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Size = new Size(473, 20);
            comboStatus.StyleController = layoutControl3;
            comboStatus.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, emptySpaceItem2 });
            layoutControlGroup2.Name = "Root";
            layoutControlGroup2.Size = new Size(546, 54);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = comboStatus;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem2";
            layoutControlItem3.Size = new Size(526, 24);
            layoutControlItem3.Text = "Estado:";
            layoutControlItem3.TextSize = new Size(37, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new Point(0, 24);
            emptySpaceItem2.Name = "emptySpaceItem1";
            emptySpaceItem2.Size = new Size(526, 10);
            // 
            // gridLookUpUsers
            // 
            gridLookUpUsers.Location = new Point(69, 232);
            gridLookUpUsers.Name = "gridLookUpUsers";
            gridLookUpUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpUsers.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpUsers.Size = new Size(189, 20);
            gridLookUpUsers.TabIndex = 3;
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
            // layoutControl4
            // 
            layoutControl4.Controls.Add(dateDueDate);
            layoutControl4.Controls.Add(memoNotes);
            layoutControl4.Location = new Point(10, 264);
            layoutControl4.Name = "layoutControl4";
            layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(618, 107, 650, 400);
            layoutControl4.Root = layoutControlGroup3;
            layoutControl4.Size = new Size(560, 104);
            layoutControl4.TabIndex = 4;
            layoutControl4.Text = "layoutControl4";
            // 
            // dateDueDate
            // 
            dateDueDate.EditValue = null;
            dateDueDate.Location = new Point(133, 12);
            dateDueDate.Name = "dateDueDate";
            dateDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDueDate.Size = new Size(415, 20);
            dateDueDate.StyleController = layoutControl4;
            dateDueDate.TabIndex = 4;
            // 
            // memoNotes
            // 
            memoNotes.Location = new Point(133, 36);
            memoNotes.Name = "memoNotes";
            memoNotes.Size = new Size(415, 56);
            memoNotes.StyleController = layoutControl4;
            memoNotes.TabIndex = 5;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem5 });
            layoutControlGroup3.Name = "Root";
            layoutControlGroup3.Size = new Size(560, 104);
            layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = dateDueDate;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(540, 24);
            layoutControlItem4.Text = "Fecha de Compromiso:";
            layoutControlItem4.TextSize = new Size(109, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = memoNotes;
            layoutControlItem5.Location = new Point(0, 24);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(540, 60);
            layoutControlItem5.Text = "Notas:";
            layoutControlItem5.TextSize = new Size(109, 13);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(238, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(23, 235);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(40, 13);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "Usuario:";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 519);
            Controls.Add(labelControl1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(layoutControl4);
            Controls.Add(gridLookUpUsers);
            Controls.Add(layoutControl1);
            Controls.Add(layoutControl2);
            Controls.Add(layoutControl3);
            IconOptions.Image = (Image)resources.GetObject("TaskForm.IconOptions.Image");
            Name = "TaskForm";
            Text = "Crear tareas";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)comboPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
            layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDueDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.LookUpEdit comboPriority;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.LookUpEdit comboStatus;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}