using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Application.Services;
using TaskManager.WinForms.UI.Controls;

namespace TaskManager.WinForms.UI
{
    public partial class LoginForm : XtraForm
    {

        private readonly AuthService _authService;
        private readonly TaskService _taskService;
        public LoginForm(AuthService authService, TaskService taskService)
        {
            InitializeComponent();
            AlertService.Initialize(alertControl1);
            _authService = authService;
            _taskService = taskService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _authService.Login(txtUsername.Text, txtPassword.Text);


                var main = new MainForm(_taskService, user);
                main.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_authService);
            registerForm.ShowDialog();
        }
    }
}
