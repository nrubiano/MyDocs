using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MyDocs.Application.Groups.Commands.CreateGroup
{
    public class CreateGroupCommand : IRequest<int>
    {

    }

    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, int>
    {
        public Task<int> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
