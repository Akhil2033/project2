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
    // calculate the no of seconds spent on typing a string with T9 keyboard
    // dividing alphabets with respect to their placement on the buttons
    // 4 arrays are created to alocate 1st, 2nd, 3rd and 4th positioned letters.
    // create 4 variables which represent no of seconds required to type each kind of letter
    // A seperate variable called time is allocated to keep the track of no of seconds.
    // unfortunately I couldn't come up with "pause time method" on time which is used to keep track of words that use only one key.
    
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
