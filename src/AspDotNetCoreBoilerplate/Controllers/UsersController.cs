using AspDotNetCoreBoilerplate.DataAccess.Repositories;
using AspDotNetCoreBoilerplate.Domain.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly ILogger _logger = null;

        public UsersController(
            IUserService userService,
            ILogger<UsersController> logger)
        {
            _userService = userService;

            _logger = logger;
        }

        /// <summary>
        /// Get All Users.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        [ProducesResponseType(typeof(IEnumerable<User>), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Start to get users.");

            var result = await _userService.GetUsers();

            return Ok(result);
        }

        /// <summary>
        /// Create a user.
        /// </summary>
        /// <returns></returns>
        [HttpPost("user")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] User userInfo)
        {
            // TODO: logic

            return Ok();
        }
    }
}
