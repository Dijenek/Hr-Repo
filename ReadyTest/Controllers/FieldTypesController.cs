using ReadyTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ReadyTest.Controllers
{
    public class FieldTypesController : Controller
    {
        private EmplyessDB db = new EmplyessDB();

        // GET: FieldTypes
        public ActionResult Index()
        {
            return View(db.FieldTypes.ToList());
        }

        // GET: FieldTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldTypes fieldTypes = db.FieldTypes.Find(id);
            if (fieldTypes == null)
            {
                return HttpNotFound();
            }
            return View(fieldTypes);
        }

        // GET: FieldTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FieldTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] FieldTypes fieldTypes)
        {
            if (ModelState.IsValid)
            {
                db.FieldTypes.Add(fieldTypes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fieldTypes);
        }

        // GET: FieldTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldTypes fieldTypes = db.FieldTypes.Find(id);
            if (fieldTypes == null)
            {
                return HttpNotFound();
            }
            return View(fieldTypes);
        }

        // POST: FieldTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] FieldTypes fieldTypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fieldTypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fieldTypes);
        }

        // GET: FieldTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldTypes fieldTypes = db.FieldTypes.Find(id);
            if (fieldTypes == null)
            {
                return HttpNotFound();
            }
            return View(fieldTypes);
        }

        // POST: FieldTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FieldTypes fieldTypes = db.FieldTypes.Find(id);
            db.FieldTypes.Remove(fieldTypes);
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
