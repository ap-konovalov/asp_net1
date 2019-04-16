using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Имя"), MaxLength(256, ErrorMessage = "Max 256 symbols"), Required]
        public string UserName { get; set; }
        
        [Display(Name = "Пароль"), Required, DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}