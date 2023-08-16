using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Power.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public  ActionResult<string> Get()
        {
             _logger.LogInformation("All users have been returned" );
            return "Users [...]";
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            _logger.LogInformation("User has been updated");
            return "User has been updated";
        }
    }
}
