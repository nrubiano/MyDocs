using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyDocs.Application.Common.Dtos;
using MyDocs.Application.Common.Persistence;

namespace MyDocs.Application.Users.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public string UserName { get; set; }
    }

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByUsernameAsync(request.UserName);

            if (user == null)
                return null;

            return new UserDto
            {
                Name = user.Name,
                Email = user.Email,
                Id = user.Id,
                LastName = user.LastName,
                Password = user.Password,
                RoleId = user.RoleId,
                UserName = user.UserName
            };
        }
    }
}
