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

            this.AcceptButton = btnLogin;
            txtUsername.KeyDown += LoginKeyDown;
            txtPassword.KeyDown += LoginKeyDown;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_authService);
            registerForm.ShowDialog();
        }
        private void Login()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                XtraMessageBox.Show(
                    "Debe ingresar su usuario y contraseña.",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

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
        private void LoginKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
