using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> listStatic = new List<string>() {
            "value0", "value1","value2"
        };
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return listStatic;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return listStatic[id];

        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            listStatic.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            listStatic[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            listStatic.RemoveAt(id);
        }
    }
}
