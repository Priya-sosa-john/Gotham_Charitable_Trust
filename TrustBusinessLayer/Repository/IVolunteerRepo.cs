using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public interface IVolunteerRepo
    {
        bool SaveChanges();
        IEnumerable<Volunteers> GetAllVolunteers();
        Volunteers VolunteersByOutlet(string OutletChoice);
        void CreateVolunteer(Volunteers vol);
        void UpdateVolunteer(Volunteers vol);
        void DeleteVolunteer(Volunteers vol);
    }
}
