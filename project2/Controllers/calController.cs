using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project2.Controllers
{
    public class calController : ApiController
    {
        [Route("api/cal/Menu/{id1}/{id2}/{id3}/{id4}")]

        public string GetMenu(int id1, int id2, int id3, int id4)
        {
           int[] burger = {461, 431, 420, 0};
           int[] drink = {130, 160, 118, 0};
           int[] side = {100, 57, 70, 0};
           int[] dessert = { 167, 266, 75, 0};

            id1 = burger[id1 - 1];
            id2 = drink[id2 - 1];
            id3 = side[id3 - 1];
            id4 = dessert[id4 - 1];

           int total = id1 + id2 + id3 + id4;

            return "your total calorie count is " + total;

        }
    }
}
