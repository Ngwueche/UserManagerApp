using Microsoft.AspNetCore.Mvc;

namespace UserManagerApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageUser()
        {

            return View();
        }
        public IActionResult ManageRole()
        {

            return View();
        }
    }
}
