using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> AllAsync()
        {
            throw new NotImplementedException();
        }

        public User FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
