using System.Data;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection => Transaction.Connection;

        protected BaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
