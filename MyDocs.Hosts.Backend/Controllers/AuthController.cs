using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MyDocs.Hosts.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpGet("token")]
        public Task<IActionResult> Token(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
