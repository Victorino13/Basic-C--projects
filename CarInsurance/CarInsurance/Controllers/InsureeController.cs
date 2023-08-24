using System;
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
            var signup = new Insuree();
            signup.FirstName = insuree.FirstName;
            signup.LastName = insuree.LastName;
            signup.EmailAddress = insuree.EmailAddress;
            signup.DateOfBirth = insuree.DateOfBirth;
            signup.CarYear = insuree.CarYear;
            signup.SpeedingTickets = insuree.SpeedingTickets;
            signup.DUI = insuree.DUI;
            signup.CoverageType = insuree.CoverageType;
            var total = 50;
            signup.Qoute = total;

            var today = DateTime.Today;
            var age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-25))
            {
                insuree.Qoute = total + 25;
            }
            else if (insuree.DateOfBirth > today.AddYears(-18))
            {
                insuree.Qoute = total + 100;

            }
            else if (insuree.DateOfBirth > today.AddYears(-100))
            {
                insuree.Qoute = total + 25;
            }


            if (insuree.CarYear < 2000)
            {
                insuree.Qoute = total + 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Qoute = total + 25;
            }

            if (insuree.CarMake == "Porsche")
            {
                insuree.Qoute = total + 25;
            }

            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                insuree.Qoute = total + 25;
            }
            //    foreach (var ticket in speedingtickets)
            //{

            //}
            if (insuree.SpeedingTickets > 0)
            {
                insuree.Qoute = total + (insuree.SpeedingTickets * 10);
            }



            if (insuree.DUI == true)
            {
                insuree.Qoute = total + (insuree.Qoute * 25 / 100);
            }
            else
            {
                insuree.Qoute = total + 0;
            }



            if (insuree.CoverageType == true)
            {
                insuree.Qoute = total + (insuree.Qoute * 50 / 100);
            }
            else
            {
                insuree.Qoute = total + 0;
            }


            signup.Qoute = total;

            db.Insurees.Add(signup);
            db.SaveChanges();

            @ViewBag.Total = insuree.Qoute;



            //return View("Qoute");

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
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

        //public ActionResult Qoute([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Qoute")] Insuree insuree)
        //{
        //    using (InsuranceEntities db = new InsuranceEntities())
        //    {
        //        var signup = new Insuree();
        //        signup.FirstName = insuree.FirstName;
        //        signup.LastName = insuree.LastName;
        //        signup.EmailAddress = insuree.EmailAddress;
        //        signup.DateOfBirth = insuree.DateOfBirth;
        //        signup.CarYear = insuree.CarYear;
        //        signup.SpeedingTickets = insuree.SpeedingTickets;
        //        signup.DUI = insuree.DUI;
        //        signup.CoverageType = insuree.CoverageType;
        //        var total = 50;
        //        signup.Qoute = total;

        //        var today = DateTime.Today;
        //        var age = today.Year - insuree.DateOfBirth.Year;
        //        if (insuree.DateOfBirth > today.AddYears(-25))
        //        {
        //            insuree.Qoute = total + 25;
        //        }
        //        else if (insuree.DateOfBirth > today.AddYears(-18))
        //        {
        //            insuree.Qoute = total + 100;

        //        }
        //        else if (insuree.DateOfBirth > today.AddYears(-100))
        //        {
        //            insuree.Qoute = total + 25;
        //        }


        //        if (insuree.CarYear < 2000)
        //        {
        //            insuree.Qoute = total + 25;
        //        }
        //        else if (insuree.CarYear > 2015)
        //        {
        //            insuree.Qoute = total + 25;
        //        }

        //        if (insuree.CarMake == "Porsche")
        //        {
        //            insuree.Qoute = total + 25;
        //        }

        //        if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
        //        {
        //            insuree.Qoute = total + 25;
        //        }
        //        //    foreach (var ticket in speedingtickets)
        //        //{

        //        //}
        //        if (insuree.SpeedingTickets > 0)
        //        {
        //            insuree.Qoute = total + (insuree.SpeedingTickets * 10);
        //        }



        //        if (insuree.DUI == true)
        //        {
        //            insuree.Qoute = total + (insuree.Qoute * 25 / 100);
        //        }
        //        else
        //        {
        //            insuree.Qoute = total + 0;
        //        }



        //        if (insuree.CoverageType == true)
        //        {
        //            insuree.Qoute = total + (insuree.Qoute * 50 / 100);
        //        }
        //        else
        //        {
        //            insuree.Qoute = total + 0;
        //        }


        //        signup.Qoute = total;

        //        db.Insurees.Add(signup);
        //        db.SaveChanges();

        //        @ViewBag.Total = insuree.Qoute;



        //        return View("Qoute");

        //    }

        //}
    }
}


