using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebApplication.Controllers.Api
{
    public class SampleController : ApiController
    {
        [Authorize]
        public string Get()
        {
            return "Owin reached";
        }
    }
}
