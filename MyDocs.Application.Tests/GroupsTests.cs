using System.Threading;
using Moq;
using MyDocs.Application.Common.Persistence;
using MyDocs.Application.Groups.Commands.CreateGroup;
using MyDocs.Application.Groups.Commands.DeleteGroup;
using MyDocs.Application.Groups.Commands.UpdateGroup;
using MyDocs.Domain.Entities;
using Xunit;

namespace MyDocs.Application.Tests
{
    public class GroupsTests
    {
        private readonly IGroupRepository _groupRepositoryMock;

        public GroupsTests()
        {
            _groupRepositoryMock = Mock.Of<IGroupRepository>();
        }

        [Fact]
        public async void Should_Insert_Group()
        {
            var groupId = 1;
            var createGroupCommand = new CreateGroupCommand
            {
                Name = "My Group"
            };

            Mock.Get(_groupRepositoryMock)
                .Setup(x => x.AddAsync(It.IsAny<Group>()))
                .ReturnsAsync(groupId);
            
            var createGroupCommandHandler = new CreateGroupCommandHandler(_groupRepositoryMock);

            var commandResponse = await createGroupCommandHandler.Handle(createGroupCommand, CancellationToken.None);

            Assert.Equal(groupId, commandResponse);
        }

        [Fact]
        public async void Should_Update_Group()
        {
            var command = new UpdateGroupCommand
            {
                Id = 1,
                Name = "My Group"
            };

            Mock.Get(_groupRepositoryMock)
                .Setup(x => x.UpdateAsync(It.IsAny<Group>()));

            var updateGroupCommandHandler = new UpdateGroupCommandHandler(_groupRepositoryMock);

            await updateGroupCommandHandler.Handle(command, CancellationToken.None);
        }

        [Fact]
        public async void Should_Delete_Group()
        {
            var command = new DeleteGroupCommand
            {
                GroupId = 1
            };

            Mock.Get(_groupRepositoryMock)
                .Setup(x => x.RemoveAsync(It.IsAny<int>()));

            var deleteGroupCommandHandler = new DeleteGroupCommandHandler(_groupRepositoryMock);

            await deleteGroupCommandHandler.Handle(command, CancellationToken.None);
        }
    }
}
