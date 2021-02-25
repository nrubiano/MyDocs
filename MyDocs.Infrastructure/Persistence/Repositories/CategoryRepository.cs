﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyDocs.Domain.Entities;

namespace MyDocs.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public Task AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Category FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
