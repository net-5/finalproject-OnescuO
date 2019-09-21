using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISponsorTypesServices
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes FindSponsorTypesById(int id);
        SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypesToUpdate);
        SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypesToAdd);
        void DeleteSponsorTypes(SponsorTypes sponsorTypesToDelete);
    }
    public class SponsorTypesServices:ISponsorTypesServices
    {
        private readonly ISponsorTypesRepository sponsorTypesRepository;

        public SponsorTypesServices(ISponsorTypesRepository sponsorTypesRepository)
        {
            this.sponsorTypesRepository = sponsorTypesRepository;
        }
        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return sponsorTypesRepository.GetAllSponsorTypes();
        }
        public SponsorTypes FindSponsorTypesById(int id)
        {
            var mySponsorTypes=sponsorTypesRepository.GetSponsorTypesById(id);
            if(mySponsorTypes != null)
            {
                return mySponsorTypes;
            }
            return null;
        }
        public SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypesToUpdate)
        {
            return sponsorTypesRepository.Update(sponsorTypesToUpdate);
        }
        public SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypesToAdd)
        {
            return sponsorTypesRepository.Add(sponsorTypesToAdd);
        }
        public void DeleteSponsorTypes(SponsorTypes sponsorTypesToDelete)
        {
            sponsorTypesRepository.Delete(sponsorTypesToDelete);
        }
    }
}
