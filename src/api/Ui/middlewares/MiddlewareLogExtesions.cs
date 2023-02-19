using Microsoft.AspNetCore.Builder;

namespace Api.Ui.Middlewares
{
    public static class MiddlewareLogExtensions
    {
        public static IApplicationBuilder UseMiddlewareLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareLog>();
        }
    }
}