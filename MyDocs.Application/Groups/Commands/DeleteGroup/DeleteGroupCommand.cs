using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Groups.Commands.DeleteGroup
{
    public class DeleteGroupCommand : IRequest<int>
    {

    }

    public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand, int>
    {
        public Task<int> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
