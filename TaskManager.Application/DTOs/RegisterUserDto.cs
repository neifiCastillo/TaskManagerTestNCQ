
namespace TaskManager.Application.DTOs
{
    public class RegisterUserDto
    {
        public string Username { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Password { get; set; } = "";
        public string ConfirmPassword { get; set; } = "";
    }
}
