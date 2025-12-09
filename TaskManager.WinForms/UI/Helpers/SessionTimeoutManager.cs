using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Factories;
using TaskManager.Application.Helpers;

namespace TaskManager.WinForms.UI.Helpers
{
    public class SessionTimeoutManager
    {
        private readonly Form _currentForm;
        private readonly InactivityMonitor _monitor;

        public SessionTimeoutManager(Form form)
        {
            _currentForm = form;

            _monitor = new InactivityMonitor(
                form,
                SessionManager.InactivityTimeoutSeconds,
                OnSessionTimeout
            );
        }

        public void Start() => _monitor.Start();

        public void Stop() => _monitor.Stop();

        private void OnSessionTimeout()
        {
            XtraMessageBox.Show(
                "La sesión ha expirado por inactividad.",
                "Sesión expirada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            SessionManager.ClearSession();

            var services = ServiceFactory.Create();

            var login = new LoginForm(services.Auth, services.Tasks);
            login.Show();

            _currentForm.Close();
        }
    }
}
