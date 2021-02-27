using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyDocs.Application.Common.Persistence;
using MyDocs.Domain.Entities;

namespace MyDocs.Application.Groups.Commands.UpdateGroup
{
    public class UpdateGroupCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand>
    {
        private readonly IGroupRepository _groupRepository;

        public UpdateGroupCommandHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<Unit> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            await _groupRepository.UpdateAsync(new Group
            {
                Id = request.Id,
                Name = request.Name
            });

            return Unit.Value;;
        }
    }
}
