using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_EA.Models;

namespace Project_EA.Controllers
{
    public class BrokerInformationsController : Controller
    {
        private BrokerInformationDBContext db = new BrokerInformationDBContext();

        // GET: BrokerInformations
        public ActionResult Index(string searchString)
        {
            var firstName = from fn in db.BrokerInformations
                         select fn;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                firstName = firstName.Where(s => s.FirstName.Contains(searchString));
            }
            
            return View(firstName);
        }

        // GET: BrokerInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerInformation brokerInformation = db.BrokerInformations.Find(id);
            if (brokerInformation == null)
            {
                return HttpNotFound();
            }
            return View(brokerInformation);
        }

        // GET: BrokerInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrokerInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,DOILicenseNumber,Address1,Address2,City,State,Zip,PhoneNumber,FaxNumber,EmailAddress,AgencyName,NameOfGeneralAgent,Payee,PayeeTaxId,SsnTin,BrokerCommissionSplitPercent,IsProducerAppointed,ProducerTitle")] BrokerInformation brokerInformation)
        {
            if (ModelState.IsValid)
            {
                db.BrokerInformations.Add(brokerInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brokerInformation);
        }

        // GET: BrokerInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerInformation brokerInformation = db.BrokerInformations.Find(id);
            if (brokerInformation == null)
            {
                return HttpNotFound();
            }
            return View(brokerInformation);
        }

        // POST: BrokerInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,DOILicenseNumber,Address1,Address2,City,State,Zip,PhoneNumber,FaxNumber,EmailAddress,AgencyName,NameOfGeneralAgent,Payee,PayeeTaxId,SsnTin,BrokerCommissionSplitPercent,IsProducerAppointed,ProducerTitle")] BrokerInformation brokerInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brokerInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brokerInformation);
        }

        // GET: BrokerInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerInformation brokerInformation = db.BrokerInformations.Find(id);
            if (brokerInformation == null)
            {
                return HttpNotFound();
            }
            return View(brokerInformation);
        }

        // POST: BrokerInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BrokerInformation brokerInformation = db.BrokerInformations.Find(id);
            db.BrokerInformations.Remove(brokerInformation);
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
