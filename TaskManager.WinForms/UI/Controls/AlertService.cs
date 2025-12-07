using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.WinForms.UI.Controls
{
    public static class AlertService
    {
        private static AlertControl _alert;

        public static void Initialize(AlertControl alertControl)
        {
            _alert = alertControl;
            _alert.BeforeFormShow -= OnBeforeFormShow;
            _alert.BeforeFormShow += OnBeforeFormShow;
        }

        private static void OnBeforeFormShow(object sender, AlertFormEventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            int w = e.AlertForm.Width;
            int h = e.AlertForm.Height;

            int x = screen.Left + (screen.Width - w) / 2;
            int y = screen.Top + (screen.Height - h) / 2;

            e.Location = new Point(x, y);
        }

        public static void Success(string message)
        {
            if (_alert == null) return;

            AlertInfo info = new AlertInfo("Éxito", message);
            _alert.Show(null, info);
        }

        public static void Error(string message)
        {
            if (_alert == null) return;

            AlertInfo info = new AlertInfo("Error", message);
            _alert.Show(null, info);
        }
    }
}
