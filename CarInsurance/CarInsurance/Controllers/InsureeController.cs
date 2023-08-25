﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Qoute")] Insuree insuree)
        {
            
            if (ModelState.IsValid)
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var signup = new Insuree();
                    signup.FirstName = insuree.FirstName;
                    signup.CarMake = insuree.CarMake;
                    signup.CarModel = insuree.CarModel;
                    signup.LastName = insuree.LastName;
                    signup.EmailAddress = insuree.EmailAddress;
                    signup.DateOfBirth = insuree.DateOfBirth;
                    signup.CarYear = insuree.CarYear;
                    signup.SpeedingTickets = insuree.SpeedingTickets;
                    signup.DUI = insuree.DUI;
                    signup.CoverageType = insuree.CoverageType;
                    signup.Qoute = insuree.Qoute;


                    var qoute = 50;
                    var today = DateTime.Today;
                    var age = today.Year - signup.DateOfBirth.Year;
                    if (age <= 18)
                    {
                        signup.Qoute += 50 + qoute;
                    }
                    else if (age == 19 || age == 20 || age == 21 || age == 22 || age == 23 || age == 24 || age == 25 )  
                    {
                        signup.Qoute += 50 + qoute;

                    }
                    else if (age >= 26)
                    {
                        signup.Qoute += 25 + qoute;
                    }

                    if (signup.CarYear < 2000 || signup.CarYear > 2015)
                    {
                        signup.Qoute += 25;
                    }


                    if (signup.CarMake == "Porsche")
                    {
                        signup.Qoute += 25;
                    }

                    if (signup.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                    {
                        signup.Qoute += 25;
                    }
                    
                    if (signup.SpeedingTickets > 0)
                    {
                        signup.Qoute += signup.SpeedingTickets * 10;
                    }

                    if (signup.DUI == true)
                    {
                        signup.Qoute += signup.Qoute * 25 / 100;
                    }

                    if (signup.CoverageType == true)
                    {
                        signup.Qoute += signup.Qoute * 50 / 100;
                    }
                 
                    db.Insurees.Add(signup);
                    db.SaveChanges();

                    

                }
                return RedirectToAction("Index");
            }

            return View("Qoute", insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Qoute")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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


