using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Application.Common.Persistence
{
    public interface IUserRepository : IBaseRepository<User, int>
    {
        Task<User> FindByUsernameAsync(string userName);
    }
}
