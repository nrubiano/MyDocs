using System.Data;
using Moq;
using MyDocs.Domain.Entities;
using MyDocs.Infrastructure.Persistence.Repositories;
using Xunit;

namespace MyDocs.Infrastructure.Tests
{
    public class CategoryRepositoryTests
    {
        [Fact]
        public async void ShouldInsertARecord()
        {
            var mockTransaction = new Mock<IDbTransaction>();

            var repository = new CategoryRepository(mockTransaction.Object);

            await repository.AddAsync(new Category
            {
                Id = 1,
                Name = "Category"
            });

            mockTransaction.Object.Commit();
        }
    }
}
