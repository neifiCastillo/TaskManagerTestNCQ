using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.DTOs;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Interfaces;

namespace TaskManager.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public UserDto GetById(int id)
        {
            var u = _repo.GetById(id);
            if (u == null) return null;

            return new UserDto
            {
                Id = u.Id,
                Username = u.Username,
                FullName = u.FullName
            };
        }
    }
}
