using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyDocs.Application.Common.Dtos;

namespace MyDocs.Application.Groups.Queries.GetGroups
{
    public class GetGroupsQuery : IRequest<IEnumerable<GroupDto>>
    {
    }

    public class GetGroupsQueryHandler : IRequestHandler<GetGroupsQuery, IEnumerable<GroupDto>>
    {
        public Task<IEnumerable<GroupDto>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
