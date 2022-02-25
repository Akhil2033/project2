using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
// calculate the possible no of ways a pair of dice with n and m sides can return value 10 when their sided are added
//create two integers that represent no of sides of the two dices.
// intialising a counter to 0 to keep track of no of ways
// create a for loop for each die to create a possible pair which will result in the value 10.
// return the final updated counter with a string
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
