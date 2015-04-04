using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestfulService.Controllers
{
    using System.Drawing;

    public class CalcDistanceController : ApiController
    {
        [HttpPost]
        [Route("calcDistance")]
        public double calcDistance(int ax, int ay, int bx, int by)
        {
            Point startPoint = new Point(){X = ax, Y = ay};
            Point endPoint = new Point() { X = bx, Y = by };

            var deltaX = startPoint.X - endPoint.X;
            var deltaY = startPoint.X - endPoint.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        [HttpPost]
        [Route("sum")]
        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
