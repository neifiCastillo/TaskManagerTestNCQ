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
        private readonly TaskDto _editingTask;

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
            gridLookUpPriority.Properties.DataSource = Enum.GetValues(typeof(TaskPriority));
            gridLookUpPriority.EditValue = TaskPriority.Medium;

            // status — only pending
            gridLookUpStatus.Properties.DataSource = new[] { TaskStatus.Pending };
            gridLookUpStatus.EditValue = TaskStatus.Pending;
            gridLookUpStatus.Enabled = false;

            // User
            var users = _taskService.GetUsers().ToList();
            gridLookUpUsers.Properties.DataSource = users;
            gridLookUpUsers.Properties.DisplayMember = "FullName";
            gridLookUpUsers.Properties.ValueMember = "Id";

            var view = gridLookUpUsers.Properties.PopupView as GridView;
            view.Columns.Clear();
            view.Columns.AddVisible("FullName", "Usuario");
            view.OptionsView.ShowIndicator = false;
            view.OptionsView.ShowColumnHeaders = false;

            dateDueDate.Properties.MinValue = DateTime.Today;

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
