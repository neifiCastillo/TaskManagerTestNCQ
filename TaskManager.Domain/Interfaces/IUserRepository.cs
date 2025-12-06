using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;

namespace TaskManager.Domain.Interfaces
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
        User? GetById(int id);
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
