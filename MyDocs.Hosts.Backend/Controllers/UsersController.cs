using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyDocs.Hosts.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
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
    }
}