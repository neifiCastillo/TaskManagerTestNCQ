using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace TaskManager.WinForms.UI.Helpers
{
    public class InactivityMonitor
    {
        private readonly Form _form;
        private readonly Timer _timer;
        private DateTime _lastActivity;
        private readonly int _timeoutSeconds;
        private readonly Action _onTimeout;
        public InactivityMonitor(Form form, int timeoutSeconds, Action onTimeout)
        {
            _form = form;
            _timeoutSeconds = timeoutSeconds;
            _onTimeout = onTimeout;

            _lastActivity = DateTime.Now;

            _timer = new Timer();
            _timer.Interval = 1000; // 1 second
            _timer.Tick += Timer_Tick;

            RegisterActivityEvents();
        }
        private void RegisterActivityEvents()
        {
            // Activity Events for the form
            _form.MouseMove += ResetActivity;
            _form.MouseClick += ResetActivity;
            _form.KeyDown += ResetActivity;
            _form.MouseWheel += ResetActivity;
        }
        private void ResetActivity(object? sender, EventArgs e)
        {
            _lastActivity = DateTime.Now;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if ((DateTime.Now - _lastActivity).TotalSeconds >= _timeoutSeconds)
            {
                _timer.Stop();
                _onTimeout?.Invoke();
            }
        }
        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
    }
}
