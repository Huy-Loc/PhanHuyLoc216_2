using LTQL_1721050216.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LTQL_1721050216.Controllers
{
    public class LopHoc216Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: LopHoc216
        public ActionResult Index()
        {
            return View(db.LopHoc216s.ToList());
        }

        // GET: LopHoc216/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc216 LopHoc216 = db.LopHoc216s.Find(id);
            if (LopHoc216 == null)
            {
                return HttpNotFound();
            }
            return View(LopHoc216);
        }

        // GET: LopHoc216/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc216/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Malop,TenLop")] LopHoc216 LopHoc216)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc216s.Add(LopHoc216);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(LopHoc216);
        }

        // GET: LopHoc216/Edit/5
        [Authorize]

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc216 LopHoc216 = db.LopHoc216s.Find(id);
            if (LopHoc216 == null)
            {
                return HttpNotFound();
            }
            return View(LopHoc216);
        }

        // POST: LopHoc216/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Malop,TenLop")] LopHoc216 LopHoc216)
        {
            if (ModelState.IsValid)
            {
                db.Entry(LopHoc216).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(LopHoc216);
        }

        // GET: LopHoc216/Delete/5
        [Authorize]

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc216 LopHoc216 = db.LopHoc216s.Find(id);
            if (LopHoc216 == null)
            {
                return HttpNotFound();
            }
            return View(LopHoc216);
        }

        // POST: LopHoc216/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc216 LopHoc216 = db.LopHoc216s.Find(id);
            db.LopHoc216s.Remove(LopHoc216);
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