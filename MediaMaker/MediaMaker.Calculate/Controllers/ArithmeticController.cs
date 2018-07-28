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
        [HttpGet]
        public double Add(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Add(secondValue)
                .Calculate();
        }

        [Route("subract")]
        [HttpGet]
        public double Subtract(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Subtract(secondValue)
                .Calculate();
        }

        [Route("multiply")]
        [HttpGet]
        public double Multiply(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Multiply(secondValue)
                .Calculate();
        }

        [Route("divide")]
        [HttpGet]
        public double Divide(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Divide(secondValue)
                .Calculate();
        }
    }
}