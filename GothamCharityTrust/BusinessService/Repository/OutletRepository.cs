using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public class OutletRepository : IOutletRepository
    {
        public void CreateOutlet(Outlets outlets)
        {
            throw new NotImplementedException();
        }

        public void DeleteOutlet(Outlets outlets)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Outlets> GetAllOutletDetails()
        {
            var outletdetails = new List<Outlets>
            {
                new Outlets{ outletname = "Madivala", streetname = "Madivala Market", landmark = "Police Station", volunteers=3,packets=20, foodtype ="Both",date="04/02/2021" },
                new Outlets{ outletname = "Kochi", streetname = "Kakkanad", landmark = "Metro Station", volunteers=3,packets=20, foodtype ="Veg",date="05/02/2021" }
        };

            return outletdetails;
        }

        public Outlets GetOutletDetailsByName(string outletname)
        {
            return new Outlets { outletname = "Madivala", streetname = "Madivala Market", landmark = "Police Station", volunteers = 3, packets = 20, foodtype = "Both", date = "04/02/2021" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateOutlet(Outlets outlets)
        {
            throw new NotImplementedException();
        }
    }
}
