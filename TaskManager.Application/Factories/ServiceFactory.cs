using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Services;
using TaskManager.Infrastructure.Factories;
using TaskManager.Infrastructure.Repositories;

namespace TaskManager.Application.Factories
{
    public static class ServiceFactory
    {
        public static (AuthService Auth, TaskService Tasks, UserService Users) Create()
        {
            var dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taskmanager.db");
            var connectionString = $"Data Source={dbFile};";

            
            var dbFactory = new SqliteConnectionFactory(connectionString);

           
            var userRepo = new DapperUserRepository(dbFactory);
            var taskRepo = new DapperTaskRepository(dbFactory);

            
            var authService = new AuthService(userRepo);
            var taskService = new TaskService(taskRepo, userRepo);
            var userService = new UserService(userRepo);

            return (authService, taskService, userService);
        }
    }
}

