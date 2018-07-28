using MediaMaker.Common.Tools.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace MediaMaker.Calculate.Controllers
{
    [RoutePrefix("basic")]
    public class ArithmeticController : ApiController
    {
        [Route("add")]
        [HttpPost]
        public double Add(double firstValue, double secondValue)
        {
            var calc = new BasicCalculation(firstValue)
                .Add(secondValue);
            return calc.Calculate();
        }
    }
}