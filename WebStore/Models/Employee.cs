using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        
        [Display(Name = "Имя"), Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "минимальная длинна 3 буквы"), DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия"), Required(ErrorMessage = "Поле Фамилия обязательно для заполнения")]
        [MinLength(2, ErrorMessage = "минимальная длинна 2 буквы")]
        public string SurName { get; set; }

        [Display(Name = "Отчество")]
        [RegularExpression(@"(^[A-Z][a-z]{2,50}$)|(^[А-ЯЁ][а-яё]{2,50}$)", ErrorMessage = "Некорректный формат Отчества")]
        public string Patronymic { get; set; }

        [Display(Name = "Возраст")]
        [Range(18,130, ErrorMessage = "Возраст не подходит. Задайте значение от 18 до 130")]
        public int Age { get; set; }
        
    }
}