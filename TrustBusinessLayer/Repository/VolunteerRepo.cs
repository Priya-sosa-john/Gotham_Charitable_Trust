using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class VolunteerRepo : IVolunteerRepo
    {
        public void CreateVolunteer(Volunteers vol)
        {
            throw new NotImplementedException();
        }

        public void DeleteVolunteer(Volunteers vol)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteers> GetAllVolunteers()
        {
            var volunteers = new List<Volunteers>
            {
                new Volunteers{ ID = 1, Name = "Jose", Address = "Banglore", Email = "adv@gmail.com", Phone = 7895321145, Date="20/01/2021", OutletChoice="Madivala"},
                new Volunteers{ ID = 2, Name = "Parker", Address = "Kerala", Email = "abs@gmail.com", Phone = 9851321145, Date="21/01/2021", OutletChoice="Kochi" }
        };

            return volunteers;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateVolunteer(Volunteers vol)
        {
            throw new NotImplementedException();
        }

        public Volunteers VolunteersByOutlet(string Outlet)
        {
            return new Volunteers { ID = 1, Name = "Jose", Address = "Banglore", Email = "adv@gmail.com", Phone = 7895321145, Date = "20/01/2021", OutletChoice = "Madivala" };
        }

    }
}
