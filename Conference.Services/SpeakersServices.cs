
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISpeakersServices
    {
        IEnumerable<Speakers> GetAllSpeakers();
        Speakers FindSpeakersById(int id);
        Speakers UpdateSpeakers(Speakers speakersToUpdate);
        Speakers AddSpeakers(Speakers speakersToAdd);
        void DeleteSpeakers(Speakers speakers);

    }
    public class SpeakersServices:ISpeakersServices
    {
        private readonly ISpeakersRepository speakersRepository;

        public SpeakersServices(ISpeakersRepository speakersRepository)
        {
            this.speakersRepository = speakersRepository;
        }
        public IEnumerable<Speakers> GetAllSpeakers()
        {
            return speakersRepository.GetAllSpeakers();
        }

        public Speakers FindSpeakersById(int id)
        {
            var mySpeakers = speakersRepository.GetSpeakersById(id);
            if(mySpeakers != null)
            {
                return mySpeakers;
            }
            return null;
        }

        public Speakers UpdateSpeakers(Speakers speakersToUpdate)
        {
            return speakersRepository.Update(speakersToUpdate);
        }

        public Speakers AddSpeakers(Speakers speakersToAdd)
        {
            return speakersRepository.Add(speakersToAdd);
        }

        public void DeleteSpeakers(Speakers speakers)
        {
            speakersRepository.Delete(speakers);

        }
    }
}
