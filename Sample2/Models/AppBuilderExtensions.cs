using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample2.Models
{
    public static class AppBuilderExtensions
    {
        public static IApplicationBuilder UseHttpsEnforcement(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
            return app.UseMiddleware<EnforceHttpsMiddleware>();
        }
    }
}
