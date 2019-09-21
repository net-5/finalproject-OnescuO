using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View();
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Workshop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}