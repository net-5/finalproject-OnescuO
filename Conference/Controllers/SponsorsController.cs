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
    public class SponsorsController : Controller
    {
        private readonly ISponsorsServices sponsorsServices;

        public SponsorsController(ISponsorsServices sponsorsServices)
        {
            this.sponsorsServices = sponsorsServices;
        }
        // GET: Sponsors
        public ActionResult Index()
        {
            var allSponsors = sponsorsServices.GetAllSponsors();
            return View(allSponsors);
        }

        // GET: Sponsors/Details/5
        public ActionResult Details(int id)
        {
            Sponsors sponsor = sponsorsServices.FindSponsorById(id);
            SponsorsViewModel model = new SponsorsViewModel();
            model.InjectFrom(sponsor);
            return View(sponsor);
        }

        // GET: Sponsors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors sponsorToAdd = new Sponsors();
                sponsorToAdd.InjectFrom(model);
                var addedSponsor = sponsorsServices.AddSponsor(sponsorToAdd);
                if (addedSponsor == null)
                {
                    ModelState.AddModelError("Name", "The sponsor name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsor = sponsorsServices.FindSponsorById(id);
            SponsorsViewModel model = new SponsorsViewModel();
            model.InjectFrom(sponsor);
            return View(model);
        }

        // POST: Sponsors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,SponsorsViewModel model)
        {
            Sponsors sponsors = new Sponsors();
            sponsors.InjectFrom(model);
            var sponsorToUpdate = sponsorsServices.UpdateSponsor(sponsors);
            return RedirectToAction(nameof(Index));
        }

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sponsors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorsViewModel model)
        {
            Sponsors deleteSponsor = new Sponsors();

            deleteSponsor = sponsorsServices.FindSponsorById(id);
            model.InjectFrom(deleteSponsor);

            sponsorsServices.DeleteSponsor(deleteSponsor);

            return RedirectToAction(nameof(Index));
        }
    }
}