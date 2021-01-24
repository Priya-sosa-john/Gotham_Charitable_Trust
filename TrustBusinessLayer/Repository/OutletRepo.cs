using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class OutletRepo : IOutletRepo
    {
        public void CreateOutlet(Outlets od)
        {
            throw new NotImplementedException();
        }

        public void DeleteOutlet(Outlets od)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Outlets> GetAllOutletDetails()
        {
            var outletdetails = new List<Outlets>
            {
                new Outlets{ OutletName = "Madivala", StreetName = "Madivala Market", Landmark = "Police Station", VolunteerAvailable=3,PacketsCount=20 },
                new Outlets{ OutletName = "Kochi", StreetName = "Kakkanad", Landmark = "Metro Station", VolunteerAvailable=3,PacketsCount=20 }
        };

            return outletdetails;
        }

        public Outlets OutletDetailsByName(string OutletName)
        {
            return new Outlets { OutletName = "Madivala", StreetName = "Madivala Market", Landmark = "Police Station", VolunteerAvailable = 3, PacketsCount = 20 };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateOutlet(Outlets od)
        {
            throw new NotImplementedException();
        }
    }
}
