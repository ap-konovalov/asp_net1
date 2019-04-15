using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register() => View();
        
        // GET
        public IActionResult Login()
        {
            return
            View();
        }

        public IActionResult Logout() => RedirectToAction("Index", "Home");

        public IActionResult AccessDenied() => View();
    }
}