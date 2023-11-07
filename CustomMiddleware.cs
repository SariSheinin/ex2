using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ex2
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate request;

        public CustomMiddleware(RequestDelegate request)
        {
            this.request = request;
        }

        public Task Invoke(HttpContext httpContext)
        {

            //return this.request(httpContext);
            Console.WriteLine("wwwwwwwwwww");
            return httpContext.Response.WriteAsync("aaaaaaa");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
