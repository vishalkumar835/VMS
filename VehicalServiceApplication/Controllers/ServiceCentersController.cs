using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicalServiceApplication;

namespace VehicalServiceApplication.Controllers
{
    [Authorize]  //attribute filter authorize
    public class ServiceCentersController : Controller
    {
        private VehicleCenterEntities db = new VehicleCenterEntities();

        // GET: ServiceCenters
        public ActionResult Index()
        {
            return View(db.ServiceCenters.ToList());
        }

        // GET: ServiceCenters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCenter serviceCenter = db.ServiceCenters.Find(id);
            if (serviceCenter == null)
            {
                return HttpNotFound();
            }
            return View(serviceCenter);
        }

        // GET: ServiceCenters/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceCenterId,ServiceCenterName,AppoinmentBookingDate,VehicleType,VehicleModel")] ServiceCenter serviceCenter)
        {
            if (ModelState.IsValid)
            {
                db.ServiceCenters.Add(serviceCenter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceCenter);
        }

        // GET: ServiceCenters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCenter serviceCenter = db.ServiceCenters.Find(id);
            if (serviceCenter == null)
            {
                return HttpNotFound();
            }
            return View(serviceCenter);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceCenterId,ServiceCenterName,AppoinmentBookingDate,VehicleType,VehicleModel")] ServiceCenter serviceCenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceCenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceCenter);
        }

        // GET: ServiceCenters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCenter serviceCenter = db.ServiceCenters.Find(id);
            if (serviceCenter == null)
            {
                return HttpNotFound();
            }
            return View(serviceCenter);
        }

        // POST: ServiceCenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceCenter serviceCenter = db.ServiceCenters.Find(id);
            db.ServiceCenters.Remove(serviceCenter);
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
