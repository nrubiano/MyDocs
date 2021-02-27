using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDocs.Hosts.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Post()
        {
            throw new NotImplementedException();
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
