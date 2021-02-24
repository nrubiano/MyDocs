using MyDocs.Application.Health.Commands;
using Xunit;

namespace MyDocs.Application.Tests
{
    public class HealthCheckTests
    {
        [Fact]
        public async void ShouldReturnValidResult()
        {
            var command = new HealthCheckCommand();
        }
    }
}
