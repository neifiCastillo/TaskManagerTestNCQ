using System.IO;
using TaskManager.Infrastructure.Database;
using TaskManager.Infrastructure.Factories;
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

            string connectionString = $"Data Source={dbFile};Version=3;";
            var dbFactory = new SqliteConnectionFactory(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(new LoginForm());
        }
    }
}