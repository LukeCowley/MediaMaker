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
        public IHttpActionResult Add(double firstValue, double secondValue)
        {
            return Ok(new BasicCalculation(firstValue)
                .Add(secondValue)
                .Calculate());
        }

        [HttpGet]
        public IHttpActionResult Subtract(double firstValue, double secondValue)
        {
            return Ok(new BasicCalculation(firstValue)
                .Subtract(secondValue)
                .Calculate());
        }

        [HttpGet]
        public IHttpActionResult Multiply(double firstValue, double secondValue)
        {
            return Ok(new BasicCalculation(firstValue)
                .Multiply(secondValue)
                .Calculate());
        }

        [HttpGet]
        public IHttpActionResult Divide(double firstValue, double secondValue)
        {
            return Ok(new BasicCalculation(firstValue)
                .Divide(secondValue)
                .Calculate());
        }
    }
}