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
                ModelState.AddModelError("", error.Description);
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
            if (!ModelState.IsValid) return View(login);

            var login_result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false);

            if (login_result.Succeeded)
            {
                if (Url.IsLocalUrl(login.ReturnUrl))
                    return Redirect(login.ReturnUrl);
                return RedirectToAction("Index", "Home");
            }
            
            ModelState.AddModelError("","User name or password wrong");
            return View(login);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return  RedirectToAction("Index", "Home");
        }
    
        public IActionResult AccessDenied() => View();
    }
}