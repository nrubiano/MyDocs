using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity);
        IEnumerable<T> AllAsync();
        T FindAsync(int id);
        IEnumerable<T> FindByIdAsync(int id);
        Task RemoveAsync(int id);
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
