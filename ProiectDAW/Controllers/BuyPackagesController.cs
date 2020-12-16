using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProiectDAW.Models;

namespace ProiectDAW.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class BuyPackagesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BuyPackages
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.BuyPackages.ToList());
        }

        // GET: BuyPackages/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuyPackage buyPackage = db.BuyPackages.Find(id);
            if (buyPackage == null)
            {
                return HttpNotFound();
            }
            return View(buyPackage);
        }

        // GET: BuyPackages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuyPackages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BuyPackageName,BuyPackagePrice,BuyPackageDuration")] BuyPackage buyPackage)
        {
            if (ModelState.IsValid)
            {
                db.BuyPackages.Add(buyPackage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buyPackage);
        }

        // GET: BuyPackages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuyPackage buyPackage = db.BuyPackages.Find(id);
            if (buyPackage == null)
            {
                return HttpNotFound();
            }
            return View(buyPackage);
        }

        // POST: BuyPackages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BuyPackageName,BuyPackagePrice,BuyPackageDuration")] BuyPackage buyPackage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buyPackage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buyPackage);
        }

        // GET: BuyPackages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuyPackage buyPackage = db.BuyPackages.Find(id);
            if (buyPackage == null)
            {
                return HttpNotFound();
            }
            return View(buyPackage);
        }

        // POST: BuyPackages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BuyPackage buyPackage = db.BuyPackages.Find(id);
            db.BuyPackages.Remove(buyPackage);
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
