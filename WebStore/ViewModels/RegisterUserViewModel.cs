using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels
{
    public class RegisterUserViewModel
    {
        [Display(Name = "Имя"), MaxLength(256, ErrorMessage = "Max 256 symbols"), Required]
        public string UserName { get; set; }
        
        [Display(Name = "Пароль"), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Опять пароль"), Required, DataType(DataType.Password)]
        
        [Compare(nameof(Password), ErrorMessage = "passwords do not meet")]
        public string ConfirmPassword { get; set; }
    }
}