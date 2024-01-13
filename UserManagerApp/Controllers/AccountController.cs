using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserManagerApp.Data.Data;
using UserManagerApp.Data.Repository.IRepository;
using UserManagerApp.Models.Entities;
using UserManagerApp.Models.ViewModels;

namespace UserManagerApp.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public AccountController(IUnitOfWork unitOfWork, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {

            _context = context;
            _userManager = userManager;
        }
        public async IActionResult Register(UserToRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var getUser = await _context.AppUsers.FindAsync(model.Email);
                if (getUser != null)
                {
                    return Ok("Account already exist");
                }
                else
                {
                    var user = new ApplicationUser
                    {
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PhoneNumber = model.PhoneNumber,
                        UserName = model.UserName,
                    };
                    var createUser = await _userManager.CreateAsync(user, model.Password);

                }
            }
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
