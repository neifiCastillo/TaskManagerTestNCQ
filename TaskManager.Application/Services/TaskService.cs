using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.DTOs;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Exceptions;
using TaskManager.Domain.Filters;
using TaskManager.Domain.Interfaces;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepo;
        private readonly IUserRepository _userRepo;

        public TaskService(ITaskRepository taskRepo, IUserRepository userRepo)
        {
            _taskRepo = taskRepo;
            _userRepo = userRepo;
        }

        public IEnumerable<TaskItem> GetTasks(TaskFilter filter)
        {
            return _taskRepo.GetAll(filter);
        }

        public void CreateTask(TaskDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Description))
                throw new DomainException("La descripción es obligatoria.");

            var user = _userRepo.GetById(dto.AssignedUserId);
            if (user == null)
                throw new DomainException("El usuario asignado no existe.");

            var task = new TaskItem
            {
                Description = dto.Description,
                AssignedUserId = dto.AssignedUserId,
                Priority = dto.Priority,
                DueDate = dto.DueDate,
                Notes = dto.Notes,
                Status = TaskStatus.Pending
            };

            _taskRepo.Add(task);
        }

        public void UpdateTask(TaskDto dto)
        {
            var original = _taskRepo.GetById(dto.Id);

            if (original == null)
                throw new DomainException("La tarea no existe.");

            if (original.Status != TaskStatus.Pending)
                throw new DomainException("Solo se pueden editar tareas en estado PENDIENTE.");

            original.Description = dto.Description;
            original.AssignedUserId = dto.AssignedUserId;
            original.Priority = dto.Priority;
            original.DueDate = dto.DueDate;
            original.Notes = dto.Notes;
            original.UpdatedAt = DateTime.UtcNow;

            _taskRepo.Update(original);
        }

        public void ChangeStatus(int taskId, TaskStatus newStatus)
        {
            var task = _taskRepo.GetById(taskId);

            if (task == null)
                throw new DomainException("Tarea no encontrada.");

            if (task.Status == TaskStatus.Pending && newStatus == TaskStatus.InProgress) { }
            else if (task.Status == TaskStatus.InProgress && newStatus == TaskStatus.Done) { }
            else
                throw new DomainException("Cambio de estado inválido.");

            task.Status = newStatus;
            task.UpdatedAt = DateTime.UtcNow;

            _taskRepo.Update(task);
        }

        public IEnumerable<UserDto> GetUsers()
        {
            var users = _userRepo.GetAll()
                                 .Where(u => u.IsActive)
                                 .OrderBy(u => u.FullName);

            return users.Select(u => new UserDto
            {
                Id = u.Id,
                Username = u.Username,
                FullName = u.FullName
            });
        }

        public void DeleteTask(int id)
        {
            var task = _taskRepo.GetById(id);
            if (task == null)
                throw new DomainException("Tarea no encontrada.");

            if (task.Status == TaskStatus.InProgress)
                throw new DomainException("No se pueden eliminar tareas en proceso.");

            _taskRepo.Delete(id);
        }
    }
}
