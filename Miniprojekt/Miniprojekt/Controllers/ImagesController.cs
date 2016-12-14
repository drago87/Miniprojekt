using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccess;
using Miniprojekt.Models.ImgText;
using Miniprojekt.Repository;

namespace Miniprojekt.Controllers
{
    public class ImagesController : Controller
    {
        private ImgTextRepository repo = new ImgTextRepository();

        // GET: Images
        public ActionResult Index()
        {
            return View(repo.db.Images.ToList());
        }

        public ActionResult QuizImage(int? id)
        {
            Image tmp;
            if(id == null)
            {
                tmp = repo.GetRandomImg();
            }
            else
            {
                tmp = repo.GetImgById(id);
            }
            return View(tmp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult QuizImage(FormCollection collection)
        {
            int id = int.Parse(collection["ImageId"]);
            string answer = collection["Answer"];

            var model = repo.GetImgById(id);
            if (repo.CompareTextImg(answer, model))
                return View(model);
            else
                RedirectToAction("QuizImage");

            return View();
        }

        // GET: Images/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = repo.db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Url,Desciption")] Image image)
        {
            if (ModelState.IsValid)
            {
                repo.db.Images.Add(image);
                repo.db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(image);
        }

        // GET: Images/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = repo.db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Url,Desciption")] Image image)
        {
            if (ModelState.IsValid)
            {
                repo.db.Entry(image).State = EntityState.Modified;
                repo.db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(image);
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = repo.db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Image image = repo.db.Images.Find(id);
            repo.db.Images.Remove(image);
            repo.db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
