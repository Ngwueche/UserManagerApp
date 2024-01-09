using UserManagerApp.Data.Data;
using UserManagerApp.Data.Repository.IRepository;

namespace UserManagerApp.Data.Repository.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IApplicationUserRepo ApplicationUserRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ApplicationUserRepo = new ApplicationUserRepo(context);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
