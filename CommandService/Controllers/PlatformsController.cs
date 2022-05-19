using CommandService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnections(Platform platform)
        {
            Console.WriteLine($"--> Inbound POST Command");
            return Ok($"Inbound Test dari Command Service - {platform.Id} - {platform.Name}");
        }
    }
}