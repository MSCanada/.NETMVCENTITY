using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleWebApplication.Authorize;
using SimpleWebApplication.Services;

namespace SimpleWebApplication.Controllers.Api
{
    public class WelcomeController : ApiController
    {
        public IMessageService service;
        public WelcomeController(IMessageService service)
        {
            this.service = service;

        }
        [AuthorizeUser(Roles = "Admin")]
        public string Get()
        {
            return service.GetWelcomeMessage();
        }
    }
}
