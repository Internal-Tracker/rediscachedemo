using rediscachedemoazure.Middleware;
using System.Runtime.CompilerServices;

namespace rediscachedemoazure.Extension
{
    public static class ExceptionMiddlewareExtension
    {
        public static void addExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
