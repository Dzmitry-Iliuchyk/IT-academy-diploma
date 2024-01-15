using Microsoft.AspNetCore.Mvc.Filters;
using NuGet.Packaging.Signing;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace HW_cookie_autentification.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private readonly ILogger<LoggingActionFilter> _logger;
        public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
        { 
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var userName = context.HttpContext?.User?.Identity?.Name;
            var userIsAuthenticated = context.HttpContext?.User?.Identity?.IsAuthenticated;
            var httpMethod = context.HttpContext?.Request.Method;
            var httpPath = context.HttpContext?.Request.Path.Value;
            _stopwatch.Stop();
            _logger.LogInformation($"User {userName} authenticated: {userIsAuthenticated}," +
                $" Http Method: {httpMethod}, HttpPath: {httpPath}. End Method. TIME:{_stopwatch.ElapsedMilliseconds} ms");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch.Restart();
            var userName = context.HttpContext?.User?.Identity?.Name;
            var userIsAuthenticated = context.HttpContext?.User?.Identity?.IsAuthenticated;
            var httpMethod = context.HttpContext?.Request.Method;
            var httpPath = context.HttpContext?.Request.Path.Value;
            _logger.LogInformation($"User {userName} authenticated: {userIsAuthenticated}," +
                $" Http Method: {httpMethod}, HttpPath: {httpPath}. Start method ");
        }
    }
}
