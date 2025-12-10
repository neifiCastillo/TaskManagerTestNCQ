using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

            btnSave.Enabled = false;

            //Events for real - time validation

            txtUsername.TextChanged += (_, __) => ValidateForm();
            txtFullName.TextChanged += (_, __) => ValidateForm();
            txtPassword.TextChanged += (_, __) => ValidateForm();
            txtConfirmPassword.TextChanged += (_, __) => ValidateForm();
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
        private void ValidateForm()
        {
            bool isValid = true;

            // Username
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                txtUsername.Text.Length > 10)
                isValid = false;

            // FullName
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                txtFullName.Text.Length > 50)
                isValid = false;

            // Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                txtPassword.Text.Length > 10 ||
                !Regex.IsMatch(txtPassword.Text, @"[A-Z]"))
                isValid = false;

            // Confirm password
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                txtPassword.Text != txtConfirmPassword.Text)
                isValid = false;

            btnSave.Enabled = isValid;
        }
    }
}
