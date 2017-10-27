using System.Web.Http.ExceptionHandling;
using Utility.Exceptions;
using Utility.Logger;

namespace Utility.Services
{
    public class UnhandledExceptionLogger : ExceptionLogger
    {
        private readonly SimpleLogger _logger = new SimpleLogger();

        public override void Log(ExceptionLoggerContext context)
        {
            var exception = context.Exception;
            var exceptionType = exception.GetType();
            if (exceptionType != typeof(SimpleBadRequestException))
            {
                _logger.Error(context.Exception);
            }
        }
    }
}
