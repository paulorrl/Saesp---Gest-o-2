using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAESP.Domain.Core.Services;
using System;

namespace SAESP.API.Controllers.Base
{
    [Produces("application/json")]
    public class BaseController : Controller
    {
        private readonly ServiceNotification _notification;

        public BaseController(ServiceNotification notification)
        {
            _notification = notification;
        }

        public async Task<IActionResult> Response(object result)
        {
            if (!_notification.HasNotification())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errors = _notification.GetNotifications()
                });
            }
        }
    }
}