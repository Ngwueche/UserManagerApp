using Microsoft.AspNetCore.Mvc;

namespace UserManagerApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
