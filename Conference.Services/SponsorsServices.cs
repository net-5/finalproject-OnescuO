using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISponsorsServices
    {
        IEnumerable<Sponsors> GetAllSponsors();
        Sponsors FindSponsorById(int id);
        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);
        Sponsors AddSponsor(Sponsors sponsorToAdd);
        void DeleteSponsor(Sponsors sponsorToDelete);
    }
    public class SponsorsServices:ISponsorsServices
    {
        private readonly ISponsorsRepository sponsorsRepository;

        public SponsorsServices(ISponsorsRepository sponsorsRepository)
        {
            this.sponsorsRepository = sponsorsRepository;
        }

        public IEnumerable<Sponsors> GetAllSponsors()
        {
            return sponsorsRepository.GetAllSponsors();
        }
        public Sponsors FindSponsorById(int id)
        {
            var mySponsor = sponsorsRepository.GetSponsorsById(id);
            if(mySponsor != null)
            {
                return mySponsor;
            }
            return null;
        }
        public Sponsors UpdateSponsor(Sponsors sponsorToUpdate)
        {
            return sponsorsRepository.Update(sponsorToUpdate);
        }
        public Sponsors AddSponsor(Sponsors sponsorToAdd)
        {
            return sponsorsRepository.Add(sponsorToAdd);
        }
        public void DeleteSponsor(Sponsors sponsorToDelete)
        {
            sponsorsRepository.Delete(sponsorToDelete);
        }
    }
}
