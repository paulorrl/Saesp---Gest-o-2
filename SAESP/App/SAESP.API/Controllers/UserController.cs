using SAESP.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Domain.Core.Services;
using System;

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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = _userApp.GetUsers();
                return await Response(result);
            }
            catch (Exception e)
            {
                return ResponseError(new[] { "Erro interno ... " });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] RegisterUserCommand command)
        {
            try
            {
                var result = _userApp.AddUser(command);
                return await Response(result);
            }
            catch (Exception e)
            {
                return ResponseError(new[] { "Erro interno ... " });
            }
        }
    }
}