using System;
using System.Linq;
using System.Web.Mvc;

namespace Miniprojekt.Controllers
{
    using DataAccess;
    using Models.Text2Color;

    public class Text2ColorController : Controller
    {
        private Text2ColorContext db = new Text2ColorContext();

        // GET: Text2Color
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] //[Bind(Include = "ID,Username,Points")] 
        public HttpStatusCodeResult NewHighscore(Highscore highscore)
        {
            if (ModelState.IsValid)
            {
                highscore.Time = DateTime.Now;
                db.Highscores.Add(highscore);
                db.SaveChanges();
                return new HttpStatusCodeResult(200, "Values Inserted Correctly");
            }

            return new HttpStatusCodeResult(400, "Inserted Model was not valid.");
        }

        public JsonResult Highscores()
        {
            return Json(db.Highscores.AsNoTracking()
                .OrderByDescending(p => p.Points)
                .ThenBy(p => p.Time)
                    .Take(5), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Colors()
        {
            return Json(db.Colors.AsNoTracking()
                .OrderBy(p => Guid.NewGuid()), JsonRequestBehavior.AllowGet);
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
