using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Filters;
using TaskManager.Domain.Interfaces;
using TaskManager.Infrastructure.Factories;

namespace TaskManager.Infrastructure.Repositories
{
    public class DapperTaskRepository : ITaskRepository
    {
        private readonly IDbConnectionFactory _factory;

        public DapperTaskRepository(IDbConnectionFactory factory)
        {
            _factory = factory;
        }
        public TaskItem? GetById(int id)
        {
            using var connection = _factory.CreateConnection();
            string sql = "SELECT * FROM Tasks WHERE Id = @Id LIMIT 1;";
            return connection.QueryFirstOrDefault<TaskItem>(sql, new { Id = id });
        }
        public IEnumerable<TaskItem> GetAll(TaskFilter filter)
        {
            using var connection = _factory.CreateConnection();

            var sql = @"SELECT * FROM Tasks WHERE 1=1 ";
            var parameters = new DynamicParameters();

            if (filter.Status.HasValue)
            {
                sql += " AND Status = @Status";
                parameters.Add("@Status", (int)filter.Status.Value);
            }

            if (filter.Priority.HasValue)
            {
                sql += " AND Priority = @Priority";
                parameters.Add("@Priority", (int)filter.Priority.Value);
            }

            if (filter.AssignedUserId.HasValue)
            {
                sql += " AND AssignedUserId = @AssignedUserId";
                parameters.Add("@AssignedUserId", filter.AssignedUserId.Value);
            }

            if (filter.FromDate.HasValue)
            {
                sql += " AND DueDate >= @FromDate";
                parameters.Add("@FromDate", filter.FromDate.Value);
            }

            if (filter.ToDate.HasValue)
            {
                sql += " AND DueDate <= @ToDate";
                parameters.Add("@ToDate", filter.ToDate.Value);
            }

            if (!string.IsNullOrWhiteSpace(filter.Search))
            {
                sql += " AND (Description LIKE @Search OR Notes LIKE @Search)";
                parameters.Add("@Search", $"%{filter.Search}%");
            }

            sql += " ORDER BY DueDate ASC;";

            return connection.Query<TaskItem>(sql, parameters);
        }
        public void Add(TaskItem task)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                INSERT INTO Tasks
                (Description, AssignedUserId, Status, Priority, DueDate, Notes, CreatedAt, UpdatedAt)
                VALUES
                (@Description, @AssignedUserId, @Status, @Priority, @DueDate, @Notes, @CreatedAt, @UpdatedAt);";

            connection.Execute(sql, task);
        }
        public void Update(TaskItem task)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                UPDATE Tasks SET
                    Description = @Description,
                    AssignedUserId = @AssignedUserId,
                    Status = @Status,
                    Priority = @Priority,
                    DueDate = @DueDate,
                    Notes = @Notes,
                    UpdatedAt = @UpdatedAt
                WHERE Id = @Id;";

            connection.Execute(sql, task);
        }
        public void Delete(int id)
        {
            using var connection = _factory.CreateConnection();
            string sql = "DELETE FROM Tasks WHERE Id = @Id;";
            connection.Execute(sql, new { Id = id });
        }
    }
}
