using House_MD.Business;
using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace House_PM.Controllers
{
    public class VitalsController : Controller
    {
        VitalService service;

        //Dependency injection for vitals
        public VitalsController() : this(new VitalService()) { }
        public VitalsController(VitalService service) => this.service = service;

        // GET: Vitals
        public ActionResult Index(int id)
        {
            //Request id and save it a session browser navigation to be able to use in Razor view.
            Session["CurrentID"] = id;
            //Return a view with all my entity elements that match Id_Patient
            return View(service.GetAll(id));
        }

        [HttpGet]
        public ActionResult Create(int id)
        {
            //Require a all rows and select where c.Id == id to pass into dropdown html element.
            ViewBag.Id_Patient = new SelectList(service.GetAllList().Where(c => c.Id == id), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Vital entity)
        {
            if (ModelState.IsValid)
            {
                service.Create(entity);
                //Return to the current Patient->vitals view.
                return RedirectToAction("index", new { id = entity.Id_Patient });
            }
            ViewBag.Id_Patient = new SelectList(service.GetAllList().Where(c => c.Id == entity.Id), "Id", "Name", entity.Id_Patient);
            return View(entity);

        }

        public ActionResult Edit(int id)
        {
            Vital entity = service.GetById(id);
            if (entity == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (entity == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Patient = new SelectList(service.GetAllList().Where(c => c.Id == id), "Id", "Name", entity.Id_Patient);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Vital entity)
        {
            if (ModelState.IsValid)
            {
                service.Update(entity);
                return RedirectToAction("index", new { id = entity.Id_Patient });
            }
            ViewBag.Id_Patient = new SelectList(service.GetAllList().Where(c => c.Id == entity.Id), "Id", "Name", entity.Id_Patient);
            return View(entity);
        }

        [HttpGet]
        public ActionResult Details(Vital entity)
        {
            var id = service.GetById(entity.Id);
            return View(id);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Vital entity = service.GetById(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        //I should be using an int for Delete
        [HttpPost]
        public ActionResult Delete(Vital entity)
        {
            Vital local = service.GetById(entity.Id);
            if (service.Delete(local))
            {
                //Redirect to vital view index of a patient incluiding parameters
                return RedirectToAction("index", new { id = local.Id_Patient });
            }
            else
            {
                return View();
            }
        }

    }
}