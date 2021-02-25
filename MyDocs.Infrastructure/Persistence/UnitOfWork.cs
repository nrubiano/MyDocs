using System;
using System.Data;
using Microsoft.Data.SqlClient;
using MyDocs.Infrastructure.Persistence.Repositories;

namespace MyDocs.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private ICategoryRepository _categoryRepository;
        private IDocumentRepository _documentRepository;
        private IGroupRepository _groupRepository;
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private bool _disposed;

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        
        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_transaction);
        public IDocumentRepository DocumentRepository => _documentRepository ?? new DocumentRepository(_transaction);
        public IGroupRepository GroupRepository => _groupRepository ?? new GroupRepository(_transaction);
        public IRoleRepository RoleRepository => _roleRepository ?? new RoleRepository(_transaction);
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_transaction);
        
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();

                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            _categoryRepository = null;
            _documentRepository = null;
            _groupRepository = null;
            _roleRepository = null;
            _userRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
            }
            _disposed = true;
        }
    }
}
