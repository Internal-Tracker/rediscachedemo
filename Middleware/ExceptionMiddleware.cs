using rediscachedemoazure.error;
using System.Net;

namespace rediscachedemoazure.Middleware
{
    public class ExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(ILogger<ExceptionMiddleware> logger)
        {
                _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);

            }
            catch (Exception ex)
            {
                _logger.LogError("something went wrong." + ex.Message);
                await HandleException(context, ex,_logger);   

            }
        }

        private static Task HandleException(HttpContext context,Exception ex,ILogger logger)
        {
            int statuscode = (int) HttpStatusCode.InternalServerError;
            var errorresponse = new ErrorResponse
            {
                ErrorStatusCode = statuscode,
                ErrorMessage = ex.Message
            };
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statuscode;
            logger.LogError(errorresponse.ToString(),ex);
            
            return context.Response.WriteAsync(errorresponse.ToString());

        }
    }
}
