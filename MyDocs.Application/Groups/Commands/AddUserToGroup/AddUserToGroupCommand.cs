using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Groups.Commands.AddUserToGroup
{
    public class AddUserToGroupCommand : IRequest<int>
    {

    }

    public class AddUserToGroupCommandHandler : IRequestHandler<AddUserToGroupCommand, int>
    {
        public Task<int> Handle(AddUserToGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
