using Identity.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.WebUI.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserQuery _userQuery;
        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;

        public UserController(
            ILogger<UserController> logger,
            IMediator mediator,
            IUserQuery userQuery)
        {
            _logger = logger;
            _mediator = mediator;
            _userQuery = userQuery;
        }

        [HttpGet("{id}")]
        public async Task<UserDto> Get(string id)
        {
            return await _userQuery.GetAsync(id);
        }
    }
}
