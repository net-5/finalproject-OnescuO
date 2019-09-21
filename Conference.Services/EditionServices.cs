using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface IEditionServices
    {
        IEnumerable<Editions> GetAllEditions();
        Editions FindEditionById(int id);
        Editions UpdateEdition(Editions editionToUpdate);
        Editions AddEdition(Editions editionToAdd);
        void DeleteEdition(Editions editions);
        
    }
    public class EditionServices:IEditionServices
    {
        private readonly IEditionRepository editionRepository;

        public EditionServices(IEditionRepository editionRepository)
        {
            this.editionRepository = editionRepository;
        }

        public IEnumerable<Editions> GetAllEditions()
        {
            return editionRepository.GetAllEditions();
        }

        public Editions FindEditionById(int id)
        {
            var myEdition = editionRepository.GetEditionById(id);
            return myEdition;
        }

        public Editions UpdateEdition(Editions editionToUpdate)
        {
            return editionRepository.Update(editionToUpdate);
        }

        public Editions AddEdition(Editions editionToAdd)
        {
            return editionRepository.Add(editionToAdd);
        }
        public void DeleteEdition(Editions editions)
        {
           editionRepository.Delete(editions);

        }
        
    }
}
