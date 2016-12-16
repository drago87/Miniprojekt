using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models.Uppgift2Models;
using Miniprojekt.Repositories;

namespace Miniprojekt.Controllers
{
    public class Uppgift2Controller : Controller
    {
        private DataAccessLayerUppgift2 db = new DataAccessLayerUppgift2();

        private Uppgift2Repository _repo = new Uppgift2Repository();
        
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

        [HttpPost]
        public ActionResult Test(string Word0 = null, string Word1 = null, string Word2 = null, string Word3 = null, string Word4 = null, string Word5 = null, string Word6 = null, string Word7 = null, string Word8 = null, string Word9 = null,
                                 int ItemID0 = -1, int ItemID1 = -1, int ItemID2 = -1, int ItemID3 = -1, int ItemID4 = -1, int ItemID5 = -1, int ItemID6 = -1, int ItemID7 = -1, int ItemID8 = -1, int ItemID9 = -1)
        {
            List<Uppgift2> temp = new List<Uppgift2>();
            string[] temp2a = new string[10]{ Word0, Word1, Word2, Word3, Word4, Word5, Word6, Word7, Word8, Word9};
            int[] temp2b = new int[10] { ItemID0, ItemID1, ItemID2, ItemID3, ItemID4, ItemID5, ItemID6, ItemID7, ItemID8, ItemID9 };
            for (int i = 0; i < 10; i++)
            {
                if (temp2a[i] != null && temp2a[i] != "" && temp2b[i] != -1)
	            {
		            Uppgift2 temp3 = new Uppgift2();
                    temp3.Mening = temp2a[i];
                    temp3.Orginal_ID = temp2b[i];
                    temp.Add(temp3);
	            }
                
            }
            ViewBag.Points = _repo.CalculatePoints(temp);
            return View(_repo.GetRandomSentence());
        }
    }
}
