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
    public class SpeakersController : Controller
    {
        private readonly ISpeakersServices speakersServices;

        public SpeakersController(ISpeakersServices speakersServices)
        {
            this.speakersServices = speakersServices;
        }
        // GET: Speakers
        public ActionResult Index()
        {
            var allSpeakers = speakersServices.GetAllSpeakers();
            return View(allSpeakers);
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            Speakers speakers = speakersServices.FindSpeakersById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(speakers);
            return View(speakers);
        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Speakers speakersToAdd = new Speakers();
                speakersToAdd.InjectFrom(model);
                
                var addedSpeakers = speakersServices.AddSpeakers(speakersToAdd);
                if (addedSpeakers == null)
                {
                    ModelState.AddModelError("Companyname", "The company name must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var speakers = speakersServices.FindSpeakersById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(speakers);

            return View();
        }

        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakerViewModel model)
        {
            Speakers speakers = new Speakers();
            speakers.InjectFrom(model);
            var sponsorToUpdate = speakersServices.UpdateSpeakers(speakers);
            return RedirectToAction(nameof(Index));
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakerViewModel model)
        {
            Speakers deleteSpeakers = new Speakers();

            deleteSpeakers = speakersServices.FindSpeakersById(id);

            model.InjectFrom(deleteSpeakers);

            speakersServices.DeleteSpeakers(deleteSpeakers);

            return RedirectToAction(nameof(Index));
        }
    }
}