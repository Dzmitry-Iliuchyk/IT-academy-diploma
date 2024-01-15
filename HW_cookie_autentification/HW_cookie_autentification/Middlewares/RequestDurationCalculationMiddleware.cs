using System.Diagnostics;

namespace HW_cookie_autentification.Middlewares
{
    public class RequestDurationCalculationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestDurationCalculationMiddleware> _logger;
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public RequestDurationCalculationMiddleware(RequestDelegate next, ILogger<RequestDurationCalculationMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            var httpMethod = context.Request.Method;
            var httpPath = context.Request.Path;
            _logger.LogWarning($"Запрос {httpMethod} {httpPath} начал выполнение ");
            _stopwatch.Restart();
                await _next(context);
            _stopwatch.Stop();
            _logger.LogWarning($"Запрос {httpMethod} {httpPath} длился - {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
