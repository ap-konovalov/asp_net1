using System;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class ActionTestController : Controller
    {
        // GET
        public IActionResult Index()
        {
//            return new ContentResult(){ Content = "Hello ! I am a message from action test controller" , StatusCode = 200};
//            return EmptyResult();
//            return new FileStreamResult();
//            return new StatusCodeResult(404);
//            return new UnauthorizedResult();
//            return new JsonResult(new {Message = "Hello", ServerTime = DateTime.Now});
//            return new RedirectResult("www.ya.ru") {Permanent = true};
            return new ViewResult() {StatusCode = 202};
        }
    }
}