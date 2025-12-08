using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.WinForms.UI.Animations
{
    public static class FormFadeIn
    {
        /// <summary>
        /// Apply a soft fade effect to any form.
        /// </summary>
        public static void FadeIn(Form form, double step = 0.05, int interval = 10)
        {
            form.Opacity = 0;

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;

            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += step;
                }
                else
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }
    }
}
