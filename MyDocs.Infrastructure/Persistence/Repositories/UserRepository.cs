using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Application.Common.Persistence;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IDbConnection connection) : base(connection)
        {
        }

        public Task<int> AddAsync(User entity)
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
