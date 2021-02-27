using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyDocs.Application.Common.Persistence
{
    public interface IBaseRepository<T, TKey>
    {
        Task<TKey> AddAsync(T entity);
        IEnumerable<T> AllAsync();
        T FindAsync(TKey id);
        IEnumerable<T> FindByIdAsync(TKey id);
        Task RemoveAsync(TKey id);
        Task UpdateAsync(T entity);
    }
}
