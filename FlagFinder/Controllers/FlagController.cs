using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlagFinder.Models;

namespace FlagFinder.Controllers
{
    public class FlagController : Controller
    {
        // GET: Flag
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index(string id)
        {
            return View();
        }

        // GET: Flag/Details/5
        public ActionResult Details(string id)
        {
            var flagColl = new Flags();
            flagColl.LoadFlags();
            var flags = flagColl.FlagList();
            var flag = flags.Where(f => f.Name.ToLower() == id.ToLower()).First();

            return View(flag);
        }

        public ActionResult Flag(string id)
        {
            var flagColl = new Flags();
            flagColl.LoadFlags();
            var flags = flagColl.FlagList();
            var flag = flags.Where(f => f.Name == id).First();

            return View(flag);
        }


        
        // GET: Flag/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flag/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Flag/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flag/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Flag/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
