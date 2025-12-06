using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Enums;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;


namespace TaskManager.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public int AssignedUserId { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime DueDate { get; set; }
        public string Notes { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
