using System.Security.Authentication;

namespace MiddlewareExample
{
    public class AuthenticationMiddleware : IMiddleware
    {
        private static HashSet<string> tokens = new HashSet<string> { "token1", "token2", "token3" };
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            string token = context.Request.Headers["token"];
            if (tokens.Contains(token))
            {
                await next(context);
                context.Response.StatusCode = 200;
            }
            else
            {
                context.Response.StatusCode = 401;
                throw new AuthenticationException();
            }
        }

    }
}
