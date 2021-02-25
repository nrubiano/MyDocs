using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    internal class DocumentRepository : BaseRepository, IDocumentRepository
    {
        public DocumentRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public Task AddAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Document FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Document entity)
        {
            throw new NotImplementedException();
        }
    }
}
