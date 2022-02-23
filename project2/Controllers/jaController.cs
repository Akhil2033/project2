using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
    
    
    public class jaController : ApiController
    {
        [Route("api/Ja/J1/{s}/{m}/{l}")]

        public string GetJ1(int s, int m, int l)
        {
            int happyScore = (1 * s) + (2 * m) + (3 * l);


            if (happyScore >= 10)
            {
                return "Barley is happy!";
            }
            else
            {
                return "Barley is sad :(";
            }

        }
    }
}
