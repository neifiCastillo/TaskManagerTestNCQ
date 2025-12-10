using TaskManager.Domain.Enums;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.Application.DTOs
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public int AssignedUserId { get; set; }
        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; } = "";
    }
}
