using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSafariProcessor(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SafariMiddleware>();
        }
    }
}
