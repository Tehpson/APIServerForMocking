using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIServerForMocking.Controllers
{



    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        public readonly ILogger<StatusController> logger;

        public StatusController(ILogger<StatusController> logger)
        {
            this.logger = logger;
        }

        // GET: api/Status/200
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInformation("Hit Get Reuquest Status 200", DateTime.UtcNow.ToLongTimeString());
            return new string[] { "value1", "value2" };
        }

        [HttpGet("404")]
        public IActionResult NotFound() {
            logger.LogInformation("Hit Get Reuquest Status 404", DateTime.UtcNow.ToLongTimeString());
            return new NotFoundResult();
        }

        [HttpGet("401")]
        public IActionResult Unauthorized()
        {
            logger.LogInformation("Hit Get Reuquest Status 401", DateTime.UtcNow.ToLongTimeString());
            return new UnauthorizedResult();
        }

        [HttpGet("500")]
        public IActionResult InternalError()
        {
            logger.LogInformation("Hit Get Reuquest Status 500", DateTime.UtcNow.ToLongTimeString());
            return new StatusCodeResult(500);
        }



        // Post: api/Status/200
        [HttpPost]
        public IEnumerable<string> Post()
        {
            logger.LogInformation("HitPost  Reuquest Status 200", DateTime.UtcNow.ToLongTimeString());
            return new string[] { "value1", "value2" };
        }

        [HttpPost("404")]
        public IActionResult PostNotFound()
        {
            logger.LogInformation("Hit Post Reuquest Status 404", DateTime.UtcNow.ToLongTimeString());
            return new NotFoundResult();
        }

        [HttpPost("401")]
        public IActionResult PostUnauthorized()
        {
            logger.LogInformation("Hit Post Reuquest Status 401", DateTime.UtcNow.ToLongTimeString());
            return new UnauthorizedResult();
        }

        [HttpPost("500")]
        public IActionResult PostInternalError()
        {
            logger.LogInformation("Hit Post Reuquest Status 500", DateTime.UtcNow.ToLongTimeString());
            return new StatusCodeResult(500);
        }
    }
}
