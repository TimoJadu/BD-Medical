using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Policy;

namespace Observer_API.Controllers
{
    public class WEBAPIController : ApiController
    {
        InvokeAPIResponse<Response> movieservice = new InvokeAPIResponse<Response>(new Url("http://localhost:2491/api/SecondaryWebAPI/Generator?Y=3"));

        [HttpGet]
        [ActionName("Get")]
        public void Get()
        {
            var i = movieservice.GetAll();
        }

    }

    public class Response
    {
        public string resp { get; set; }
    }
}

