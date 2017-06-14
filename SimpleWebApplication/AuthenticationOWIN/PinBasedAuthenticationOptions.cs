using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;

namespace SimpleWebApplication.AuthenticationOWIN
{
    public class PinBasedAuthenticationOptions : AuthenticationOptions
    {
        public PinBasedAuthenticationOptions() : base("x-company-auth")
        { }
    }
}