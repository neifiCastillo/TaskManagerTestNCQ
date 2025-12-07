using System.IO;
using TaskManager.Application.Services;
using TaskManager.Domain.Interfaces;
using TaskManager.Infrastructure.Database;
using TaskManager.Infrastructure.Factories;
using TaskManager.Infrastructure.Repositories;
using TaskManager.WinForms.UI;

namespace TaskManager.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taskmanager.db");
            string initScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQL", "init.sql");

            // Create database and tables if not exist
            DbInitializer.Initialize(dbFile, initScript);

            var connectionString = $"Data Source={dbFile};";
            var dbFactory = new SqliteConnectionFactory(connectionString);

            IUserRepository userRepo = new DapperUserRepository(dbFactory);
            ITaskRepository taskRepo = new DapperTaskRepository(dbFactory);

            var authService = new AuthService(userRepo);
            var taskService = new TaskService(taskRepo, userRepo);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(new LoginForm(authService, taskService));
        }
    }
}