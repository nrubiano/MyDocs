using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Groups.Commands.AddUserToGroup
{
    public class DeleteUserToGroupCommand : IRequest<int>
    {

    }

    public class DeleteUserToGroupCommandHandler : IRequestHandler<DeleteUserToGroupCommand, int>
    {
        public Task<int> Handle(DeleteUserToGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
