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
            lblAdmistration = new DevExpress.XtraEditors.LabelControl();
            menuStrip1 = new MenuStrip();
            verTareasToolStripMenuItem = new ToolStripMenuItem();
            dashbiardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            graficosToolStripMenuItem = new ToolStripMenuItem();
            groupBoxFilter = new GroupBox();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
            panelLegend = new DevExpress.XtraEditors.PanelControl();
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
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelLegend).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new Padding(4);
            gridControl1.Location = new Point(14, 353);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1539, 538);
            gridControl1.TabIndex = 8;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 373;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
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
            layoutControl1.Location = new Point(6, 32);
            layoutControl1.Margin = new Padding(4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1137, 37, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1076, 188);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEditUsers
            // 
            gridLookUpEditUsers.Location = new Point(110, 14);
            gridLookUpEditUsers.Margin = new Padding(4);
            gridLookUpEditUsers.Name = "gridLookUpEditUsers";
            gridLookUpEditUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEditUsers.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEditUsers.Size = new Size(425, 22);
            gridLookUpEditUsers.StyleController = layoutControl1;
            gridLookUpEditUsers.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.DetailHeight = 373;
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dateFrom
            // 
            dateFrom.EditValue = null;
            dateFrom.Location = new Point(635, 14);
            dateFrom.Margin = new Padding(4);
            dateFrom.Name = "dateFrom";
            dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFrom.Size = new Size(427, 22);
            dateFrom.StyleController = layoutControl1;
            dateFrom.TabIndex = 4;
            // 
            // dateTo
            // 
            dateTo.EditValue = null;
            dateTo.Location = new Point(635, 40);
            dateTo.Margin = new Padding(4);
            dateTo.Name = "dateTo";
            dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Size = new Size(427, 22);
            dateTo.StyleController = layoutControl1;
            dateTo.TabIndex = 4;
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(110, 40);
            comboStatus.Margin = new Padding(4);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Size = new Size(425, 22);
            comboStatus.StyleController = layoutControl1;
            comboStatus.TabIndex = 2;
            // 
            // comboPriority
            // 
            comboPriority.Location = new Point(110, 66);
            comboPriority.Margin = new Padding(4);
            comboPriority.Name = "comboPriority";
            comboPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboPriority.Size = new Size(425, 22);
            comboPriority.StyleController = layoutControl1;
            comboPriority.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(635, 66);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(427, 22);
            txtSearch.StyleController = layoutControl1;
            txtSearch.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.Appearance.BackColor = Color.SeaGreen;
            btnFilter.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnFilter.Appearance.ForeColor = Color.White;
            btnFilter.Appearance.Options.UseBackColor = true;
            btnFilter.Appearance.Options.UseFont = true;
            btnFilter.Appearance.Options.UseForeColor = true;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Location = new Point(14, 92);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(521, 30);
            btnFilter.StyleController = layoutControl1;
            btnFilter.TabIndex = 6;
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
            btnClearFilter.Cursor = Cursors.Hand;
            btnClearFilter.Location = new Point(14, 126);
            btnClearFilter.Margin = new Padding(4);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(521, 30);
            btnClearFilter.StyleController = layoutControl1;
            btnClearFilter.TabIndex = 7;
            btnClearFilter.Text = "Limpiar";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { Usuarios, Incio, Fin, Estatus, Prioridad, Busqueda, layoutControlItem7, layoutControlItem8 });
            Root.Name = "Root";
            Root.Size = new Size(1076, 188);
            Root.TextVisible = false;
            // 
            // Usuarios
            // 
            Usuarios.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuarios.AppearanceItemCaption.Options.UseFont = true;
            Usuarios.Control = gridLookUpEditUsers;
            Usuarios.Location = new Point(0, 0);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(525, 26);
            Usuarios.TextSize = new Size(81, 21);
            // 
            // Incio
            // 
            Incio.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Incio.AppearanceItemCaption.Options.UseFont = true;
            Incio.Control = dateFrom;
            Incio.Location = new Point(525, 0);
            Incio.Name = "Incio";
            Incio.Size = new Size(527, 26);
            Incio.Text = "Fecha inicio";
            Incio.TextSize = new Size(81, 21);
            // 
            // Fin
            // 
            Fin.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Fin.AppearanceItemCaption.Options.UseFont = true;
            Fin.Control = dateTo;
            Fin.Location = new Point(525, 26);
            Fin.Name = "Fin";
            Fin.Size = new Size(527, 26);
            Fin.Text = "Fecha final";
            Fin.TextSize = new Size(81, 21);
            // 
            // Estatus
            // 
            Estatus.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Estatus.AppearanceItemCaption.Options.UseFont = true;
            Estatus.Control = comboStatus;
            Estatus.Location = new Point(0, 26);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(525, 26);
            Estatus.TextSize = new Size(81, 21);
            // 
            // Prioridad
            // 
            Prioridad.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Prioridad.AppearanceItemCaption.Options.UseFont = true;
            Prioridad.Control = comboPriority;
            Prioridad.Location = new Point(0, 52);
            Prioridad.Name = "Prioridad";
            Prioridad.Size = new Size(525, 26);
            Prioridad.TextSize = new Size(81, 21);
            // 
            // Busqueda
            // 
            Busqueda.AppearanceItemCaption.Font = new Font("Segoe UI", 9.75F);
            Busqueda.AppearanceItemCaption.Options.UseFont = true;
            Busqueda.Control = txtSearch;
            Busqueda.Location = new Point(525, 52);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(527, 112);
            Busqueda.Text = "Busqueda:";
            Busqueda.TextSize = new Size(81, 21);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.BackColor = Color.White;
            layoutControlItem7.AppearanceItemCaption.Options.UseBackColor = true;
            layoutControlItem7.AppearanceItemCaptionDisabled.BackColor = Color.White;
            layoutControlItem7.AppearanceItemCaptionDisabled.Options.UseBackColor = true;
            layoutControlItem7.Control = btnFilter;
            layoutControlItem7.Location = new Point(0, 78);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(525, 34);
            layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = btnClearFilter;
            layoutControlItem8.Location = new Point(0, 112);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(525, 52);
            layoutControlItem8.TextVisible = false;
            // 
            // lblAdmistration
            // 
            lblAdmistration.Appearance.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmistration.Appearance.ForeColor = Color.SeaGreen;
            lblAdmistration.Appearance.Options.UseFont = true;
            lblAdmistration.Appearance.Options.UseForeColor = true;
            lblAdmistration.Location = new Point(14, 44);
            lblAdmistration.Margin = new Padding(4);
            lblAdmistration.Name = "lblAdmistration";
            lblAdmistration.Size = new Size(617, 60);
            lblAdmistration.TabIndex = 25;
            lblAdmistration.Text = "ADMINISTRADOR DE TAREAS";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verTareasToolStripMenuItem, graficosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1561, 31);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // verTareasToolStripMenuItem
            // 
            verTareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashbiardToolStripMenuItem1, exitToolStripMenuItem });
            verTareasToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            verTareasToolStripMenuItem.Size = new Size(69, 27);
            verTareasToolStripMenuItem.Text = "Menu";
            // 
            // dashbiardToolStripMenuItem1
            // 
            dashbiardToolStripMenuItem1.Name = "dashbiardToolStripMenuItem1";
            dashbiardToolStripMenuItem1.Size = new Size(224, 28);
            dashbiardToolStripMenuItem1.Text = "Dashboard";
            dashbiardToolStripMenuItem1.Click += dashbiardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 28);
            exitToolStripMenuItem.Text = "Salir";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // graficosToolStripMenuItem
            // 
            graficosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            graficosToolStripMenuItem.Size = new Size(14, 27);
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(layoutControl1);
            groupBoxFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(14, 110);
            groupBoxFilter.Margin = new Padding(4);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Padding = new Padding(4);
            groupBoxFilter.Size = new Size(1088, 236);
            groupBoxFilter.TabIndex = 27;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filtros";
            // 
            // btnNew
            // 
            btnNew.Appearance.BackColor = Color.SeaGreen;
            btnNew.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Appearance.ForeColor = Color.White;
            btnNew.Appearance.Options.UseBackColor = true;
            btnNew.Appearance.Options.UseFont = true;
            btnNew.Appearance.Options.UseForeColor = true;
            btnNew.Cursor = Cursors.Hand;
            btnNew.ImageOptions.Image = (Image)resources.GetObject("btnNew.ImageOptions.Image");
            btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            btnNew.Location = new Point(614, 55);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(223, 43);
            btnNew.TabIndex = 1;
            btnNew.Text = "Crear nueva tarea";
            btnNew.Click += btnNew_Click;
            // 
            // panelLegend
            // 
            panelLegend.Location = new Point(1109, 122);
            panelLegend.Name = "panelLegend";
            panelLegend.Size = new Size(440, 224);
            panelLegend.TabIndex = 28;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 897);
            Controls.Add(panelLegend);
            Controls.Add(btnNew);
            Controls.Add(groupBoxFilter);
            Controls.Add(lblAdmistration);
            Controls.Add(gridControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.Image = (Image)resources.GetObject("MainForm.IconOptions.Image");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
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
            groupBoxFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelLegend).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblAdmistration;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verTareasToolStripMenuItem;
        private ToolStripMenuItem graficosToolStripMenuItem;
        private GroupBox groupBoxFilter;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl panelLegend;
        private ToolStripMenuItem dashbiardToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}