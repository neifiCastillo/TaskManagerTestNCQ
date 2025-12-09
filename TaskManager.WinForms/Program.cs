using DevExpress.XtraReports.Design;
using System.IO;
using TaskManager.Application.Factories;
using TaskManager.Application.Helpers;
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
           
            ApplicationConfiguration.Initialize();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = ServiceFactory.Create();
            var session = SessionManager.LoadSession();

            if (session != null)
            {
                var diff = DateTime.Now - session.LoginTime;

                if (diff.TotalHours <= SessionManager.SessionDurationSeconds)
                {
                   
                    var user = services.Users.GetById(session.UserId);
                    System.Windows.Forms.Application.Run(new MainForm(services.Tasks, user));
                    return;
                }
                else
                {
                    SessionManager.ClearSession();
                }
            }

            System.Windows.Forms.Application.Run(new LoginForm(services.Auth, services.Tasks)); ;
        }
    }
}