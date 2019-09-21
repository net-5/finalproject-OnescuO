using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorsRepository
    {
        List<Sponsors> GetAllSponsors();
        Sponsors GetSponsorsById(int id);
        Sponsors Update(Sponsors sponsorToUpdate);
        Sponsors Add(Sponsors sponsorToAdd);
        void Delete(Sponsors sponsorToDelete);
    }
    public class SponsorsRepository:ISponsorsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SponsorsRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }

        public List<Sponsors> GetAllSponsors()
        {
            return conferenceContext.Sponsors.ToList();
        }

        public Sponsors GetSponsorsById(int id)
        {
            return conferenceContext.Sponsors.Find(id);
        }

        public Sponsors Update(Sponsors sponsorToUpdate)
        {
            var updateEntity = conferenceContext.Sponsors.Update(sponsorToUpdate);
            conferenceContext.SaveChanges();
            return updateEntity.Entity;
        }
        public Sponsors Add(Sponsors sponsorToAdd)
        {
            var addEntity = conferenceContext.Sponsors.Add(sponsorToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(Sponsors sponsorToDelete)
        {
           
            conferenceContext.Sponsors.Remove(sponsorToDelete);
            conferenceContext.SaveChanges();
            
        }
    }
}
