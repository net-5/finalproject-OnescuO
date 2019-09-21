using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Services;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            Editions editions = editionServices.FindEditionById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(editions);
            return View(editions);
        }

        // GET: Edition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionViewModel model)
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
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(edition);
            return View(model);
        }

        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionViewModel model)
        {
            Editions edit = new Editions();
            edit.InjectFrom(model);
            var createNewEdition = editionServices.UpdateEdition(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Edition/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Edition/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionViewModel model)
        {
            Editions deleteEdition = new Editions();

            deleteEdition = editionServices.FindEditionById(id);

            model.InjectFrom(deleteEdition);

            editionServices.DeleteEdition(deleteEdition);

            return RedirectToAction(nameof(Index));
        }
    }
}