﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiabetesTrackerASPAplikacija.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DiabetesTrackerASPAplikacija.Controllers
{
    [Authorize]
    public class KorisniksController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Korisniks
        public ActionResult Index()
        {
            return View(db.Korisnik.ToList());
        }

        // GET: Korisniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // GET: Korisniks/Create
        public ActionResult Create()
        {            
            return View();
        }

        // POST: Korisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipDijabetesa,Visina,Tezina,FizickaAktivnost,VrijednostHiperglikemije,VrijednostHipoglikemije,CiljaniNivoGlukoze,DonjaGranicaGlukoze,GornjaGranicaGlukoze,Tip,Lijekovi,DozaLijeka,Spol,Ime,Prezime,Username,Password,PotvrdaPassworda,EMail,JMBG1,Spol1,DatumRodjenja")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                korisnik.EMail = User.Identity.Name;
                korisnik.Username = User.Identity.GetUserName();
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(korisnik);
        }

        // GET: Korisniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipDijabetesa,Visina,Tezina,FizickaAktivnost,VrijednostHiperglikemije,VrijednostHipoglikemije,CiljaniNivoGlukoze,DonjaGranicaGlukoze,GornjaGranicaGlukoze,Tip,Lijekovi,DozaLijeka,Spol,Ime,Prezime,Username,Password,PotvrdaPassworda,EMail,JMBG1,Spol1,DatumRodjenja")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korisnik);
        }

        // GET: Korisniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            db.Korisnik.Remove(korisnik);
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
