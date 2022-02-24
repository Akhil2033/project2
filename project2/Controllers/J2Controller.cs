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
            int[] nside = new int[n];
            int[] mside = new int[m];
            int counter = 0;

            for (int i = 1; i < nside.Length; i++)
            {

                nside[i] = i;

                int nNum = nside[i];


                for (int j = 1; j< mside.Length; j++)
                {
                    mside[j] = j;

                    int mNum = mside[j];

                    int sum = nNum + mNum;

                    while(sum == 10)
                    {
                        counter++;

                    }


                }
            }

            return "The no of ways is :" + counter;



        }
    }
}
