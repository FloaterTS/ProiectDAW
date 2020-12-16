﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProiectDAW.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GameTag description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "GameTag contact page.";

            return View();
        }
    }
}