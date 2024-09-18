
namespace WebApplication2_middleware_
{
    public class Class : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
            await context.Response.WriteAsync("Custom Middleware incoming Request");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware outcoming Response");

        }

    }
}
