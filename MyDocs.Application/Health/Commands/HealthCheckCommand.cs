using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Health.Commands
{
    public class HealthCheckCommand : IRequest
    {

    }

    public class CheckHealthCommandHandler : IRequestHandler<HealthCheckCommand>
    {
        public Task<Unit> Handle(HealthCheckCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Unit());
        }
    }
}
