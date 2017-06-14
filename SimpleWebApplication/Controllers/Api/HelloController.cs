using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SimpleWebApplication.Authorize.Filters;

namespace SimpleWebApplication.Controllers.Api
{
    public class HelloController : ApiController
    {
        [ActionFilter]
        [Route("types/{typeName}/properties")]
        [ResponseType(typeof(string))]
        public string Get(String typeName)
        {
            return typeName;
        }
    }
}
