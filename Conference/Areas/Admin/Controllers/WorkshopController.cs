using System;
using System.Collections.Generic;
using System.Data;
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
    public class WorkshopController : Controller
    {
        private readonly IWorkshopServices workshopServices;

        public WorkshopController(IWorkshopServices workshopServices)
        {
            this.workshopServices = workshopServices;
        }

        public ActionResult Index()
        {
            var allWorkshops = workshopServices.GetAllWorkshops();
            return View(allWorkshops);
        }

        // GET: Workshops/Details/5
        public ActionResult Details(int id)
        {
            Workshops workshops = workshopServices.FindWorkshopById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(workshops);
            return View(workshops);
        }

        // GET: Workshops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkshopViewModel model)
        {
            if (ModelState.IsValid)
            {
                Workshops workshopToAdd = new Workshops();
                workshopToAdd.InjectFrom(model);
                var addedWorkshop = workshopServices.AddWorkshop(workshopToAdd);
                if (addedWorkshop == null)
                {
                    ModelState.AddModelError("Name", "Workshop name must be unique!");
                    return View(model);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                return View(model);
            }
        }

        // GET: Workshops/Edit/5
        public ActionResult Edit(int id)
        {
            var workshop = workshopServices.FindWorkshopById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(workshop);
            return View(model);
        }

        // POST: Workshops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkshopViewModel model)
        {
            Workshops workshop = new Workshops();
            workshop.InjectFrom(model);
            var workshopToUpdate = workshopServices.UpdateWorkshop(workshop);
            return RedirectToAction(nameof(Index));
        }

        // GET: Workshops/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: Workshops/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopViewModel model)
        {
            Workshops deleteWorkshop = new Workshops();

            deleteWorkshop = workshopServices.FindWorkshopById(id);

            model.InjectFrom(deleteWorkshop);

            workshopServices.DeleteWorkshop(deleteWorkshop);

            return RedirectToAction(nameof(Index));
        }
    }
}