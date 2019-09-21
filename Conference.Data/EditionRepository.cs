using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IEditionRepository
    {
        List<Editions> GetAllEditions();
        Editions GetEditionById(int id);
        Editions Update(Editions editionToUpdate);
        Editions Add(Editions editionToAdd);
        void Delete(Editions editionToDelete);
        
    }
    public class EditionRepository:IEditionRepository
    {
        private readonly ConferenceContext conferenceContext;

        public EditionRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }

        public List<Editions> GetAllEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions GetEditionById(int id)
        {
            return conferenceContext.Editions.Find(id);
        }

        public Editions Update(Editions editionToUpdate)
        {
            var updatedEntity = conferenceContext.Editions.Update(editionToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }

        public Editions Add(Editions editionToAdd)
        {
            var addEntity = conferenceContext.Editions.Add(editionToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(Editions editionToDelete)
        {
    
            conferenceContext.Editions.Remove(editionToDelete);
            conferenceContext.SaveChanges();

        }
        
    }
}
