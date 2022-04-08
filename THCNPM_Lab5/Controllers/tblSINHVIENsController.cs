using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using THCNPM_Lab5.Models;

namespace THCNPM_Lab5.Controllers
{
    public class tblSINHVIENsController : Controller
    {
        private masterEntities1 db = new masterEntities1();

        // GET: tblSINHVIENs
        public ActionResult Index()
        {
            return View(db.tblSINHVIEN.ToList());
        }

        // GET: tblSINHVIENs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSINHVIEN tblSINHVIEN = db.tblSINHVIEN.Find(id);
            if (tblSINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(tblSINHVIEN);
        }

        // GET: tblSINHVIENs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblSINHVIENs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSv,HoTen,NgaySinh,GioiTinh,MaLop,MaTinh,DTB")] tblSINHVIEN tblSINHVIEN)
        {
            if (ModelState.IsValid)
            {
                db.tblSINHVIEN.Add(tblSINHVIEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSINHVIEN);
        }

        // GET: tblSINHVIENs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSINHVIEN tblSINHVIEN = db.tblSINHVIEN.Find(id);
            if (tblSINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(tblSINHVIEN);
        }

        // POST: tblSINHVIENs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSv,HoTen,NgaySinh,GioiTinh,MaLop,MaTinh,DTB")] tblSINHVIEN tblSINHVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSINHVIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSINHVIEN);
        }

        // GET: tblSINHVIENs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSINHVIEN tblSINHVIEN = db.tblSINHVIEN.Find(id);
            if (tblSINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(tblSINHVIEN);
        }

        // POST: tblSINHVIENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tblSINHVIEN tblSINHVIEN = db.tblSINHVIEN.Find(id);
            db.tblSINHVIEN.Remove(tblSINHVIEN);
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
