using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ITalksRepository
    {
        List<Talks> GetAllTalks();
        Talks GetTalksById(int id);
        Talks Update(Talks talksToUpdate);
        Talks Add(Talks talksToAdd);
        void Delete(Talks talksToDelete);

    }
    public class TalksRepository:ITalksRepository
    {
        private readonly ConferenceContext conferenceContext;

        public TalksRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }

        public List<Talks> GetAllTalks()
        {
            return conferenceContext.Talks.ToList();
        }
        public Talks GetTalksById(int id)
        {
            return conferenceContext.Talks.Find(id);
        }

        public Talks Update(Talks talksToUpdate)
        {
            var updatedEntity = conferenceContext.Talks.Update(talksToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }

        public Talks Add(Talks talksToAdd)
        {
            var addEntity = conferenceContext.Talks.Add(talksToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(Talks talksToDelete)
        {
            conferenceContext.Talks.Remove(talksToDelete);
            conferenceContext.SaveChanges();
            
        }
    }
}
