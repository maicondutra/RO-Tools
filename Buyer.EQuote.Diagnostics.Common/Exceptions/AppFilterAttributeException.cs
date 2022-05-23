using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Buyer.EQuote.Diagnostics.Common.Exceptions
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class AppFilterAttributeException : ExceptionFilterAttribute
    {
        private readonly ILogger<Exception> _Logger;
        public AppFilterAttributeException(ILogger<Exception> logger)
        {
            _Logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            if (context != null)
            {
                _Logger.LogError(context.Exception, context.Exception.Message, new[] { context.Exception.StackTrace });

                var msg = new
                {
                    context.Exception.Message,
                    ExceptionType = context.Exception.GetType().ToString()
                };

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Result = new ObjectResult(msg);
            }
        }
    }
}
