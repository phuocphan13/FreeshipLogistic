using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace FSLogistic.Core.Extensions
{
    public static class ClaimExtention
    {
        public static string GetCurrentUserGUID(this IPrincipal principal, IHttpContextAccessor context)
        {
            var identity = context.HttpContext.User.Identity as ClaimsIdentity;
            if (principal != null && principal.Identity != null)
                return identity.FindFirst("userId").Value;
            return null;
        }
    }
}
