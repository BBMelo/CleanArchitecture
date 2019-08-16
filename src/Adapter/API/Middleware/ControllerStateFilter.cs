using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using vxTel.Domain.Notifications;

namespace vxTel.WebServiceAdapter.Middleware
{
    public class ControllerStateFilter : IAsyncResultFilter
    {
        private readonly Notification _notification;

        public ControllerStateFilter(Notification notification)
        {
            _notification = notification;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notification.HasNotifications)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(_notification.Notifications));
                return;
            }

            await next();
        }
    }
}
