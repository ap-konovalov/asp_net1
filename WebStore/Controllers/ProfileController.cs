using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces.WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IOrderService _orderService;
        public ProfileController(IOrderService orderService )
        {
            _orderService = orderService;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            return
            View();
        }

        public IActionResult Orders()
        {
            var orders =_orderService.GetUserOrders()
            
            return View();
        }
    }
}