using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
    // The question demands 3 inputs, which equate to 3 kinds of treats
    // create a variable(happyScore) to accomidate "treat" formula
    // check whether the  happyScore is greater than and equal to 10 
    // returning a string message accordingly
    
    public class J1Controller : ApiController
    {
        [Route("api/J1/Trt/{s}/{m}/{l}")]

        public string GetTrt(int s, int m, int l)
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
