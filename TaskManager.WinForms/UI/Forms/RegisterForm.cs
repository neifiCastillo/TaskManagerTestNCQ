using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
using TaskManager.WinForms.UI.Animations;
using TaskManager.WinForms.UI.Controls;
using TaskManager.WinForms.UI.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TaskManager.WinForms.UI
{
    public partial class RegisterForm : XtraForm
    {
        private readonly AuthService _authService;
        private bool userTypedUsername = false;
        private bool userTypedFullName = false;
        private bool userTypedPassword = false;
        private bool userTypedConfirmPassword = false;

        public RegisterForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
            FormFadeIn.FadeIn(this);

            btnSave.Enabled = false;

            //Events for real - time validation
            DetectWriting();
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

        private void DetectWriting()
        {
            txtUsername.TextChanged += (_, __) => { userTypedUsername = true; ValidateForm(); };
            txtFullName.TextChanged += (_, __) => { userTypedFullName = true; ValidateForm(); };
            txtPassword.TextChanged += (_, __) => { userTypedPassword = true; ValidateForm(); };
            txtConfirmPassword.TextChanged += (_, __) => { userTypedConfirmPassword = true; ValidateForm(); };
            PasswordInputHelper.Attach(txtPassword);
            PasswordInputHelper.Attach(txtConfirmPassword);
        }
        private void ValidateForm()
        {
            bool isValid = true;
            errorProvider1.Clear();

            // Username
            if (userTypedUsername)
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Ingrese un nombre de usuario.");
                    isValid = false;
                }
                else if (txtUsername.Text.Length > 10)
                {
                    errorProvider1.SetError(txtUsername, "Máximo 10 caracteres.");
                    isValid = false;
                }
            }

            // Fullname
            if (userTypedFullName)
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    errorProvider1.SetError(txtFullName, "Ingrese el nombre completo.");
                    isValid = false;
                }
                else if (txtFullName.Text.Length > 50)
                {
                    errorProvider1.SetError(txtFullName, "Máximo 50 caracteres.");
                    isValid = false;
                }
            }

            // Password
            if (userTypedPassword)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Ingrese una contraseña.");
                    isValid = false;
                }
                else if (txtPassword.Text.Length > 10)
                {
                    errorProvider1.SetError(txtPassword, "Máximo 10 caracteres.");
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtPassword.Text, @"[A-Z]"))
                {
                    errorProvider1.SetError(txtPassword, "Debe contener al menos una mayúscula.");
                    isValid = false;
                }
            }

            // ConfirmPassword
            if (userTypedConfirmPassword)
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    errorProvider1.SetError(txtConfirmPassword, "Las contraseñas no coinciden.");
                    isValid = false;
                }
            }

            btnSave.Enabled = isValid &&
                              !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                              !string.IsNullOrWhiteSpace(txtFullName.Text) &&
                              !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                              !string.IsNullOrWhiteSpace(txtConfirmPassword.Text);
        }

    }
}
