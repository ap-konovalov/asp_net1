using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployesController : Controller
    {
        // GET
        private static List<Employee> _Employes = new List<Employee>
        {
            new Employee{ Id = 0, SurName = "Ivanov", FirstName = "Inav", Patronymic = "Ivanovoch", Age = 21},
            new Employee{ Id = 1, SurName = "Sidorov", FirstName = "Sidor", Patronymic = "Sidorovich", Age =32},
            new Employee{ Id = 2, SurName = "Petrov", FirstName = "Petr", Patronymic = "Petrovich", Age = 32}
        };
        
        //TODO 1: Реализовать возможность просмотра карточки выбранного сотрудника. Дополнительная информация может быть любой: дата рождения, дата устройства на работу и т.д.
        //TODO 2: Предусмотреть возможность возврата обратно к списку.
        
        public IActionResult Index()
        {
            return
            View(_Employes);
        }
    }
}