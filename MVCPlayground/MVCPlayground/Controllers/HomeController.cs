﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPlayground.Database;

namespace MVCPlayground.Controllers
{
    public class HomeController : Controller
    {

        NicksDatabaseEntities db = new NicksDatabaseEntities();
        
        public ActionResult Index()
        {
            var things = db.NicksFavoriteThings.ToList();
            return View(things);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}