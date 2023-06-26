using System.Security.Authentication;
using LoggingLibrary;
using Microsoft.AspNetCore.Http.Extensions;

namespace MiddlewareExample
{
    public class LoggingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            Logger log = new Logger(3);
            string timestamp = DateTime.Now.ToString();
            string method = context.Request.Method;
            string url = context.Request.GetDisplayUrl();

            throw new NotImplementedException();
        }
    }
}
