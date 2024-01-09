using UserManagerApp.Models.Entities;

namespace UserManagerApp.Data.Repository.IRepository
{
    public interface IApplicationUserRepo
    {
        void Update(ApplicationUser applicationUser);
    }
}
