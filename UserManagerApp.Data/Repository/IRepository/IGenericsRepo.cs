using System.Linq.Expressions;

namespace UserManagerApp.Data.Repository.IRepository
{
    public interface IGenericsRepo<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        T Get(Expression<Func<T, bool>> filter, string? includeProperties, bool tracked = false);

        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
