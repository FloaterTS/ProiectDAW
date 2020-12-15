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
    public class ReservationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reservations
        public ActionResult Index()
        {
            var reservations = db.Reservations.Include(r => r.BuyPackage).Include(r => r.Game).Include(r => r.ApplicationUser);
            return View(reservations.ToList());
        }

        // GET: Reservations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            ViewBag.BuyPackageId = new SelectList(db.BuyPackages, "Id", "BuyPackageName");
            ViewBag.GameId = new SelectList(db.Games, "Id", "GameName");
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ReservationDate,BuyPackageId,GameId,ApplicationUserId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BuyPackageId = new SelectList(db.BuyPackages, "Id", "BuyPackageName", reservation.BuyPackageId);
            ViewBag.GameId = new SelectList(db.Games, "Id", "GameName", reservation.GameId);
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "UserName", reservation.ApplicationUserId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            ViewBag.BuyPackageId = new SelectList(db.BuyPackages, "Id", "BuyPackageName", reservation.BuyPackageId);
            ViewBag.GameId = new SelectList(db.Games, "Id", "GameName", reservation.GameId);
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "UserName", reservation.ApplicationUserId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ReservationDate,BuyPackageId,GameId,ApplicationUserId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BuyPackageId = new SelectList(db.BuyPackages, "Id", "BuyPackageName", reservation.BuyPackageId);
            ViewBag.GameId = new SelectList(db.Games, "Id", "GameName", reservation.GameId);
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "UserName", reservation.ApplicationUserId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            db.Reservations.Remove(reservation);
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
