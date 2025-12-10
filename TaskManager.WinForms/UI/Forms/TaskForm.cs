using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.Domain.Enums;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.WinForms.UI
{
    public partial class TaskForm : XtraForm
    {
        private readonly TaskService _taskService;
        private readonly UserDto _currentUser;
        private readonly TaskDto? _editingTask;

        //Builder Create
        public TaskForm(TaskService taskService, UserDto user)
        {
            InitializeComponent();
            _taskService = taskService;
            _currentUser = user;
            FormFadeIn.FadeIn(this);
            LoadLookups();
        }

        // Builder edit
        public TaskForm(TaskService taskService, UserDto user, TaskDto task)
        {
            InitializeComponent();
            _taskService = taskService;
            _currentUser = user;
            _editingTask = task;
            FormFadeIn.FadeIn(this);
            LoadLookups();
            LoadTask();

            gridLookUpStatus.Enabled = false;
        }
        private void LoadLookups()
        {
            // Priority
            gridLookUpPriority.Properties.DataSource = new[]
            {
                new { Value = TaskPriority.High, Text = "Alta" },
                new { Value = TaskPriority.Medium, Text = "Media" },
                new { Value = TaskPriority.Low, Text = "Baja" }
            };
            gridLookUpPriority.Properties.DisplayMember = "Text";
            gridLookUpPriority.Properties.ValueMember = "Value";
            gridLookUpPriority.EditValue = TaskPriority.Medium;

            // Configure priority popup
            var viewPriority = (GridView)gridLookUpPriority.Properties.PopupView;
            viewPriority.Columns.Clear();

            // Only show text
            viewPriority.Columns.AddVisible("Text", "Prioridad");

            // Hide column with enum
            var colValueP = viewPriority.Columns["Value"];
            if (colValueP != null)
                colValueP.Visible = false;

            viewPriority.OptionsView.ShowIndicator = false;
            viewPriority.OptionsView.ShowColumnHeaders = false;

            // Dynamic colors
            viewPriority.RowStyle += (sender, e) =>
            {
                if (e.RowHandle < 0) return;

                string? priorityText = viewPriority.GetRowCellValue(e.RowHandle, "Text")?.ToString();

                if (priorityText == "Alta")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 80, 80);
                    e.Appearance.ForeColor = Color.White;
                }
                else if (priorityText == "Media")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 230, 140);
                    e.Appearance.ForeColor = Color.Black;
                }
                else if (priorityText == "Baja")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 200, 120);
                    e.Appearance.ForeColor = Color.Black;
                }
            };

            // status — only pending
            gridLookUpStatus.Properties.DataSource = new[]
            {
                new { Value = TaskStatus.Pending, Text = "Pendiente" }
            };
            gridLookUpStatus.Properties.DisplayMember = "Text";
            gridLookUpStatus.Properties.ValueMember = "Value";
            gridLookUpStatus.EditValue = TaskStatus.Pending;
            gridLookUpStatus.Enabled = false;

            // Configurar popup del estado
            var viewStatus = (GridView)gridLookUpStatus.Properties.PopupView;
            viewStatus.Columns.Clear();
            viewStatus.Columns.AddVisible("Text", "Estado");
            viewStatus.OptionsView.ShowIndicator = false;
            viewStatus.OptionsView.ShowColumnHeaders = false;

            // User
            var users = _taskService.GetUsers().ToList();
            gridLookUpUsers.Properties.DataSource = users;
            gridLookUpUsers.Properties.DisplayMember = "Username";
            gridLookUpUsers.Properties.ValueMember = "Id";

            var view = (GridView)gridLookUpUsers.Properties.PopupView;
            view.Columns.Clear();
            view.Columns.AddVisible("Username", "Usuario");
            view.OptionsView.ShowIndicator = false;
            view.OptionsView.ShowColumnHeaders = false;

            dateDueDate.Properties.MinValue = DateTime.Today;

            //dd / mm / yyy format
            dateDueDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateDueDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateDueDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateDueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            dateDueDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateDueDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            //Pre-select logged-in user when creating task
            if (_editingTask == null)
                gridLookUpUsers.EditValue = _currentUser.Id;
        }
        private void LoadTask()
        {
            if (_editingTask == null)
                return;

            txtDescription.Text = _editingTask.Description;
            gridLookUpPriority.EditValue = _editingTask.Priority;
            gridLookUpStatus.EditValue = _editingTask.Status;
            gridLookUpUsers.EditValue = _editingTask.AssignedUserId;
            dateDueDate.EditValue = _editingTask.DueDate;
            memoNotes.Text = _editingTask.Notes;

            btnSave.Text = "Editar";
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                XtraMessageBox.Show("Debe ingresar una descripción.");
                return false;
            }

            if (gridLookUpUsers.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un usuario asignado.");
                return false;
            }

            if (dateDueDate.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar una fecha de Compromiso.");
                return false;
            }
            
            if (dateDueDate.EditValue is DateTime dueDate)
            {
                if (dueDate < DateTime.Today)
                {
                    XtraMessageBox.Show("La fecha de compromiso no puede ser menor al día actual.");
                    return false;
                }
            }

            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var dto = new TaskDto
            {
                Description = txtDescription.Text,
                Priority = (TaskPriority)gridLookUpPriority.EditValue,
                Status = (TaskStatus)gridLookUpStatus.EditValue,
                AssignedUserId = (int)gridLookUpUsers.EditValue,
                DueDate = (DateTime)dateDueDate.EditValue,
                Notes = memoNotes.Text
            };

            if (_editingTask == null)
            {
                // Create
                _taskService.CreateTask(dto);
                SuccessHandler.Show("Tarea creada con éxito.");
            }
            else
            {
                // Edit
                dto.Id = _editingTask.Id;
                _taskService.UpdateTask(dto);
                SuccessHandler.Show("Tarea actualizada con éxito.");
            }

            Close();
        }
    }
}
