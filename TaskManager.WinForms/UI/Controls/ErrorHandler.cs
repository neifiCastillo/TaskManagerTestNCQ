using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Exceptions;

namespace TaskManager.WinForms.UI.Controls
{
    public static class ErrorHandler
    {
        public static void Handle(Exception ex)
        {
            if (ex is DomainException domainEx)
            {
                
                AlertService.Error(domainEx.Message);
            }
            else
            {
               
                AlertService.Error("Ocurrió un error inesperado.");
            }
        }
    }
}
