using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.WinForms.UI.Controls
{
    public static class SuccessHandler
    {
   
            public static void Show(string message)
            {
                AlertService.Success(message);
            }
        
    }
}
