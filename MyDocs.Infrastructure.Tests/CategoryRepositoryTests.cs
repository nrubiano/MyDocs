using System.Data;
using Dapper;
using Moq;
using Moq.Dapper;
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
            var mockConnection = new Mock<IDbConnection>();
            
            var mockTransaction = new Mock<IDbTransaction>();
            mockTransaction
                .Setup(x => x.Connection)
                .Returns(mockConnection.Object);

            mockConnection
                .SetupDapperAsync(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), null, mockTransaction.Object, null, null))
                .ReturnsAsync(1);

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
