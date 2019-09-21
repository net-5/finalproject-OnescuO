using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface IWorkshopServices
    {
        IEnumerable<Workshops> GetAllWorkshops();
        Workshops FindWorkshopById(int id);
        Workshops UpdateWorkshop(Workshops workshopToUpdate);
        Workshops AddWorkshop(Workshops workshopToAdd);
        void DeleteWorkshop(Workshops workshopToDelete);
    }
    public class WorkshopServices:IWorkshopServices
    {
        private readonly IWorkshopRepository workshopRepository;

        public WorkshopServices(IWorkshopRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }

        public IEnumerable<Workshops> GetAllWorkshops()
        {
            return workshopRepository.GetAllWorkshops();
        }
        public Workshops FindWorkshopById(int id)
        {
            var myWorkshop = workshopRepository.GetWorkshopById(id);
            if (myWorkshop != null)
            {
                return myWorkshop;
            }
            return null;
        }

        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            return workshopRepository.Update(workshopToUpdate);
        }

        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            return workshopRepository.Add(workshopToAdd);
        }
        public void DeleteWorkshop(Workshops workshopToDelete)
        {
            workshopRepository.Delete(workshopToDelete);

        }
    }
}
