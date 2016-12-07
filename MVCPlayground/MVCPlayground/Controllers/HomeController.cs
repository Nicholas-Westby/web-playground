using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPlayground.Database;
using System.Dynamic;

namespace MVCPlayground.Controllers
{
    public class HomeController : Controller
    {

        NicksDatabaseEntities db = new NicksDatabaseEntities();
        
        public ActionResult Index()
        {
            return View(db.NicksFavoriteThings);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            // Create an expando object to be used as the view model.
            var contactInfo = new ExpandoObject() as dynamic;
            contactInfo.PhoneNumber = "867-5309";
            contactInfo.Address = "Any Street";

            return View(contactInfo);
        }
    }
}