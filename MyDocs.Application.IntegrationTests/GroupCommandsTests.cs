using FluentAssertions;
using FluentValidation;
using MyDocs.Application.Groups.Commands.CreateGroup;
using Xunit;

namespace MyDocs.Application.IntegrationTests
{
    public class GroupCommandsTests : BaseTest
    {
        public GroupCommandsTests()
        {
            Setup();
        }

        [Fact]
        public void Should_Require_Group_Name()
        {
            var command = new CreateGroupCommand();

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<ValidationException>();
        }
    }
}
