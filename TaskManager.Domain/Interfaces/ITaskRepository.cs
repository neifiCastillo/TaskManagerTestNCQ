using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Filters;


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
