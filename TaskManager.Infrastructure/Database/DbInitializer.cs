using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;

namespace TaskManager.Infrastructure.Database
{
    public static class DbInitializer
    {

        public static void Initialize(string dbPath, string initScriptPath)
        {
            // If db does not exist → create it
            if (!File.Exists(dbPath))
                File.Create(dbPath).Dispose();

            var connectionString = $"Data Source={dbPath};";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var script = File.ReadAllText(initScriptPath);
                connection.Execute(script);
            }
        }
    }
}
