using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public class VolunteerRepository : IVolunteerRepository
    {
        public void CreateVolunteer(Volunteers volunteers)
        {
            throw new NotImplementedException();
        }

        public void DeleteVolunteer(Volunteers volunteers)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteers> GetAllVolunteers()
        {
            var volunteers = new List<Volunteers>
            {
                new Volunteers{ id= 1, name = "Jose", address = "Banglore", email = "adv@gmail.com", phone = 7895321145, date="20/01/2021", outletchoice="Madivala"},
                new Volunteers{ id = 2, name = "Parker", address = "Kerala", email = "abs@gmail.com", phone = 9851321145, date="21/01/2021", outletchoice="Kochi" }
        };

            return volunteers;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateVolunteer(Volunteers volunteers)
        {
            throw new NotImplementedException();
        }

        public Volunteers GetVolunteersById(int id)
        {
            return new Volunteers { id = 2, name = "Parker", address = "Kerala", email = "abs@gmail.com", phone = 9851321145, date = "21/01/2021", outletchoice = "Kochi" };
        }
    }
}
