using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using MyDocs.Application.Common.Persistence;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class GroupRepository : BaseRepository, IGroupRepository
    {
        public GroupRepository(IDbConnection connection) : base(connection)
        {
        }

        public async Task<int> AddAsync(Group entity)
        {
            var values = new DynamicParameters();

            values.Add("name", entity.Name);

            return await Connection.QueryFirstOrDefaultAsync<int>("public.groups_insert", values, commandType: CommandType.StoredProcedure);
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
