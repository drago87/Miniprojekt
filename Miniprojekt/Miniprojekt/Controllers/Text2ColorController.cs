using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models.Text2Color;

namespace Miniprojekt.Controllers
{
    public class Text2ColorController : Controller
    {
        private Text2ColorContext db = new Text2ColorContext();

        // GET: Text2Color
        public ActionResult Index()
        {
            return View(db.Highscores.ToList());
        }

        // POST: Text2Color/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Username,Points,Time")] Highscore highscore)
        {
            if (ModelState.IsValid)
            {
                db.Highscores.Add(highscore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(highscore);
        }

        public JsonResult Colors()
        {
            return Json(db.Colors.AsNoTracking(), JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
