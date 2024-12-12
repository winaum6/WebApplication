using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace WebApplication4.Models.Account
{
    public class AccountViewModel
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
        
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Это поле обязательное")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Это поле обязательное")]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Это поле обязательное")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Это поле обязательное")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Это поле обязательное")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]

        public string RepeatPassword { get; set; }
    }
}
