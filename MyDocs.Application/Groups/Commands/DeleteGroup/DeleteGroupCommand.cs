using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyDocs.Application.Common.Persistence;

namespace MyDocs.Application.Groups.Commands.DeleteGroup
{
    public class DeleteGroupCommand : IRequest
    {
        public int GroupId { get; set; }
    }

    public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand>
    {
        private readonly IGroupRepository _groupRepository;

        public DeleteGroupCommandHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<Unit> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            await _groupRepository.RemoveAsync(request.GroupId);

            return Unit.Value;
        }
    }
}
