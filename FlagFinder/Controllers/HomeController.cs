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
            ViewBag.FlagCount = flags.Count;
            return View();
        }

        public ActionResult Flag(string id)
        {
            if(String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }
            var flagColl = new Flags();
            flagColl.LoadFlags();
            var flags = flagColl.FlagList();
            var flag = flags.Where(f => f.Name.ToLower() == id.ToLower()).First();
            return View(flag);
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your application description page.";

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