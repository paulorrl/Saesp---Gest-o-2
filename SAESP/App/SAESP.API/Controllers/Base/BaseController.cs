using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAESP.Domain.Core.Services;

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

            return ResponseError(_notification.GetNotifications());
        }

        public IActionResult ResponseError(object data) =>
            BadRequest(new
            {
                success = false,
                errors = data
            });
    }
}