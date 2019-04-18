using Microsoft.AspNetCore.Mvc;

namespace WebStore.Components
{
    [ViewComponent(Name = "UserInfo")]
    public class UserInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (User.Identity.IsAuthenticated)
                return View("USerInfoView");
            
            return View();
        }
    }
}