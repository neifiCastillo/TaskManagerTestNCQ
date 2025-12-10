using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace TaskManager.WinForms.UI.Helpers
{
    public static class PasswordInputHelper
    {
        // Lock spaces while typing
        public static void BlockSpaces_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        // Remove spaces when pasting text or modifying content
        public static void RemoveSpacesOnPaste(object? sender, EventArgs e)
        {
            if (sender is TextEdit txt)
            {
                if (txt.Text.Contains(" "))
                {
                    int pos = txt.SelectionStart - 1;
                    txt.Text = txt.Text.Replace(" ", "");
                    txt.SelectionStart = Math.Max(pos, 0);
                }
            }
        }

        // Method to register both validations 
        public static void Attach(TextEdit txt)
        {
            txt.KeyPress += BlockSpaces_KeyPress;
            txt.TextChanged += RemoveSpacesOnPaste;
        }
    }
}
