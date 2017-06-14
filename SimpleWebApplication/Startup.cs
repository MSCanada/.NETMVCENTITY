using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using SimpleWebApplication.AuthenticationOWIN;

namespace SimpleWebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UsePinBasedAuthentication();
        }
    }
}