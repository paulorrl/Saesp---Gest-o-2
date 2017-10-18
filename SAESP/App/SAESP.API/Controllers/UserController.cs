using SAESP.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Domain.Core.Services;

namespace SAESP.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/users")]
    public class UserController : BaseController
    {
        private readonly IUserApplication _userApp;

        public UserController(IUserApplication userApp, ServiceNotification notification)
            : base(notification)
        {
            _userApp = userApp;
        }

        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] RegisterUserCommand command)
        {
            try
            {
                var result = _userApp.AddUser(command);
                return await Response(result);
            }
            catch
            {
                return BadRequest(new
                {
                    success = false,
                    errors = new[] { "Erro interno no servidor. Tente novamente mais tarde!" }
                });
            }
        }
    }
}