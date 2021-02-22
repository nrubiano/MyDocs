using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDocs.Application.Health.Commands;

namespace MyDocs.Hosts.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : BaseController
    {
        
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<Unit>> Get()
        {
            return await Mediator.Send(new HealthCheckCommand());
        }
    }
}