using House_MD.Business;
using House_PM.Business;
using House_PM.Models;
using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace House_PM.Controllers
{
    public class RecipesController : Controller
    {
        RecipeService service;
        
        //Dependency injection for recipes
        public RecipesController() : this(new RecipeService()) { }
        public RecipesController(RecipeService service) => this.service = service;

        // GET: Recipes
        public ActionResult Index(int id)
        {
            //Request id and save it a session browser navigation to be able to use in Razor view.
            Session["CurrentData"] = id;
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
        public ActionResult Create(Recipe entity)
        {
            if (ModelState.IsValid)
            {
                service.Create(entity);
                //Return to the current Patient->Recipe view.
                return RedirectToAction("index", new { id = entity.Id_Patient });
            }
            ViewBag.Id_Patient = new SelectList(service.GetAllList().Where(c => c.Id == entity.Id), "Id", "Name", entity.Id_Patient);
            return View(entity);

        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int? id)
        {
            Recipe entity = service.GetById(id);
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
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedOn,Treatment,Medicament,Id_Patient")] Recipe entity)
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
        public ActionResult Details(Recipe entity)
        {
            var id = service.GetById(entity.Id);
            return View(id);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Recipe entity = service.GetById(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        //I should be using an int for Delete
        [HttpPost]
        public ActionResult Delete(Recipe entity)
        {
            Recipe local = service.GetById(entity.Id);
            if (service.Delete(local))
            {
                //Redirect to recipe view index of a patient incluiding parameters
                return RedirectToAction("index", new { id = local.Id_Patient });
            }
            else
            {
                return View();
            }
        }
    }
}