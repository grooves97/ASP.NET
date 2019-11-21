using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12
{
    public class SafariMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public SafariMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var browser = context.Request.Headers["User-Agent"].ToString();
            if (browser.ToLower().Contains("safari"))
            {
                await context.Response.WriteAsync("Пошёл вон");
            }
            await requestDelegate(context);
        }
    }
}
