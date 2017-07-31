using FlagFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlagFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var flags = new Flags();
            flags.LoadFlags();
            ViewBag.Flags = flags;
            return View();
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