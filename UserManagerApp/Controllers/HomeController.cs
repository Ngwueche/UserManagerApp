using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserManagerApp.Models;
using UserManagerApp.Models.ViewModels;

namespace UserManagerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var dummyListOfUsers = new List<UserToReturnVM>
            {
                new UserToReturnVM {Id="1", FirstName="Wisdom", LastName="Ngwueche", Email="wisdomngwueche@gmail.com", ImageUrl="", UserName="wisdomngwueche", GitHub ="ngwueche", Twitter="wisdomngwueche"},
                new UserToReturnVM {Id="2", FirstName="Ada", LastName="Mgbede", Email="addamgbede@gmail.com", ImageUrl="", UserName="addamgbede", GitHub ="addamgbede", Twitter="addamgbede"},
                new UserToReturnVM {Id="3", FirstName="Nnenna", LastName="Humphery", Email="nnennahumphery@gmail.com", ImageUrl="", UserName="nnennahumphery", GitHub ="nnennahumphery", Twitter="nnennahumphery"},
                new UserToReturnVM {Id="4", FirstName="Covenant", LastName="Ebube", Email="covenantebube@gmail.com", ImageUrl="", UserName="covenantebube", GitHub ="covenantebube", Twitter="covenantebube"},
                new UserToReturnVM {Id="5", FirstName="Ebele", LastName="Okolo", Email="ebeleokolo@gmail.com", ImageUrl="", UserName="E_okolo", GitHub ="E_okolo", Twitter="ebeleokolo"},
                new UserToReturnVM {Id="6", FirstName="Utobi", LastName="Ozoeze", Email="uto@gmail.com", ImageUrl="", UserName="O_uto", GitHub ="O_uto", Twitter="ozoeze"},

            };
            return View(dummyListOfUsers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
