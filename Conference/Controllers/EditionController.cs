using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class EditionController : Controller
    {
        private readonly IEditionServices editionServices;

        public EditionController(IEditionServices editionServices)
        {
            this.editionServices = editionServices;
        }

        // GET: Edition
        public ActionResult Index()
        {
            var allEditions = editionServices.GetAllEditions();
            return View(allEditions);
        }

        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Edition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Editions editionToAdd = new Editions();
                editionToAdd.InjectFrom(model);
                var addedEdition = editionServices.AddEdition(editionToAdd);
                if (addedEdition == null)
                {
                    ModelState.AddModelError("Name", "The edition name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Edition/Edit/5
        public ActionResult Edit(int id)
        {
            var edition = editionServices.FindEditionById(id);
            EditionsViewModel model = new EditionsViewModel();
            model.InjectFrom(edition);
            return View(edition);
        }

        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                var existingEdition = editionServices.FindEditionById(id);
             
                TryUpdateModelAsync(existingEdition);
                editionServices.UpdateEdition(existingEdition);
                return RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }

        // GET: Edition/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Edition/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionsViewModel model)
        {
            Editions deleteEdition = new Editions();

            deleteEdition = editionServices.FindEditionById(id);

            model.InjectFrom(deleteEdition);

            editionServices.DeleteEdition(deleteEdition);

            return RedirectToAction(nameof(Index));
        }
    }
}