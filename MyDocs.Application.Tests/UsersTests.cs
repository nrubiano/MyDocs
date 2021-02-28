using System.Threading;
using Moq;
using MyDocs.Application.Common.Persistence;
using MyDocs.Application.Users.Queries.GetUser;
using MyDocs.Domain.Entities;
using Xunit;

namespace MyDocs.Application.Tests
{
    public class UsersTests
    {
        private readonly IUserRepository _userRepository;

        public UsersTests()
        {
            _userRepository = Mock.Of<IUserRepository>();
        }

        [Fact]
        public async void Should_Get_User_By_Username()
        {
            var testUser = new User
            {
                Id = 1,
                Name = "John",
                LastName = "Doe",
                Email = "jdoe@test.com",
                UserName = "jdoe",
                Password = "Pass8911*",
                RoleId = 1
            };
            
            Mock.Get(_userRepository)
                .Setup(x => x.FindByUsernameAsync(It.IsAny<string>()))
                .ReturnsAsync(testUser);

            var getUserQueryHandler = new GetUserQueryHandler(_userRepository);

            var user = await getUserQueryHandler.Handle(new GetUserQuery { UserName = "jdoe" }, CancellationToken.None);

            Assert.Equal(testUser.Id, user.Id);
            Assert.Equal(testUser.Name, user.Name);
            Assert.Equal(testUser.LastName, user.LastName);
            Assert.Equal(testUser.UserName, user.UserName);
            Assert.Equal(testUser.Password, user.Password);
            Assert.Equal(testUser.RoleId, user.RoleId);
        }

        [Fact]
        public async void Should_Get_Null_User_By_Username()
        {
            User testUser = null;

            Mock.Get(_userRepository)
                .Setup(x => x.FindByUsernameAsync(It.IsAny<string>()))
                .ReturnsAsync(testUser);

            var getUserQueryHandler = new GetUserQueryHandler(_userRepository);

            var user = await getUserQueryHandler.Handle(new GetUserQuery { UserName = "jdoe1" }, CancellationToken.None);

            Assert.Null(user);
        }
    }
}
