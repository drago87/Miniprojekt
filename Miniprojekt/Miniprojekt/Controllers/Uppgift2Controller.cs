﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models;
using Miniprojekt.Repositorys;

namespace Miniprojekt.Controllers
{
    public class Uppgift2Controller : Controller
    {
        private DataAccessLayerUppgift2 db = new DataAccessLayerUppgift2();

        private Uppgift2Repository _repo = new Uppgift2Repository();
=======
        private Repositorys.Repository _repo = new Repositorys.Repository();
>>>>>>> 3983d83f3c674fa574ad8c5a68ce9296774c2612
        // GET: Uppgift2
        public ActionResult Index()
        {
            return View(_repo.GetAllSentences());
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
                _repo.AddToDB(uppgift2);
                /*db.uppgift2.Add(uppgift2);
                db.SaveChanges();*/
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
                _repo.EditInDB(uppgift2);
                /*db.Entry(uppgift2).State = EntityState.Modified;
                db.SaveChanges();*/
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
            _repo.RemoveFromDB(uppgift2);
            /*db.uppgift2.Remove(uppgift2);
            db.SaveChanges();*/
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

        public ActionResult Test()
        {
            return View(_repo.GetRandomSentence());
        }
    }
}
