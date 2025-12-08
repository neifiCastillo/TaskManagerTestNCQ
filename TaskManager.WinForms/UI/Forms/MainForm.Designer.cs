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
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            menuStrip1 = new MenuStrip();
            verTareasToolStripMenuItem = new ToolStripMenuItem();
            graficosToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
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
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 287);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1202, 437);
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
            layoutControl1.Location = new Point(5, 26);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1137, 37, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(922, 153);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEditUsers
            // 
            gridLookUpEditUsers.Location = new Point(91, 12);
            gridLookUpEditUsers.Name = "gridLookUpEditUsers";
            gridLookUpEditUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEditUsers.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEditUsers.Size = new Size(367, 20);
            gridLookUpEditUsers.StyleController = layoutControl1;
            gridLookUpEditUsers.TabIndex = 0;
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
            dateFrom.Location = new Point(541, 12);
            dateFrom.Name = "dateFrom";
            dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Size = new Size(369, 20);
            dateFrom.StyleController = layoutControl1;
            dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            dateTo.EditValue = null;
            dateTo.Location = new Point(541, 36);
            dateTo.Name = "dateTo";
            dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Size = new Size(369, 20);
            dateTo.StyleController = layoutControl1;
            dateTo.TabIndex = 4;
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(91, 36);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Size = new Size(367, 20);
            comboStatus.StyleController = layoutControl1;
            comboStatus.TabIndex = 3;
            // 
            // comboPriority
            // 
            comboPriority.Location = new Point(91, 60);
            comboPriority.Name = "comboPriority";
            comboPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboPriority.Size = new Size(367, 20);
            comboPriority.StyleController = layoutControl1;
            comboPriority.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(541, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 20);
            txtSearch.StyleController = layoutControl1;
            txtSearch.TabIndex = 6;
            // 
            // btnFilter
            // 
            btnFilter.Appearance.BackColor = Color.SeaGreen;
            btnFilter.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnFilter.Appearance.ForeColor = Color.White;
            btnFilter.Appearance.Options.UseBackColor = true;
            btnFilter.Appearance.Options.UseFont = true;
            btnFilter.Appearance.Options.UseForeColor = true;
            btnFilter.Location = new Point(12, 84);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(446, 25);
            btnFilter.StyleController = layoutControl1;
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Buscar";
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Appearance.BackColor = Color.DarkSeaGreen;
            btnClearFilter.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnClearFilter.Appearance.ForeColor = Color.White;
            btnClearFilter.Appearance.Options.UseBackColor = true;
            btnClearFilter.Appearance.Options.UseFont = true;
            btnClearFilter.Appearance.Options.UseForeColor = true;
            btnClearFilter.Location = new Point(12, 113);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(446, 25);
            btnClearFilter.StyleController = layoutControl1;
            btnClearFilter.TabIndex = 8;
            btnClearFilter.Text = "Limpiar";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { Usuarios, Incio, Fin, Estatus, Prioridad, Busqueda, layoutControlItem7, layoutControlItem8 });
            Root.Name = "Root";
            Root.Size = new Size(922, 153);
            Root.TextVisible = false;
            // 
            // Usuarios
            // 
            Usuarios.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuarios.AppearanceItemCaption.Options.UseFont = true;
            Usuarios.Control = gridLookUpEditUsers;
            Usuarios.Location = new Point(0, 0);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(450, 24);
            Usuarios.TextSize = new Size(67, 17);
            // 
            // Incio
            // 
            Incio.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Incio.AppearanceItemCaption.Options.UseFont = true;
            Incio.Control = dateFrom;
            Incio.Location = new Point(450, 0);
            Incio.Name = "Incio";
            Incio.Size = new Size(452, 24);
            Incio.Text = "Fecha inicio";
            Incio.TextSize = new Size(67, 17);
            // 
            // Fin
            // 
            Fin.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Fin.AppearanceItemCaption.Options.UseFont = true;
            Fin.Control = dateTo;
            Fin.Location = new Point(450, 24);
            Fin.Name = "Fin";
            Fin.Size = new Size(452, 24);
            Fin.Text = "Fecha final";
            Fin.TextSize = new Size(67, 17);
            // 
            // Estatus
            // 
            Estatus.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Estatus.AppearanceItemCaption.Options.UseFont = true;
            Estatus.Control = comboStatus;
            Estatus.Location = new Point(0, 24);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(450, 24);
            Estatus.TextSize = new Size(67, 17);
            // 
            // Prioridad
            // 
            Prioridad.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Prioridad.AppearanceItemCaption.Options.UseFont = true;
            Prioridad.Control = comboPriority;
            Prioridad.Location = new Point(0, 48);
            Prioridad.Name = "Prioridad";
            Prioridad.Size = new Size(450, 24);
            Prioridad.TextSize = new Size(67, 17);
            // 
            // Busqueda
            // 
            Busqueda.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Busqueda.AppearanceItemCaption.Options.UseFont = true;
            Busqueda.Control = txtSearch;
            Busqueda.Location = new Point(450, 48);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(452, 85);
            Busqueda.Text = "Busqueda:";
            Busqueda.TextSize = new Size(67, 17);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.BackColor = Color.White;
            layoutControlItem7.AppearanceItemCaption.Options.UseBackColor = true;
            layoutControlItem7.AppearanceItemCaptionDisabled.BackColor = Color.White;
            layoutControlItem7.AppearanceItemCaptionDisabled.Options.UseBackColor = true;
            layoutControlItem7.Control = btnFilter;
            layoutControlItem7.Location = new Point(0, 72);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(450, 29);
            layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = btnClearFilter;
            layoutControlItem8.Location = new Point(0, 101);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(450, 32);
            layoutControlItem8.TextVisible = false;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.SeaGreen;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(12, 36);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(498, 47);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "ADMINISTRADOR DE TAREAS";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verTareasToolStripMenuItem, graficosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1226, 25);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // verTareasToolStripMenuItem
            // 
            verTareasToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            verTareasToolStripMenuItem.Size = new Size(62, 21);
            verTareasToolStripMenuItem.Text = " Tareas";
            // 
            // graficosToolStripMenuItem
            // 
            graficosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            graficosToolStripMenuItem.Size = new Size(72, 21);
            graficosToolStripMenuItem.Text = "Graficos ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(layoutControl1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(933, 192);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnNew
            // 
            btnNew.Appearance.BackColor = Color.SeaGreen;
            btnNew.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Appearance.ForeColor = Color.White;
            btnNew.Appearance.Options.UseBackColor = true;
            btnNew.Appearance.Options.UseFont = true;
            btnNew.Appearance.Options.UseForeColor = true;
            btnNew.ImageOptions.Image = (Image)resources.GetObject("btnNew.ImageOptions.Image");
            btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            btnNew.Location = new Point(534, 48);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(191, 35);
            btnNew.TabIndex = 28;
            btnNew.Text = "Crear nueva tarea";
            btnNew.Click += btnNew_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 729);
            Controls.Add(btnNew);
            Controls.Add(groupBox1);
            Controls.Add(labelControl5);
            Controls.Add(gridControl1);
            Controls.Add(menuStrip1);
            IconOptions.Image = (Image)resources.GetObject("MainForm.IconOptions.Image");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.SimpleButton btnClearFilter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verTareasToolStripMenuItem;
        private ToolStripMenuItem graficosToolStripMenuItem;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}