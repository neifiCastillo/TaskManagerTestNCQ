using DevExpress.XtraEditors;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;

namespace TaskManager.WinForms.UI
{
    public partial class RegisterForm : XtraForm
    {
        private readonly AuthService _authService;
        public RegisterForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
            FormFadeIn.FadeIn(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new RegisterUserDto
                {
                    Username = txtUsername.Text,
                    FullName = txtFullName.Text,
                    Password = txtPassword.Text,
                    ConfirmPassword = txtConfirmPassword.Text
                };

                _authService.Register(dto);
                this.Close();
                SuccessHandler.Show("Usuario registrado correctamente.");
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }

        }

        private void lblInit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
