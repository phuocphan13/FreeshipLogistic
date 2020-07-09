using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FSLogistic.Web.MiddleWares
{
    public class AuthenHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var identity = context.User.Identity as ClaimsIdentity;
            var abc = context.User.Claims.ToList();
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                //// or
                ///var claim = identity.FindFirst("ClaimName").Value;
            }
            await _next(context);
        }
    }

    public static class AuthenHandlerMiddlewareExtension
    {
        public static IApplicationBuilder UseAuthenHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenHandlerMiddleware>();
        }
    }
}
