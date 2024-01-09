using UserManagerApp.Data.Data;
using UserManagerApp.Data.Repository.IRepository;
using UserManagerApp.Models.Entities;

namespace UserManagerApp.Data.Repository.Repository
{
    public class ApplicationUserRepo : GenericsRepo<ApplicationUser>, IApplicationUserRepo
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUserRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(ApplicationUser applicationUser)
        {
            _context.Update(applicationUser);
        }
    }
}
