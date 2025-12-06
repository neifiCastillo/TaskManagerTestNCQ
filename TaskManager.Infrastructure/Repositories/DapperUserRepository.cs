using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Infrastructure.Factories;
using Dapper;
using Microsoft.Data.Sqlite;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Entities;



namespace TaskManager.Infrastructure.Repositories
{
    public class DapperUserRepository : IUserRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public DapperUserRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public User? GetByUsername(string username)
        {
            using var connection = _connectionFactory.CreateConnection();
            var sql = "SELECT * FROM Users WHERE Username = @Username LIMIT 1;";
            return connection.QueryFirstOrDefault<User>(sql, new { Username = username });
        }

        public User? GetById(int id)
        {
            using var connection = _connectionFactory.CreateConnection();
            var sql = "SELECT * FROM Users WHERE Id = @Id LIMIT 1;";
            return connection.QueryFirstOrDefault<User>(sql, new { Id = id });
        }

        public IEnumerable<User> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();
            var sql = "SELECT * FROM Users;";
            return connection.Query<User>(sql);
        }

        public void Add(User user)
        {
            using var connection = _connectionFactory.CreateConnection();

            var sql = @"
                INSERT INTO Users 
                    (Username, FullName, PasswordHash, PasswordSalt, IsActive, CreatedAt)
                VALUES 
                    (@Username, @FullName, @PasswordHash, @PasswordSalt, @IsActive, @CreatedAt);
            ";

            connection.Execute(sql, user);
        }
    }
}
