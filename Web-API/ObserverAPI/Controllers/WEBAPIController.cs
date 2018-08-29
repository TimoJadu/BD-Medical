using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Policy;
using System.IO;
using ObserverAPI;
using System.Web.Http.Cors;

namespace ObserverAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class WEBAPIController : ApiController
    {
        //InvokeAPIResponse<Response> movieservice = new InvokeAPIResponse<Response>(new Url("http://localhost:2491/api/SecondaryWebAPI/Generator?Y=3"));

        [HttpGet]
        [ActionName("Get")]
        public string Get()
        {
            //var i = movieservice.GetAll();
            //var client = new WebClient();
            //var content = client.DownloadString("http://localhost:2491/api/SecondaryWebAPI/Generator?Y=3");
            //==== working ====
            GeneratorManager observableGM = new GeneratorManager();
            Processor observerGM = new Processor(observableGM);

            MultiplierManager observableMM = new MultiplierManager();
            Processor observerMM = new Processor(observableMM);

            observableGM.Value = GetResponse(observableGM.url);
            //observableMM.Value = GetResponse(observableMM.url+ observableGM.Value);

            //return observableMM.Value.ToString();
            return observableGM.Value.ToString();
        }

        [NonAction]
        private string GetResponse(string url)
        {
            var http = (HttpWebRequest)WebRequest.Create(url);
            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            return content.ToString();
        }
    }

    //public class Response
    //{
    //    public string resp { get; set; }
    //}




    //public class ValuesController : ApiController
    //{
    //    // GET api/values
    //    public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    // GET api/values/5
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/values
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT api/values/5
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE api/values/5
    //    public void Delete(int id)
    //    {
    //    }
    //}
}
