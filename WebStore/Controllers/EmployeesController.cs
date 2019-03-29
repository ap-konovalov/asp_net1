using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
 using WebStore.Models;
 
 namespace WebStore.Controllers
 {
     public class EmployeesController : Controller
     {
         // GET
         private static List<Employee> _Employees = new List<Employee>
         {
             new Employee{ Id = 0, SurName = "Ivanov", FirstName = "Inav", Patronymic = "Ivanovoch", Age = 21},
             new Employee{ Id = 1, SurName = "Sidorov", FirstName = "Sidor", Patronymic = "Sidorovich", Age =32},
             new Employee{ Id = 2, SurName = "Petrov", FirstName = "Petr", Patronymic = "Petrovich", Age = 32}
         };
         public IActionResult Index()
         {
             return
             View(_Employees);
         }

         public IActionResult Details(int id)
         {
             var employee = _Employees.FirstOrDefault(e => e.Id == id);
             if (employee == null)
                 return NotFound();
             
             return View(employee);
         }
     }
 }