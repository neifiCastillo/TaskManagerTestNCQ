using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Application.Services;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Enums;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.WinForms.UI.Forms
{
    public partial class TaskDetailsForm : XtraForm
    {
        private readonly TaskItem _task;
        private readonly TaskService _taskService;
        public TaskDetailsForm(TaskItem task, TaskService taskService)
        {
            InitializeComponent();
            _task = task;
            _taskService = taskService;
            ConfigureNotes();
            LoadDetails();
        }
        private void LoadDetails()
        {
            lblId.Text = _task.Id.ToString();
            txtDescription.Text = _task.Description ?? "Sin Descripcion"; ;
            lblStatus.Text = TranslateStatus(_task.Status);
            lblPriority.Text = TranslatePriority(_task.Priority);
            lblDate.Text = _task.DueDate.ToString("dd/MM/yyyy");
            lblCreat.Text = _task.CreatedAt.ToString("dd/MM/yyyy hh:mm tt");
            lblAct.Text = _task.UpdatedAt.ToString("dd/MM/yyyy hh:mm tt");

            var user = _taskService.GetUsers().FirstOrDefault(x => x.Id == _task.AssignedUserId);
            lblAsigUser.Text = user?.Username ?? "Sin asignar";

            txtNotes.Text = _task.Notes ?? "Sin notas";
        }
        private string TranslateStatus(TaskStatus status)
        {
            return status switch
            {
                TaskStatus.Pending => "Pendiente",
                TaskStatus.InProgress => "En proceso",
                TaskStatus.Done => "Completada",
                _ => status.ToString()
            };
        }
        private string TranslatePriority(TaskPriority p)
        {
            return p switch
            {
                TaskPriority.High => "Alta",
                TaskPriority.Medium => "Media",
                TaskPriority.Low => "Baja",
                _ => p.ToString()
            };
        }
        private void ConfigureNotes()
        {
            txtNotes.Properties.ReadOnly = true;
            txtNotes.Properties.AllowFocused = false;
            txtNotes.Properties.AppearanceReadOnly.BackColor = Color.White;
            txtNotes.Properties.AppearanceReadOnly.ForeColor = Color.Black;

            txtDescription.Properties.ReadOnly = true;
            txtDescription.Properties.AllowFocused = false;
            txtDescription.Properties.AppearanceReadOnly.BackColor = Color.White;
            txtDescription.Properties.AppearanceReadOnly.ForeColor = Color.Black;
        }

    }
}
