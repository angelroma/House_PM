using House_PM.Business;
using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace House_PM.Controllers
{
    [Authorize(Roles = "admin, doctor")]
    public class PatientsController : Controller
    {
        PatientService service;

        //Dependency injection
        public PatientsController() : this(new PatientService()) { }
        public PatientsController(PatientService service) => this.service = service;

        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient entity)
        {
            service.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Patient patient = service.GetById(id);
            return View(patient);
        }

        [HttpPost]
        public ActionResult Edit(Patient entity)
        {
            service.Update(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(Patient entity)
        {
            var id = service.GetById(entity.Id);
            return View(id);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Patient entity = service.GetById(id);
            return View(entity);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}