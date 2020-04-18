using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcelotApiGW
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(context.Request.PathBase);
            Console.WriteLine(context.Request.Path);
            Console.ResetColor();
            await _next(context);
        }
    }
}
