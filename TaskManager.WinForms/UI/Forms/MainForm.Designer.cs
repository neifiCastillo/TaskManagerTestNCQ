namespace TaskManager.WinForms.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gridLookUpEditUsers = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            dateFrom = new DevExpress.XtraEditors.DateEdit();
            dateTo = new DevExpress.XtraEditors.DateEdit();
            comboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            comboPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            btnFilter = new DevExpress.XtraEditors.SimpleButton();
            btnClearFilter = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            Usuarios = new DevExpress.XtraLayout.LayoutControlItem();
            Incio = new DevExpress.XtraLayout.LayoutControlItem();
            Fin = new DevExpress.XtraLayout.LayoutControlItem();
            Estatus = new DevExpress.XtraLayout.LayoutControlItem();
            Prioridad = new DevExpress.XtraLayout.LayoutControlItem();
            Busqueda = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnInProgress = new DevExpress.XtraEditors.SimpleButton();
            btnDone = new DevExpress.XtraEditors.SimpleButton();
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEditUsers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFrom.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Incio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Estatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Prioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Busqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(10, 192);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(910, 321);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 303;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridLookUpEditUsers);
            layoutControl1.Controls.Add(dateFrom);
            layoutControl1.Controls.Add(dateTo);
            layoutControl1.Controls.Add(comboStatus);
            layoutControl1.Controls.Add(comboPriority);
            layoutControl1.Controls.Add(txtSearch);
            layoutControl1.Controls.Add(btnFilter);
            layoutControl1.Controls.Add(btnClearFilter);
            layoutControl1.Location = new Point(5, 4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1137, 37, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(922, 122);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEditUsers
            // 
            gridLookUpEditUsers.Location = new Point(71, 12);
            gridLookUpEditUsers.Name = "gridLookUpEditUsers";
            gridLookUpEditUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEditUsers.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEditUsers.Size = new Size(379, 20);
            gridLookUpEditUsers.StyleController = layoutControl1;
            gridLookUpEditUsers.TabIndex = 6;
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
            // dateFrom
            // 
            dateFrom.EditValue = null;
            dateFrom.Location = new Point(513, 12);
            dateFrom.Name = "dateFrom";
            dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Size = new Size(380, 20);
            dateFrom.StyleController = layoutControl1;
            dateFrom.TabIndex = 7;
            // 
            // dateTo
            // 
            dateTo.EditValue = null;
            dateTo.Location = new Point(513, 36);
            dateTo.Name = "dateTo";
            dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Size = new Size(380, 20);
            dateTo.StyleController = layoutControl1;
            dateTo.TabIndex = 8;
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(71, 36);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Size = new Size(379, 20);
            comboStatus.StyleController = layoutControl1;
            comboStatus.TabIndex = 9;
            // 
            // comboPriority
            // 
            comboPriority.Location = new Point(71, 60);
            comboPriority.Name = "comboPriority";
            comboPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboPriority.Size = new Size(379, 20);
            comboPriority.StyleController = layoutControl1;
            comboPriority.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(513, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 20);
            txtSearch.StyleController = layoutControl1;
            txtSearch.TabIndex = 11;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(12, 84);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(438, 22);
            btnFilter.StyleController = layoutControl1;
            btnFilter.TabIndex = 12;
            btnFilter.Text = "Buscar";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(12, 110);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(438, 22);
            btnClearFilter.StyleController = layoutControl1;
            btnClearFilter.TabIndex = 13;
            btnClearFilter.Text = "Limpiar";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { Usuarios, Incio, Fin, Estatus, Prioridad, Busqueda, layoutControlItem7, layoutControlItem8 });
            Root.Name = "Root";
            Root.Size = new Size(905, 144);
            Root.TextVisible = false;
            // 
            // Usuarios
            // 
            Usuarios.Control = gridLookUpEditUsers;
            Usuarios.Location = new Point(0, 0);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(442, 24);
            Usuarios.TextSize = new Size(47, 13);
            // 
            // Incio
            // 
            Incio.Control = dateFrom;
            Incio.Location = new Point(442, 0);
            Incio.Name = "Incio";
            Incio.Size = new Size(443, 24);
            Incio.TextSize = new Size(47, 13);
            // 
            // Fin
            // 
            Fin.Control = dateTo;
            Fin.Location = new Point(442, 24);
            Fin.Name = "Fin";
            Fin.Size = new Size(443, 24);
            Fin.TextSize = new Size(47, 13);
            // 
            // Estatus
            // 
            Estatus.Control = comboStatus;
            Estatus.Location = new Point(0, 24);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(442, 24);
            Estatus.TextSize = new Size(47, 13);
            // 
            // Prioridad
            // 
            Prioridad.Control = comboPriority;
            Prioridad.Location = new Point(0, 48);
            Prioridad.Name = "Prioridad";
            Prioridad.Size = new Size(442, 24);
            Prioridad.TextSize = new Size(47, 13);
            // 
            // Busqueda
            // 
            Busqueda.Control = txtSearch;
            Busqueda.Location = new Point(442, 48);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(443, 76);
            Busqueda.TextSize = new Size(47, 13);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnFilter;
            layoutControlItem7.Location = new Point(0, 72);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(442, 26);
            layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = btnClearFilter;
            layoutControlItem8.Location = new Point(0, 98);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(442, 26);
            layoutControlItem8.TextVisible = false;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(699, 167);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(64, 20);
            btnNew.TabIndex = 2;
            btnNew.Text = "Crear ";
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(778, 167);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(64, 20);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Editar ";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(856, 167);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 20);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInProgress
            // 
            btnInProgress.Location = new Point(540, 167);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(64, 20);
            btnInProgress.TabIndex = 5;
            btnInProgress.Text = "En Proceso";
            btnInProgress.Click += btnInProgress_Click;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(617, 167);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(64, 20);
            btnDone.TabIndex = 6;
            btnDone.Text = "Realizada";
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "56a4125a-b5b4-422b-89cf-3461eb451aa7";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 523);
            Controls.Add(btnDone);
            Controls.Add(btnInProgress);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(layoutControl1);
            Controls.Add(gridControl1);
            IconOptions.Image = (Image)resources.GetObject("MainForm.IconOptions.Image");
            Name = "MainForm";
            Text = "Adminitracion de tareas";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLookUpEditUsers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFrom.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)Usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)Incio).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Estatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)Prioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Busqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.ComboBoxEdit comboStatus;
        private DevExpress.XtraEditors.ComboBoxEdit comboPriority;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraLayout.LayoutControlItem Usuarios;
        private DevExpress.XtraLayout.LayoutControlItem Incio;
        private DevExpress.XtraLayout.LayoutControlItem Fin;
        private DevExpress.XtraLayout.LayoutControlItem Estatus;
        private DevExpress.XtraLayout.LayoutControlItem Prioridad;
        private DevExpress.XtraLayout.LayoutControlItem Busqueda;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.SimpleButton btnClearFilter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnInProgress;
        private DevExpress.XtraEditors.SimpleButton btnDone;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}