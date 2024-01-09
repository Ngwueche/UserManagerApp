namespace UserManagerApp.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUserRepo ApplicationUserRepo { get; }
        void Save();
    }
}
