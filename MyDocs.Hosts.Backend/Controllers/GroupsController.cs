using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MyDocs.Application.Groups.Commands.CreateGroup;

namespace MyDocs.Hosts.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : BaseController
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateGroupCommand command)
        {
            await Mediator.Send(command);

            return Ok();
        }

        [HttpPut]
        public Task<IActionResult> Put()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> Delete()
        {
            throw new NotImplementedException();
        }

        [HttpPost("{groupId}/users")]
        public Task<IActionResult> GetUsers(int groupId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{groupId}/users/{userId}")]
        public Task<IActionResult> PostUser(int groupId, int userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{groupId}/users/{userId}")]
        public Task<IActionResult> DeleteUser(int groupId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
