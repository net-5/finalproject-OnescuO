using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypesRepository
    {
        List<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypesById(int id);
        SponsorTypes Update(SponsorTypes sponsorTypesToUpdate);
        SponsorTypes Add(SponsorTypes sponsorTypesToAdd);
        void Delete(SponsorTypes sponsorTypesToDelete);
    }
    public class SponsorTypesRepository:ISponsorTypesRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SponsorTypesRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }
        public List<SponsorTypes> GetAllSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }
        public SponsorTypes GetSponsorTypesById(int id)
        {
            return conferenceContext.SponsorTypes.Find(id);
        }
        public SponsorTypes Update(SponsorTypes sponsorTypesToUpdate)
        {
            var updateEntity = conferenceContext.SponsorTypes.Update(sponsorTypesToUpdate);
            conferenceContext.SaveChanges();
            return updateEntity.Entity;
        }
        public SponsorTypes Add(SponsorTypes sponsorTypesToAdd)
        {
            var addEntity = conferenceContext.SponsorTypes.Add(sponsorTypesToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(SponsorTypes sponsorTypesToDelete)
        {
            
            conferenceContext.SponsorTypes.Remove(sponsorTypesToDelete);
            conferenceContext.SaveChanges();
        }
    }
}
