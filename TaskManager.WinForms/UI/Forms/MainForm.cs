using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Filters;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;
using TaskManager.WinForms.UI.Helpers;
using TaskManager.WinForms.UI.Forms;
using TaskManager.Application.Helpers;
using TaskManager.Infrastructure.Repositories;
using TaskManager.Application.Factories;
using DevExpress.CodeParser;
using DevExpress.XtraGrid;

namespace TaskManager.WinForms.UI
{
    public partial class MainForm : XtraForm
    {
        private readonly TaskService _taskService;
        private readonly UserDto _currentUser;
        private SessionTimeoutManager _sessionTimeout;
        private RepositoryItemButtonEdit buttonEdit;
        private bool _logoutConfirm = false;
        public MainForm(TaskService taskService, UserDto currentUser)
        {
            InitializeComponent();
            FormFadeIn.FadeIn(this);

            _taskService = taskService;
            _currentUser = currentUser;

            buttonEdit = new RepositoryItemButtonEdit();
            ConfigureGrid();
            gridView1.RowStyle += gridView1_RowStyle;
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            CovertToFilterDate();
            LoadFilters();
            LoadUsers();
            LoadTasks();
            BuildLegend();

            _sessionTimeout = new SessionTimeoutManager(this);
            _sessionTimeout.Start();
        }
        private void LoadTasks()
        {
            var filter = BuildFilter();
            var tasks = _taskService.GetTasks(filter).ToList();

            gridControl1.DataSource = tasks;

            gridView1.PopulateColumns();

            //Allows filtering using the displayed text
            gridView1.Columns["Status"].FilterMode = ColumnFilterMode.DisplayText;
            gridView1.Columns["Priority"].FilterMode = ColumnFilterMode.DisplayText;

            gridView1.BestFitColumns();

            HideUnnecessaryColumns();
            AddActionButtons();
            gridView1.CustomRowCellEdit += gridView1_CustomRowCellEdit;
            TranslateColumns();
            ConfigureDescriptionColumn();
            ApplyFixedColumnSizes();
        }
        private void TranslateColumns()
        {
            if (gridView1.Columns["Description"] == null) return;

            gridView1.Columns["Id"].Caption = "ID";
            gridView1.Columns["Description"].Caption = "Descripción";
            gridView1.Columns["AssignedUserId"].Caption = "Asignada A";
            var colAssigned = gridView1.Columns["AssignedUserId"];
            if (colAssigned != null)
            {
                colAssigned.Caption = "Asignada A";
                colAssigned.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                colAssigned.OptionsFilter.AutoFilterCondition =DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                colAssigned.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            }
            gridView1.Columns["Status"].Caption = "Estado";
            gridView1.Columns["Priority"].Caption = "Prioridad";
            gridView1.Columns["DueDate"].Caption = "Fecha de Compromiso";
            var colDueDate = gridView1.Columns["DueDate"];
            if (colDueDate != null)
            {
                var filterDateEdit = new RepositoryItemDateEdit();
                colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                colDueDate.DisplayFormat.FormatString = "dd/MM/yyyy";
                colDueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                filterDateEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            }
            gridView1.Columns["Notes"].Caption = "Notas";
            gridView1.Columns["CreatedAt"].Caption = "Creada";
            gridView1.Columns["UpdatedAt"].Caption = "Actualizada";
            gridView1.Columns["Acciones"].Caption = "Acciones";

        }
        private void ConfigureGrid()
        {
            //Allow editing in the grid in general
            gridView1.OptionsBehavior.Editable = true;
            gridView1.OptionsBehavior.ReadOnly = false;

            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ColumnAutoWidth = false;

            gridView1.Appearance.HeaderPanel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridView1.Appearance.Row.Font = new Font("Segoe UI", 9);

            gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
        }
        private void HideUnnecessaryColumns()
        {
            string[] columnsToHide = { "Id", "Notes", "CreatedAt", "UpdatedAt" };

            foreach (var colName in columnsToHide)
            {
                var col = gridView1.Columns[colName];
                if (col != null)
                    col.Visible = false;
            }
        }
        private void AddActionButtons()
        {
            // If there are no columns yet (first load), we exit
            if (gridView1.Columns.Count == 0)
                return;

            //var buttonEdit = new RepositoryItemButtonEdit();
            buttonEdit.TextEditStyle = TextEditStyles.HideTextEditor;
            buttonEdit.Buttons.Clear();

            var btnEdit = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.edit) },
                ToolTip = "Editar",
                Tag = "EDIT"
            };

            var btnStart = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.clock) },
                ToolTip = "Iniciar tarea",
                Tag = "START"
            };

            var btnDetail = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.detail) },
                ToolTip = "Ver detalles",
                Tag = "DETAIL"
            };

            var btnDone = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.done) },
                ToolTip = "Marcar como completada",
                Tag = "DONE"
            };

            var btnDelete = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.delete) },
                ToolTip = "Eliminar",
                Tag = "DELETE"
            };

            // saved the buttons in the base repository.
            buttonEdit.Buttons.Add(btnEdit);
            buttonEdit.Buttons.Add(btnStart);
            buttonEdit.Buttons.Add(btnDetail);
            buttonEdit.Buttons.Add(btnDone);
            buttonEdit.Buttons.Add(btnDelete);

            buttonEdit.ButtonClick += ActionButtons_Click;

            gridControl1.RepositoryItems.Add(buttonEdit);

            //Create/locate "Actions" column
            GridColumn colAcciones = gridView1.Columns["Acciones"];
            if (colAcciones == null)
            {
                colAcciones = gridView1.Columns.AddVisible("Acciones");
            }

            colAcciones.Caption = "Acciones";
            colAcciones.ColumnEdit = buttonEdit;
            colAcciones.VisibleIndex = gridView1.Columns.Count;

            //Allow clicking in that column
            colAcciones.OptionsColumn.AllowEdit = true;
            colAcciones.OptionsColumn.ReadOnly = false;
            colAcciones.ShowButtonMode = ShowButtonModeEnum.ShowAlways;

            //Mark the remaining columns as read-only
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.FieldName != "Acciones")
                {
                    col.OptionsColumn.AllowEdit = false;
                    col.OptionsColumn.ReadOnly = true;
                }
            }
            gridView1.Columns["Acciones"].Width = 200;
            gridView1.Columns["Acciones"].MinWidth = 200;
            colAcciones.AppearanceCell.BackColor = Color.White;
            colAcciones.AppearanceCell.ForeColor = Color.Black;
            colAcciones.AppearanceCell.Options.UseBackColor = true;
            colAcciones.AppearanceCell.Options.UseForeColor = true;
        }
        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Acciones") return;

            var row = gridView1.GetRow(e.RowHandle) as TaskItem;
            if (row == null) return;

            var clone = new RepositoryItemButtonEdit();
            clone.TextEditStyle = TextEditStyles.HideTextEditor;
            clone.ButtonClick += ActionButtons_Click; 

            clone.Buttons.Clear();

            // Original buttons
            var btnEdit = buttonEdit.Buttons[0];
            var btnStart = buttonEdit.Buttons[1];
            var btnDetail = buttonEdit.Buttons[2];
            var btnDone = buttonEdit.Buttons[3];
            var btnDelete = buttonEdit.Buttons[4];

            switch (row.Status)
            {
                case TaskStatus.Pending:
                    bool overdue = row.DueDate.Date < DateTime.Today;

                    clone.Buttons.Add(btnEdit);

                    if (!overdue) 
                        clone.Buttons.Add(btnStart);

                    clone.Buttons.Add(btnDetail);
                    clone.Buttons.Add(btnDelete);
                    break;

                case TaskStatus.InProgress:
                    clone.Buttons.Add(btnDetail);
                    clone.Buttons.Add(btnDone);
                    break;

                case TaskStatus.Done:
                    clone.Buttons.Add(btnDetail);
                    clone.Buttons.Add(btnDelete);
                    break;
            }

            e.RepositoryItem = clone;
        }
        private void ActionButtons_Click(object sender, ButtonPressedEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;

            var row = gridView1.GetRow(rowHandle) as TaskItem;
            if (row == null) return;

            if (e.Button.Tag is not string action || string.IsNullOrWhiteSpace(action))
                return;

            switch (action)
            {
                case "EDIT":
                    btnEdit_Click(row, EventArgs.Empty);
                    break;

                case "START":
                    ChangeTaskStatus(row);
                    break;

                case "DETAIL":
                    ShowTaskDetails(row);
                    break;

                case "DONE":
                    MarkAsDone(row);
                    break;

                case "DELETE":
                    btnDelete_Click(row, EventArgs.Empty);
                    break;
            }
        }
        private void MarkAsDone(TaskItem row)
        {
            if (row.Status == TaskStatus.Done)
            {
                XtraMessageBox.Show("Esta tarea ya está completada.");
                return;
            }

            if (row.Status != TaskStatus.InProgress)
            {
                XtraMessageBox.Show("Solo las tareas que están EN PROCESO pueden ser completadas.");
                return;
            }

            _taskService.ChangeStatus(row.Id, TaskStatus.Done);
            SuccessHandler.Show("Completada con exito");
            LoadTasks();
        }
        private void ChangeTaskStatus(TaskItem row)
        {
            switch (row.Status)
            {
                case TaskStatus.Pending:
                    _taskService.ChangeStatus(row.Id, TaskStatus.InProgress);
                    SuccessHandler.Show("Tarea en proceso, exito");
                    LoadTasks();
                    break;

                case TaskStatus.InProgress:
                    XtraMessageBox.Show("La tarea ya está en proceso.");
                    break;

                case TaskStatus.Done:
                    XtraMessageBox.Show("La tarea ya está completada.");
                    break;
            }
        }
        private void ShowTaskDetails(TaskItem task)
        {
            var detailsForm = new TaskDetailsForm(task, _taskService);
            detailsForm.ShowDialog();
        }
        private void LoadFilters()
        {
            // Status
            comboStatus.Properties.Items.Clear();
            comboStatus.Properties.Items.Add("Todos");
            comboStatus.Properties.Items.Add("Pendiente");
            comboStatus.Properties.Items.Add("En proceso");
            comboStatus.Properties.Items.Add("Completada");
            comboStatus.SelectedIndex = 0;

            // Priority
            comboPriority.Properties.Items.Clear();
            comboPriority.Properties.Items.Add("Todos");
            comboPriority.Properties.Items.Add("Alta");
            comboPriority.Properties.Items.Add("Media");
            comboPriority.Properties.Items.Add("Baja");
            comboPriority.SelectedIndex = 0;
        }
        private void LoadUsers()
        {
            var users = _taskService.GetUsers().ToList();

            users.Insert(0, new UserDto
            {
                Id = 0,
                Username = "Todos"
            });

            gridLookUpEditUsers.Properties.DataSource = users;
            gridLookUpEditUsers.Properties.DisplayMember = "Username";
            gridLookUpEditUsers.Properties.ValueMember = "Id";

            var view = (GridView)gridLookUpEditUsers.Properties.PopupView;

            view.Columns.Clear();
            view.OptionsView.ShowColumnHeaders = true;
            view.OptionsView.ShowIndicator = false;

            view.Columns.AddVisible("Id", "ID").Width = 50;
            view.Columns.AddVisible("Username", "Username").Width = 200;

            gridLookUpEditUsers.EditValue = 0;
        }
        private TaskFilter BuildFilter()
        {
            var f = new TaskFilter();

            // Status
            if (comboStatus.SelectedIndex > 0)
                f.Status = comboStatus.SelectedItem.ToString() switch
                {
                    "Pendiente" => TaskStatus.Pending,
                    "En proceso" => TaskStatus.InProgress,
                    "Completada" => TaskStatus.Done,
                    _ => null
                };

            // Priority
            if (comboPriority.SelectedIndex > 0)
                f.Priority = comboPriority.SelectedItem.ToString() switch
                {
                    "Alta" => TaskPriority.High,
                    "Media" => TaskPriority.Medium,
                    "Baja" => TaskPriority.Low,
                    _ => null
                };

            // User
            int userId = Convert.ToInt32(gridLookUpEditUsers.EditValue);
            if (userId > 0)
                f.AssignedUserId = userId;

            // Dates
            if (dateFrom.EditValue is DateTime from)
                f.FromDate = from;
            if (dateTo.EditValue is DateTime to)
                f.ToDate = to;

            // Search
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                f.Search = txtSearch.Text;

            return f;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new TaskForm(_taskService, _currentUser);
            form.ShowDialog();
            LoadTasks();
        }
        private void btnEdit_Click(object rowObj, EventArgs e)
        {
            var row = rowObj as TaskItem;

            if (row == null)
            {
                if (gridView1.GetFocusedRow() is not TaskItem r2)
                {
                    XtraMessageBox.Show("Seleccione una tarea para editar.");
                    return;
                }
                row = r2;
            }

            if (row.Status != TaskStatus.Pending)
            {
                if (row.Status == TaskStatus.InProgress)
                    XtraMessageBox.Show("Solo las tareas pendientes pueden ser editadas. Esta tarea ya está en proceso.");

                else if (row.Status == TaskStatus.Done)
                    XtraMessageBox.Show("Esta tarea está completada y no puede ser editada.");

                return;
            }

            var dto = new TaskDto
            {
                Id = row.Id,
                Description = row.Description,
                AssignedUserId = row.AssignedUserId,
                Priority = row.Priority,
                Status = row.Status,
                DueDate = row.DueDate,
                Notes = row.Notes
            };

            var form = new TaskForm(_taskService, _currentUser, dto);
            form.ShowDialog();
            LoadTasks();
        }
        private void btnDelete_Click(object rowObj, EventArgs e)
        {
            var row = rowObj as TaskItem;

            if (row == null)
            {
                if (gridView1.GetFocusedRow() is not TaskItem r2)
                {
                    XtraMessageBox.Show("Seleccione una tarea para eliminar.");
                    return;
                }
                row = r2;
            }
            if (row.Status == TaskStatus.InProgress)
            {
                XtraMessageBox.Show("No se puede eliminar una tarea que está en proceso.");
                return;
            }

            if (XtraMessageBox.Show("¿Eliminar esta tarea?", "Confirmación",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _taskService.DeleteTask(row.Id);
                LoadTasks();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {

            if (!ValidateDateFilters())
                return;

            LoadTasks();
        }
        private bool ValidateDateFilters()
        {
            bool hasFrom = dateFrom.EditValue is DateTime;
            bool hasTo = dateTo.EditValue is DateTime;

            if (hasFrom && !hasTo)
            {
                XtraMessageBox.Show(
                    "Debe seleccionar la fecha final.",
                    "Falta información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (!hasFrom && hasTo)
            {
                XtraMessageBox.Show(
                    "Debe seleccionar la fecha inicial.",
                    "Falta información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (hasFrom && hasTo)
            {
                DateTime from = (DateTime)dateFrom.EditValue;
                DateTime to = (DateTime)dateTo.EditValue;

                if (from > to)
                {
                    XtraMessageBox.Show(
                        "La fecha inicial no puede ser mayor que la fecha final.",
                        "Rango inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }

            return true;
        }
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilters();
            LoadTasks();
        }
        private void ClearFilters()
        {
            gridLookUpEditUsers.EditValue = 0;
            comboStatus.SelectedIndex = 0;
            comboPriority.SelectedIndex = 0;

            dateFrom.EditValue = null;
            dateTo.EditValue = null;

            txtSearch.Text = string.Empty;
        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;

            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;

            var statusValue = view.GetRowCellValue(e.RowHandle, "Status");
            if (statusValue != null)
            {
                TaskStatus status;

                if (statusValue is TaskStatus s)
                    status = s;
                else if (!Enum.TryParse(statusValue.ToString(), out status))
                    status = TaskStatus.Pending;

                if (status == TaskStatus.Done)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, 255, 150);
                    e.Appearance.ForeColor = Color.Black;
                    return;
                }
            }

            var priorityValue = view.GetRowCellValue(e.RowHandle, "Priority");
            if (priorityValue == null) return;

            TaskPriority priority;

            if (priorityValue is TaskPriority p)
                priority = p;
            else if (!Enum.TryParse(priorityValue.ToString(), out priority))
                return;

            switch (priority)
            {
                case TaskPriority.High:
                    e.Appearance.BackColor = Color.FromArgb(255, 80, 80); // red
                    e.Appearance.ForeColor = Color.White;
                    break;

                case TaskPriority.Medium:
                    e.Appearance.BackColor = Color.FromArgb(255, 230, 140); // yellow
                    e.Appearance.ForeColor = Color.Black;
                    break;

                case TaskPriority.Low:
                    e.Appearance.BackColor = Color.FromArgb(255, 200, 120); // orange
                    e.Appearance.ForeColor = Color.Black;
                    break;
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "AssignedUserId")
            {
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.DisplayText = "Sin asignar";
                    return;
                }
                if (!int.TryParse(e.Value.ToString(), out int userId))
                {
                    e.DisplayText = e.Value.ToString();
                    return;
                }

                var users = _taskService.GetUsers().ToList();
                var user = users.FirstOrDefault(u => u.Id == userId);

                e.DisplayText = user != null ? user.Username : "Sin asignar";
                return;
            }
            if (e.Column.FieldName == "Status")
            {
                var val = e.Value?.ToString();
                if (string.IsNullOrEmpty(val)) return;

                switch (val)
                {
                    case "Pending":
                        e.DisplayText = "Pendiente";
                        break;
                    case "InProgress":
                        e.DisplayText = "En proceso";
                        break;
                    case "Done":
                        e.DisplayText = "Completada";
                        break;
                }
            }

            if (e.Column.FieldName == "Priority")
            {
                var val = e.Value?.ToString();
                if (string.IsNullOrEmpty(val)) return;

                switch (val)
                {
                    case "High":
                        e.DisplayText = "Alta";
                        break;
                    case "Medium":
                        e.DisplayText = "Media";
                        break;
                    case "Low":
                        e.DisplayText = "Baja";
                        break;
                }
            }
        }
        private void BuildLegend()
        {
            LegendBuilder.BuildLegend(
                panelLegend,
                new[]
                {
            (ImageHelper.ByteArrayToImage(Properties.Resources.edit)!, "Editar"),
            (ImageHelper.ByteArrayToImage(Properties.Resources.clock)!, "Iniciar tarea"),
            (ImageHelper.ByteArrayToImage(Properties.Resources.detail)!, "Ver detalles"),
            (ImageHelper.ByteArrayToImage(Properties.Resources.done)!, "Marcar como completada"),
            (ImageHelper.ByteArrayToImage(Properties.Resources.delete)!, "Eliminar")
                }
            );
        }
        private void dashbiardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dash = new DashboardForm(_taskService);
            dash.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmExit(null))
                this.Close(); ;
        }

        private void ExitToLogin()
        {
            SessionManager.ClearSession();

            var services = ServiceFactory.Create();
            var login = new LoginForm(services.Auth, services.Tasks);

            login.Show();
        }
        private void ConfigureDescriptionColumn()
        {
            var colDesc = gridView1.Columns["Description"];
            if (colDesc == null) return;

            // Multi-line editor
            var memo = new RepositoryItemMemoEdit();
            gridControl1.RepositoryItems.Add(memo);

            colDesc.ColumnEdit = memo;

            // Text and row adjustment
            colDesc.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gridView1.OptionsView.RowAutoHeight = true;
        }

        private void CovertToFilterDate()
        {
            dateFrom.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateFrom.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            dateTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

        }
        private void ApplyFixedColumnSizes()
        {
            foreach (GridColumn col in gridView1.Columns)
            {
                col.OptionsColumn.FixedWidth = true;       
                col.OptionsColumn.AllowSize = false;      
                gridView1.Columns["Description"].Width = 250;
                gridView1.Columns["AssignedUserId"].Width = 220;
                gridView1.Columns["Status"].Width = 160;
                gridView1.Columns["Priority"].Width = 160;
                gridView1.Columns["DueDate"].Width = 250;
                gridView1.Columns["Acciones"].Width = 220;

            }

            gridView1.OptionsCustomization.AllowColumnResizing = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ConfirmExit(e);
            }
        }
        private bool ConfirmExit(FormClosingEventArgs? e)
        {
            if (_logoutConfirm)
                return true;

            var result = XtraMessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _logoutConfirm = true;

                ExitToLogin(); 

                return true;  
            }
            else
            {
                if (e != null)
                    e.Cancel = true;

                return false;
            }

        }

    }
}
