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
    public class TalksController : Controller
    {
        private readonly ITalksServices talksServices;

        public TalksController(ITalksServices talksServices)
        {
            this.talksServices = talksServices;
        }
        // GET: Talks
        public ActionResult Index()
        {
            var allTalks = talksServices.GetAllTalks();
            return View(allTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalksViewModel model)
        {
            if (ModelState.IsValid)
            {
                Talks talksToAdd = new Talks();
                talksToAdd.InjectFrom(model);
                var addedTalks = talksServices.AddTalks(talksToAdd);
                if (addedTalks == null)
                {
                    ModelState.AddModelError("Companyname", "The company name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            var talks = talksServices.FindTalksById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talks);

            return View();
        }

        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TalksViewModel model)
        {
            if (ModelState.IsValid)
            {

                var existingTalks = talksServices.FindTalksById(id);

                TryUpdateModelAsync(existingTalks);
                talksServices.UpdateTalks(existingTalks);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalksViewModel model)
        {
            Talks deleteTalks = new Talks();

            deleteTalks = talksServices.FindTalksById(id);

            model.InjectFrom(deleteTalks);

            talksServices.DeleteTalks(deleteTalks);

            return RedirectToAction(nameof(Index));
        }
    }
}