using MediaMaker.Common.Tools.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MediaMaker.Calculate.Controllers
{
    [EnableCors(origins: "http://localhost:61462", headers: "*", methods: "GET")]
    public class ArithmeticController : ApiController
    {
        [HttpGet]
        public double Add(string firstValue, string secondValue)
        {
            return new BasicCalculation(double.Parse(firstValue))
                .Add(double.Parse(secondValue))
                .Calculate();
        }

        [HttpGet]
        public double Subtract(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Subtract(secondValue)
                .Calculate();
        }

        [HttpGet]
        public double Multiply(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Multiply(secondValue)
                .Calculate();
        }

        [HttpGet]
        public double Divide(double firstValue, double secondValue)
        {
            return new BasicCalculation(firstValue)
                .Divide(secondValue)
                .Calculate();
        }
    }
}