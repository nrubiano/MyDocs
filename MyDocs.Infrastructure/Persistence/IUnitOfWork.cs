using System;
using MyDocs.Infrastructure.Persistence.Repositories;

namespace MyDocs.Infrastructure.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IDocumentRepository DocumentRepository { get; }
        IGroupRepository GroupRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }
        
        void Commit();
    }
}
