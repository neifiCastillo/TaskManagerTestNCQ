using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.WinForms.UI
{
    public partial class MainForm : XtraForm
    {
        private readonly TaskService _taskService;
        private readonly UserDto _currentUser;

        public MainForm(TaskService taskService, UserDto currentUser)
        {
            InitializeComponent();
            _taskService = taskService;
            _currentUser = currentUser;

            ConfigureGrid();
            LoadFilters();
            LoadUsers();
            LoadTasks();
            ApplyGridStyles();
        }


        private void LoadTasks()
        {
            var filter = BuildFilter();
            var tasks = _taskService.GetTasks(filter).ToList();
            gridControl1.DataSource = tasks;

            gridView1.BestFitColumns();
        }
        private void ConfigureGrid()
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;

            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ColumnAutoWidth = false;

            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9);

            gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
        }

        //private void AddGridButtons()
        //{
        //    BOTÓN EDITAR
        //    var editButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
        //    editButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
        //    editButton.Buttons[0].ImageOptions.Image = Properties.Resources.edit;
        //    editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
        //    editButton.ButtonClick += EditButton_Click;

        //    colEdit.ColumnEdit = editButton;

        //    BOTÓN ELIMINAR
        //    var deleteButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
        //    deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
        //    deleteButton.Buttons[0].ImageOptions.Image = Properties.Resources.delete;
        //    deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
        //    deleteButton.ButtonClick += DeleteButton_Click;

        //    colDelete.ColumnEdit = deleteButton;
        //}

        //private void EditButton_Click(object sender, EventArgs e)
        //{
        //    btnEdit_Click(null, null);
        //}

        //private void DeleteButton_Click(object sender, EventArgs e)
        //{
        //    if (gridView1.GetFocusedRow() is TaskItem row)
        //    {
        //        if (XtraMessageBox.Show("¿Eliminar esta tarea?", "Confirmar", MessageBoxButtons.YesNo)
        //            == DialogResult.Yes)
        //        {
        //            _taskService.Delete(row.Id);
        //            LoadTasks();
        //            ShowToast("Tarea eliminada 😊");
        //        }
        //    }
        //}


        private void ShowToast(string message)
        {
            toastNotificationsManager1.Notifications.Clear();

            toastNotificationsManager1.Notifications.Add(
                new DevExpress.XtraBars.ToastNotifications.ToastNotification(
                    Guid.NewGuid(), // ID único
                    null,
                    "Notificación",
                    message,
                    null,
                    ToastNotificationTemplate.Text01)
            );

            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
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

            // STATUS
            if (comboStatus.SelectedIndex > 0)
                f.Status = Enum.Parse<TaskStatus>(comboStatus.SelectedItem.ToString());

            // PRIORITY
            if (comboPriority.SelectedIndex > 0)
                f.Priority = Enum.Parse<TaskPriority>(comboPriority.SelectedItem.ToString());

            // USUARIO
            int userId = Convert.ToInt32(gridLookUpEditUsers.EditValue);
            if (userId > 0)
                f.AssignedUserId = userId;

            // DATES
            if (dateFrom.EditValue is DateTime from)
                f.FromDate = from;
            if (dateTo.EditValue is DateTime to)
                f.ToDate = to;

            // SEARCH
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() is TaskItem row)
            {
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
            else
            {
                XtraMessageBox.Show("Seleccione una tarea para editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() is TaskItem row)
            {
                if (XtraMessageBox.Show("¿Eliminar esta tarea?", "Confirmación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _taskService.DeleteTask(row.Id);
                    LoadTasks();
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione una tarea para eliminar.");
            }
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() is TaskItem row)
            {
                _taskService.ChangeStatus(row.Id, TaskStatus.InProgress);
                LoadTasks();
            }
            else
            {
                XtraMessageBox.Show("Seleccione una tarea.");
            }
        }

        private void ApplyGridStyles()
        {
            // PRIORIDAD ALTA → rojo
            var high = new DevExpress.XtraGrid.StyleFormatCondition();
            high.Appearance.BackColor = Color.FromArgb(255, 80, 80);
            high.Appearance.ForeColor = Color.White;
            high.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            high.Expression = "[Priority] = 2";   // Enum: Alta = 2
            high.ApplyToRow = true;
            gridView1.FormatConditions.Add(high);

            // PRIORIDAD MEDIA → amarillo
            var medium = new DevExpress.XtraGrid.StyleFormatCondition();
            medium.Appearance.BackColor = Color.FromArgb(255, 230, 140);
            medium.Appearance.ForeColor = Color.Black;
            medium.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            medium.Expression = "[Priority] = 1";   // Media = 1
            medium.ApplyToRow = true;
            gridView1.FormatConditions.Add(medium);

            // PRIORIDAD BAJA → verde
            var low = new DevExpress.XtraGrid.StyleFormatCondition();
            low.Appearance.BackColor = Color.FromArgb(180, 255, 180);
            low.Appearance.ForeColor = Color.Black;
            low.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            low.Expression = "[Priority] = 0";   // Baja = 0
            low.ApplyToRow = true;
            gridView1.FormatConditions.Add(low);
        }

    }

}
