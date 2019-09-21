using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ITalksServices
    {
        IEnumerable<Talks> GetAllTalks();
        Talks FindTalksById(int id);
        Talks UpdateTalks(Talks talksToUpdate);
        Talks AddTalks(Talks talksToAdd);
        void DeleteTalks(Talks talks);
    }
    public class TalksServices:ITalksServices
    {
        private readonly ITalksRepository talksRepository;

        public TalksServices(ITalksRepository talksRepository)
        {
            this.talksRepository = talksRepository;
        }

        public IEnumerable<Talks> GetAllTalks()
        {
            return talksRepository.GetAllTalks();
        }

        public Talks FindTalksById(int id)
        {
            var myTalks = talksRepository.GetTalksById(id);
            if (myTalks != null)
            {
                return myTalks;
            }
            return null;
        }

        public Talks UpdateTalks(Talks talksToUpdate)
        {
            return talksRepository.Update(talksToUpdate);
        }

        public Talks AddTalks(Talks talksToAdd)
        {
            return talksRepository.Add(talksToAdd);
        }
        public void DeleteTalks(Talks talks)
        {
            talksRepository.Delete(talks);

        }
    }
}
