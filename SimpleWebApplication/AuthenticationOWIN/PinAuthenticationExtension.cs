using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace SimpleWebApplication.AuthenticationOWIN
{
    public static class PinAuthenticationExtension
    {
        public static void UsePinBasedAuthentication(this IAppBuilder appBuilder)
        {
            appBuilder.Use<PinBasedAuthMiddleware>(new PinBasedAuthenticationOptions());
        }
    }
}