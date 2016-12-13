using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models;

namespace Miniprojekt.Controllers
{
    public class Uppgift2Controller : Controller
    {
        private DataAccessLayer db = new DataAccessLayer();

        // GET: Uppgift2
        public ActionResult Index()
        {
            return View(db.uppgift2.ToList());
        }

        // GET: Uppgift2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uppgift2 uppgift2 = db.uppgift2.Find(id);
            if (uppgift2 == null)
            {
                return HttpNotFound();
            }
            return View(uppgift2);
        }

        // GET: Uppgift2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uppgift2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Mening")] Uppgift2 uppgift2)
        {
            if (ModelState.IsValid)
            {
                db.uppgift2.Add(uppgift2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uppgift2);
        }

        // GET: Uppgift2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uppgift2 uppgift2 = db.uppgift2.Find(id);
            if (uppgift2 == null)
            {
                return HttpNotFound();
            }
            return View(uppgift2);
        }

        // POST: Uppgift2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Mening")] Uppgift2 uppgift2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uppgift2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uppgift2);
        }

        // GET: Uppgift2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uppgift2 uppgift2 = db.uppgift2.Find(id);
            if (uppgift2 == null)
            {
                return HttpNotFound();
            }
            return View(uppgift2);
        }

        // POST: Uppgift2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uppgift2 uppgift2 = db.uppgift2.Find(id);
            db.uppgift2.Remove(uppgift2);
            db.SaveChanges();
            return RedirectToAction("Index");
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
