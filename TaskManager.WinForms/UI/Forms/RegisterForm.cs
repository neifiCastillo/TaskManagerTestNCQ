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
using TaskManager.Application.DTOs;
using TaskManager.Application.Services;
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

        private void lblInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
