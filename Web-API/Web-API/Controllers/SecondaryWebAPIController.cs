using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;
using System.Web.Http.Cors;
using System.Threading;

namespace Web_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SecondaryWebAPIController : ApiController
    {
        Random rdNumber = new Random();
        Random rdDelay = new Random();
        Random rdMultiplier = new Random();

        
        [ActionName("Generator")]
        [HttpGet]
        public string Generator()
        {
            //int[] arrY = new Int32[Y];           

            //int i = -1;
            //do
            //{
            //    ++i;
            //    Thread.Sleep(rdDelay.Next(5, 10) * 1000);
            //    return (rdNumber.Next(1, 100)).ToString();

            //} while (i < Y);

            Thread.Sleep(rdDelay.Next(5, 10) * 1000);
            return (rdNumber.Next(1, 100)).ToString();
        }

        
        [ActionName("Multiplier")]
        [HttpGet]
        public string Multiplier([FromUri] string multiplicand)
        {
            int number = Convert.ToInt32(multiplicand) * rdMultiplier.Next(2, 4);
            Thread.Sleep(rdDelay.Next(5, 10) * 1000);

            return (number).ToString();
        }
    }
}
