using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGauges.Presets.PresetManager;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Filters;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;
using TaskManager.WinForms.UI.Helpers;

namespace TaskManager.WinForms.UI
{
    public partial class MainForm : XtraForm
    {
        private readonly TaskService _taskService;
        private readonly UserDto _currentUser;

        public MainForm(TaskService taskService, UserDto currentUser)
        {
            InitializeComponent();
            FormFadeIn.FadeIn(this);

            _taskService = taskService;
            _currentUser = currentUser;

            ConfigureGrid();
            gridView1.RowStyle += gridView1_RowStyle;
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            LoadFilters();
            LoadUsers();
            LoadTasks();          
        }
        private void LoadTasks()
        {
            var filter = BuildFilter();
            var tasks = _taskService.GetTasks(filter).ToList();

            gridControl1.DataSource = tasks;

            gridView1.PopulateColumns();
            gridView1.BestFitColumns();

            AddActionButtons();
            TranslateColumns();
        }

        private void TranslateColumns()
        {
            if (gridView1.Columns["Description"] == null) return;

            gridView1.Columns["Id"].Caption = "ID";
            gridView1.Columns["Description"].Caption = "Descripción";
            gridView1.Columns["AssignedUserId"].Caption = "Asignado";
            gridView1.Columns["Status"].Caption = "Estado";
            gridView1.Columns["Priority"].Caption = "Prioridad";
            gridView1.Columns["DueDate"].Caption = "Fecha de Compromiso";
            gridView1.Columns["DueDate"].Width = 200;
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
        private void AddActionButtons()
        {
            // If there are no columns yet (first load), we exit
            if (gridView1.Columns.Count == 0)
                return;

            var buttonEdit = new RepositoryItemButtonEdit();
            buttonEdit.TextEditStyle = TextEditStyles.HideTextEditor;
            buttonEdit.Buttons.Clear();

            buttonEdit.Buttons.Add(new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.edit) },
                ToolTip = "Editar"
            });

            buttonEdit.Buttons.Add(new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.clock) },
                ToolTip = "Cambiar estado"
            });

            buttonEdit.Buttons.Add(new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.done) },
                ToolTip = "Marcar como completada"
            });

            buttonEdit.Buttons.Add(new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { Image = ImageHelper.ByteArrayToImage(Properties.Resources.delete) },
                ToolTip = "Eliminar"
            });

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

            //Important: Allow clicking in that column
            colAcciones.OptionsColumn.AllowEdit = true;
            colAcciones.OptionsColumn.ReadOnly = false;
            colAcciones.ShowButtonMode = ShowButtonModeEnum.ShowAlways;

            //Optional: Mark the remaining columns as read-only
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
        private void ActionButtons_Click(object sender, ButtonPressedEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;

            var row = gridView1.GetRow(rowHandle) as TaskItem;
            if (row == null) return;

            int index = e.Button.Index;

            switch (index)
            {
                case 0: 
                    btnEdit_Click(row, EventArgs.Empty);
                    break;

                case 1:
                    ChangeTaskStatus(row);
                    break;

                case 2: 
                    MarkAsDone(row);
                    break;

                case 3: 
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

        private void LoadFilters()
        {
            comboStatus.Properties.Items.Clear();
            comboStatus.Properties.Items.Add("Todos");
            comboStatus.Properties.Items.AddRange(Enum.GetNames(typeof(TaskStatus)));
            comboStatus.SelectedIndex = 0;

            comboPriority.Properties.Items.Clear();
            comboPriority.Properties.Items.Add("Todos");
            comboPriority.Properties.Items.AddRange(Enum.GetNames(typeof(TaskPriority)));
            comboPriority.SelectedIndex = 0;
        }

        private void LoadUsers()
        {
            var users = _taskService.GetUsers().ToList();

            users.Insert(0, new UserDto
            {
                Id = 0,
                FullName = "Todos"
            });

            gridLookUpEditUsers.Properties.DataSource = users;
            gridLookUpEditUsers.Properties.DisplayMember = "FullName";
            gridLookUpEditUsers.Properties.ValueMember = "Id";

            var view = gridLookUpEditUsers.Properties.PopupView as DevExpress.XtraGrid.Views.Grid.GridView;

            view.Columns.Clear();
            view.OptionsView.ShowColumnHeaders = true;
            view.OptionsView.ShowIndicator = false;

            view.Columns.AddVisible("Id", "ID").Width = 50;
            view.Columns.AddVisible("FullName", "Nombre").Width = 200;

            gridLookUpEditUsers.EditValue = 0;
        }

        private TaskFilter BuildFilter()
        {
            var f = new TaskFilter();

            // Status
            if (comboStatus.SelectedIndex > 0)
                f.Status = Enum.Parse<TaskStatus>(comboStatus.SelectedItem.ToString());

            // Priority
            if (comboPriority.SelectedIndex > 0)
                f.Priority = Enum.Parse<TaskPriority>(comboPriority.SelectedItem.ToString());

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
            SuccessHandler.Show("Tarea editada correctamente, exito");
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
                SuccessHandler.Show("Tarea eliminada correctamente, exito");
                LoadTasks();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            gridLookUpEditUsers.EditValue = 0;
            comboStatus.SelectedIndex = 0;
            comboPriority.SelectedIndex = 0;

            dateFrom.EditValue = null;
            dateTo.EditValue = null;

            txtSearch.Text = string.Empty;

            LoadTasks();
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

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "AssignedUserId")
            {
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.DisplayText = "Sin asignar";
                    return;
                }

                var users = _taskService.GetUsers().ToList();
                int userId = Convert.ToInt32(e.Value);

                var user = users.FirstOrDefault(u => u.Id == userId);

                e.DisplayText = user != null ? user.FullName : "Sin asignar";
            }
        }

    }

}
