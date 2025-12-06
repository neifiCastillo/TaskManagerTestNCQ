using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Filters;
using TaskManager.Domain.Entities;

namespace TaskManager.Domain.Interfaces
{
    public interface ITaskRepository
    {
        TaskItem? GetById(int id);
        IEnumerable<TaskItem> GetAll(TaskFilter filter);
        void Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(int id);
    }
}
