using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
    public class J3Controller : ApiController
    {
        [Route("api/J3/sec/{crac}")]
        public string Getsec(string crac)
        {
            char[] fl = { 'a', 'd', 'g', 'j', 'm', 'p', 't', 'w' };
            char[] sl = { 'b', 'e', 'h', 'k', 'n', 'q', 'u', 'x' };
            char[] tl = { 'c', 'f', 'i', 'l', 'o', 'r', 'v', 'y' };
            char[] fol = { 's', 'z' };
            int tfl = 1;
            int tsl = 2;
            int ttl = 3;
            int tfol = 4;
            int time = 0;

            if(crac != "halt")
            {
                for (int i = 0; i < crac.Length; i++)
                {
                    if (fl.Contains(crac[i]))
                    {
                        time = time + tfl;
                    } else if (sl.Contains(crac[i]))
                    {
                        time = time + tsl;
                    }else if (tl.Contains(crac[i]))
                    {
                        time = time + ttl;
                    }else if (fol.Contains(crac[i]))
                    {
                        time = time + tfol;
                    }
                }
            }
               
            return "the time takes to type the given string is: " + time.ToString();

         }
    }
}
