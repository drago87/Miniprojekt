using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models.SentenceBuilding;
using Miniprojekt.Repositories;

namespace Miniprojekt.Controllers
{
    public class SentencesController : Controller
    {
        private SBContext db = new SBContext();

        SentenceBuilderRepository repo = new SentenceBuilderRepository();



        [HttpGet]
        public ActionResult Random()
        {
            return View(repo.GetRandomSentence());
        }

        [HttpPost]
        public ActionResult Random(string test, string mySentence)
        {

            Session["result"] = repo.Examine(mySentence, test);
            return RedirectToAction("Result", "Sentences");
        }


        public ActionResult Result()
        {
            var result = (ExamResult)Session["result"];
            return View(result);
        }

        // GET: Sentences
        public ActionResult Index()
        {
            return View(db.Sentences.ToList());
        }

        // GET: Sentences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sentence sentence = db.Sentences.Find(id);
            if (sentence == null)
            {
                return HttpNotFound();
            }
            return View(sentence);
        }

        // GET: Sentences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sentences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,mySentence")] Sentence sentence)
        {
            if (ModelState.IsValid)
            {
                db.Sentences.Add(sentence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sentence);
        }

        // GET: Sentences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sentence sentence = db.Sentences.Find(id);
            if (sentence == null)
            {
                return HttpNotFound();
            }
            return View(sentence);
        }

        // POST: Sentences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,mySentence")] Sentence sentence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sentence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sentence);
        }

        // GET: Sentences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sentence sentence = db.Sentences.Find(id);
            if (sentence == null)
            {
                return HttpNotFound();
            }
            return View(sentence);
        }

        // POST: Sentences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sentence sentence = db.Sentences.Find(id);
            db.Sentences.Remove(sentence);
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
