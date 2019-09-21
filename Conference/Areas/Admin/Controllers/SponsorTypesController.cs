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
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypesServices sponsorTypesServices;

        public SponsorTypesController(ISponsorTypesServices sponsorTypesServices)
        {
            this.sponsorTypesServices = sponsorTypesServices;
        }

        // GET: SponsorTypes
        public ActionResult Index()
        {
            var allSponsorTypes = sponsorTypesServices.GetAllSponsorTypes();
            return View(allSponsorTypes);
        }

        // GET: SponsorTypes/Details/5
        public ActionResult Details(int id)
        {
            SponsorTypes sponsorTypes = sponsorTypesServices.FindSponsorTypesById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsorTypes);
            return View(sponsorTypes);
        }

        // GET: SponsorTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorTypesViewModel model)
        {
            if (ModelState.IsValid)
            {
                SponsorTypes sponsorTypesToAdd = new SponsorTypes();
                sponsorTypesToAdd.InjectFrom(model);
                var addedSponsorT = sponsorTypesServices.AddSponsorTypes(sponsorTypesToAdd);
                if (addedSponsorT == null)
                {
                    ModelState.AddModelError("Name", "The sponsor type name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsorT = sponsorTypesServices.FindSponsorTypesById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsorT);

            return View(model);
        }

        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypesViewModel model)
        {
            SponsorTypes sponsorType = new SponsorTypes();
            sponsorType.InjectFrom(model);
            var sponsorTypeToUpdate = sponsorTypesServices.UpdateSponsorTypes(sponsorType);
            return RedirectToAction(nameof(Index));
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SponsorTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypesViewModel model)
        {
            SponsorTypes deleteSponsorT = new SponsorTypes();

            deleteSponsorT = sponsorTypesServices.FindSponsorTypesById(id);
            model.InjectFrom(deleteSponsorT);

            sponsorTypesServices.DeleteSponsorTypes(deleteSponsorT);

            return RedirectToAction(nameof(Index));
        }
    }
}