using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/dice/{n}/{m}")]
        public string Getdice(int n, int m)
        {
            int counter = 0;
            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        counter++;
                    }
                }
            }

            return "There are " + counter + " total ways to get the sum 10";

        }
    }
}
