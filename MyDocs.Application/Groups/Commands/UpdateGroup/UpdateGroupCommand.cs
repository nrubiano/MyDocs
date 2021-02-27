using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Groups.Commands.UpdateGroup
{
    public class UpdateGroupCommand : IRequest<int>
    {

    }

    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, int>
    {
        public Task<int> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
