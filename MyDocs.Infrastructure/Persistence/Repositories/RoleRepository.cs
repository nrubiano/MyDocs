using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public Task AddAsync(Rol entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rol> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Rol FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rol> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Rol entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}
