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
    public class DocumentsController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Download()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Upload()
        {
            throw new NotImplementedException();
        }
    }
}
