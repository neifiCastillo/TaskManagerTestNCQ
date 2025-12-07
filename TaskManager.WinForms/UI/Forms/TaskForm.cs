using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.Domain.Enums;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.WinForms.UI
{
    public partial class TaskForm : XtraForm
    {
        private readonly TaskService _taskService;
        private readonly UserDto _currentUser;
        private readonly TaskDto _editingTask;

        // Constructor Crear
        public TaskForm(TaskService taskService, UserDto user)
        {
            InitializeComponent();
            _taskService = taskService;
            _currentUser = user;

            LoadLookups();
        }

        // Constructor Editar
        public TaskForm(TaskService taskService, UserDto user, TaskDto task)
        {
            InitializeComponent();
            _taskService = taskService;
            _currentUser = user;
            _editingTask = task;

            LoadLookups();
            LoadTask();
        }


        private void LoadLookups()
        {
            // PRIORITY
            comboPriority.Properties.DataSource = Enum.GetValues(typeof(TaskPriority));
            comboPriority.EditValue = TaskPriority.Medium;

            // STATUS
            comboStatus.Properties.DataSource = Enum.GetValues(typeof(TaskStatus));
            comboStatus.EditValue = TaskStatus.Pending;

            // USER
            var users = _taskService.GetUsers().ToList();
            gridLookUpUsers.Properties.DataSource = users;
            gridLookUpUsers.Properties.DisplayMember = "FullName";
            gridLookUpUsers.Properties.ValueMember = "Id";

            var view = gridLookUpUsers.Properties.PopupView as GridView;
            view.Columns.Clear();
            view.Columns.AddVisible("FullName", "Usuario");
            view.OptionsView.ShowIndicator = false;
            view.OptionsView.ShowColumnHeaders = false;
        }

        // IF IT IS EDITING → fill in the fields
        private void LoadTask()
        {
            if (_editingTask == null)
                return;

            txtDescription.Text = _editingTask.Description;
            comboPriority.EditValue = _editingTask.Priority;
            comboStatus.EditValue = _editingTask.Status;
            gridLookUpUsers.EditValue = _editingTask.AssignedUserId;
            dateDueDate.EditValue = _editingTask.DueDate;
            memoNotes.Text = _editingTask.Notes;

            btnSave.Text = "Actualizar";
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
                XtraMessageBox.Show("Debe seleccionar una fecha límite.");
                return false;
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
                Priority = (TaskPriority)comboPriority.EditValue,
                Status = (TaskStatus)comboStatus.EditValue,
                AssignedUserId = (int)gridLookUpUsers.EditValue,
                DueDate = (DateTime)dateDueDate.EditValue,
                Notes = memoNotes.Text
            };

            if (_editingTask == null)
            {
                // CREATE
                _taskService.CreateTask(dto);
                XtraMessageBox.Show("Tarea creada con éxito.");
            }
            else
            {
                // EDIT
                dto.Id = _editingTask.Id;
                _taskService.UpdateTask(dto);
                XtraMessageBox.Show("Tarea actualizada con éxito.");
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
