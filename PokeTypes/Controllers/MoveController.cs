using PokeTypes.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokeTypes.Controllers
{
    public class MoveController : Controller
    {
        private MoveContext db = new MoveContext();
        // GET: Move
        public ActionResult Index()
        {
            return View(db.Moves.ToList());
        }

        // GET: Move/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Move/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Move/Create
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

        // GET: Move/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Move/Edit/5
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

        // GET: Move/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Move/Delete/5
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
