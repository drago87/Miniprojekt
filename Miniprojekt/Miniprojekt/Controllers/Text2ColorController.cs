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

        [HttpPost]
        public ActionResult NewHighscore([Bind(Include = "ID,Username,Points,Time")] Highscore highscore)
        {
            if (ModelState.IsValid)
            {
                highscore.Time = DateTime.Now;
                db.Highscores.Add(highscore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(highscore);
        }

        public JsonResult Colors()
        {
            return Json(db.Colors.AsNoTracking().OrderBy(p => Guid.NewGuid()), JsonRequestBehavior.AllowGet);
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
