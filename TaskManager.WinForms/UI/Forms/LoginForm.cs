using DevExpress.XtraEditors;
using TaskManager.Application.Helpers;
using TaskManager.Application.Services;
using TaskManager.WinForms.UI.Animations;
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

            _authService = authService;
            _taskService = taskService;

            AlertService.Initialize(alertControl1);
            FormFadeIn.FadeIn(this);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _authService.Login(txtUsername.Text, txtPassword.Text);
                SessionManager.SaveSession(user.Id, user.FullName);
                var main = new MainForm(_taskService, user);
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_authService);
            registerForm.ShowDialog();
        }

    }
}
