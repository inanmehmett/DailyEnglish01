using DailyEnglish.Models;
using DailyEnglish.Services;
using Microsoft.AspNetCore.Mvc;

namespace DailyEnglish.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityServices securityServices = new SecurityServices();
            if(securityServices.IsValid(userModel))
            {
            return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
