using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> UserManager, SignInManager<User> SignInManager)
        {
            _userManager = UserManager;
            _signInManager = SignInManager;
        }
        public IActionResult Register() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var new_user = new User
            {
                UserName = model.UserName
            };
            var creation_result = await _userManager.CreateAsync(new_user, model.Password);

            if (creation_result.Succeeded)
            {
                await _signInManager.SignInAsync(new_user, false);
                
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in creation_result.Errors)
            {
                ModelState.AddModelError("",error.Description);
            }

            return View(model);
        }

        // GET
        public IActionResult Login()
        {
            return
            View();
        }
        
[HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            //TODO 1: Write here 1:29˚
        }

        public IActionResult Logout() => RedirectToAction("Index", "Home");

        public IActionResult AccessDenied() => View();
    }
}