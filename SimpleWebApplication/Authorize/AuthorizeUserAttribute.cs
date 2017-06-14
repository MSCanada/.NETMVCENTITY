using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SimpleWebApplication.Authorize


{
    public class AuthorizeUserAttribute : AuthorizeAttribute
    {

        protected override  bool IsAuthorized(HttpActionContext actionContext)
        {
            var roles = this.Roles;
            if (roles.Equals("Admin"))
                return true;
            else return false;
        } 
          
    }
}