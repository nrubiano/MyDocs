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
            
            mockConnection
                .SetupDapperAsync(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), null, null, null, null))
                .ReturnsAsync(1);

            var repository = new CategoryRepository(mockConnection.Object);

            await repository.AddAsync(new Category
            {
                Id = 1,
                Name = "Category"
            });
        }
    }
}
