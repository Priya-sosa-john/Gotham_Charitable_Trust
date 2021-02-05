using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public interface IVolunteerRepository
    {
        bool SaveChanges();
        IEnumerable<Volunteers> GetAllVolunteers();
        Volunteers GetVolunteersById(int id);
        void CreateVolunteer(Volunteers volunteers);
        void UpdateVolunteer(Volunteers volunteers);
        void DeleteVolunteer(Volunteers volunteers);
    }
}
