using System.Data;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly IDbConnection Connection;
    
        protected BaseRepository(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}
