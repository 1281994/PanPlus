using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2cmi.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            return View();
        }

        // GET: user/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: user/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: user/Create
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

        // GET: user/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: user/Edit/5
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

        // GET: user/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: user/Delete/5
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
