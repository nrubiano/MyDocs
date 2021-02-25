using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class GroupRepository : BaseRepository, IGroupRepository
    {
        public GroupRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public Task AddAsync(Group entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Group FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Group entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}
