using Microsoft.AspNetCore.Mvc;

namespace UserManagerApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
