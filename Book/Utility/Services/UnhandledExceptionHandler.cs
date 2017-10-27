using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using Utility.Exceptions;
using Utility.Logger;
using Utility.Messages;
using Utility.Results;

namespace Utility.Services
{
    public class UnhandledExceptionHandler : System.Web.Http.ExceptionHandling.ExceptionHandler
    {
        private readonly SimpleLogger _logger = new SimpleLogger();

        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;
            _logger.Error(exception);
            var exceptionType = exception.GetType();
            if (exceptionType == typeof(SimpleBadRequestException))
            {
                var errorMessage = new ErrorMessage { Code = 0, Message = exception.Message };
                context.Result = new SimpleBadRequestResult(context.Request, errorMessage);
            }
            else if (exceptionType == typeof(SimpleUnauthorizedException))
            {
                var authenticationHeaderValues = new List<AuthenticationHeaderValue> { context.Request.Headers.Authorization };
                context.Result = new UnauthorizedResult(authenticationHeaderValues, context.Request);
            }
            else
            {
                context.Result = new SimpleInternalServerErrorResult(context.Request, "UnhandledException");
            }
        }
    }
}
