using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IWorkshopRepository
    {
        List<Workshops> GetAllWorkshops();
        Workshops GetWorkshopById(int id);
        Workshops Update(Workshops workshopToUpdate);
        Workshops Add(Workshops workshopToAdd);
        void Delete(Workshops workshopToDelete);
    }
    public class WorkshopRepository:IWorkshopRepository
    {
        private readonly ConferenceContext conferenceContext;

        public WorkshopRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }

        public List<Workshops> GetAllWorkshops()
        {
            return conferenceContext.Workshops.ToList();
        }

        public Workshops GetWorkshopById(int id)
        {
            return conferenceContext.Workshops.Find(id);
        }
        public Workshops Update(Workshops workshopToUpdate)
        {
            var updatedEntity = conferenceContext.Workshops.Update(workshopToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }

        public Workshops Add(Workshops workshopToAdd)
        {
            var addEntity = conferenceContext.Workshops.Add(workshopToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(Workshops workshopToDelete)
        {
           
            conferenceContext.Workshops.Remove(workshopToDelete);
            conferenceContext.SaveChanges();
        }
    }
}
