using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISpeakersRepository
    {
        List<Speakers> GetAllSpeakers();
        Speakers GetSpeakersById(int id);
        Speakers Update(Speakers speakersToUpdate);
        Speakers Add(Speakers speakersToAdd);
        void Delete(Speakers speakersToDelete);
    }
    public class SpeakersRepository:ISpeakersRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SpeakersRepository(ConferenceContext conference)
        {
            conferenceContext = conference;
        }

        public List<Speakers> GetAllSpeakers()
        {
            return conferenceContext.Speakers.ToList();
        }

        public Speakers GetSpeakersById(int id)
        {
            return conferenceContext.Speakers.Find(id);
        }

        public Speakers Update(Speakers speakersToUpdate)
        {
            var updatedEntity = conferenceContext.Speakers.Update(speakersToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }

        public Speakers Add(Speakers speakersToAdd)
        {
            var addEntity = conferenceContext.Speakers.Add(speakersToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public void Delete(Speakers speakersToDelete)
        {
            var deletedEntity = conferenceContext.Speakers.Remove(speakersToDelete);
            conferenceContext.SaveChanges();
            
        }
    }
}
