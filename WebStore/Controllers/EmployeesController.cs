using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
 
 namespace WebStore.Controllers
 {
//     [Route("Users/[action]")]

     public class EmployeesController : Controller
     {

         private readonly IEmployeesData _EmployeesData;
         public EmployeesController(IEmployeesData EmployeesData)
         {
             _EmployeesData = EmployeesData;
         }

         public IActionResult Index()
         {
             return
             View(_EmployeesData.GetAll());
         }

//         [Route("Info/{id}")]
         public IActionResult Details(int id)
         {
             var employee = _EmployeesData.GetById(id);
             if (employee == null)
                 return NotFound();
             
             return View(employee);
         }
     }
 }