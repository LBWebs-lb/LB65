using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace LB.Common
{
    public static class ExtensionsMethods
    {
        public static string getuserid(this ClaimsPrincipal user)
        {
            if !user.Identity.IsAuthenticated {
                return null
            }
            ClaimsPrincipal currentuser = user;

            return currentuser.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
