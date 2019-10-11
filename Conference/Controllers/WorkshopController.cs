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
    public class WorkshopController : Controller
    {
        private readonly IWorkshopServices workshopService;

        public WorkshopController(IWorkshopServices workshopService)
        {
            this.workshopService = workshopService;
        }
        // GET: Workshop
        public ActionResult Index()
        {
            var allWorkshops = workshopService.GetAllWorkshops();
            return View(allWorkshops);
            
        }

        // GET: Workshop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Workshop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkshopsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Workshops workshopToAdd = new Workshops();
                workshopToAdd.InjectFrom(model);
                var addedWorkshop = workshopService.AddWorkshop(workshopToAdd);
                if (addedWorkshop == null)
                {
                    ModelState.AddModelError("Name", "The workshop name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Workshop/Edit/5
        public ActionResult Edit(int id)
        {
            var workshop = workshopService.FindWorkshopById(id);
            WorkshopsViewModel model = new WorkshopsViewModel();
            model.InjectFrom(workshop);
            return View(model);
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkshopsViewModel model)
        {
            if (ModelState.IsValid)
            {

                var existingWorkshop = workshopService.FindWorkshopById(id);

                TryUpdateModelAsync(existingWorkshop);
                workshopService.UpdateWorkshop(existingWorkshop);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Workshop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Workshop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopsViewModel model)
        {
            Workshops deleteWorkshop = new Workshops();

            deleteWorkshop = workshopService.FindWorkshopById(id);

            model.InjectFrom(deleteWorkshop);

            workshopService.DeleteWorkshop(deleteWorkshop);

            return RedirectToAction(nameof(Index));
        }
    }
}