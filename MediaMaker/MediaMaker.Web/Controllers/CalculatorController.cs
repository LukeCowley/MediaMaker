﻿using MediaMaker.Common.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaMaker.Web.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new CalculatorViewModel());
        }
    }
}