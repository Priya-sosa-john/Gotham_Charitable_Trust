using DataService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public class OutletRepo : IOutletRepo
    {
        public void CreateOutlet(outlet ot)
        {
            throw new NotImplementedException();
        }

        public void DeleteOutlet(outlet ot)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<outlet> GetAllOutlets()
        {
            var outlets = new List<outlet>
            {
                new outlet { OutletId = 0, OutletName = "Madivala", Street = "Madivala Market", Landmark = "Police Station", AvailableFoodPackets=20 ,FoodType="Both", RequiredVolunteers=3,Date="07/02/2020"},
                new outlet { OutletId = 1, OutletName = "Kochi", Street = "Kakkanad", Landmark = "Metro Station",AvailableFoodPackets=07,FoodType="Veg",RequiredVolunteers=08,Date="12/02/2020" },

            };
            return outlets;
        }

        public outlet GetOutletById(int id)
        {
            return new outlet { OutletId = 0, OutletName = "Madivala", Street = "Madivala Market", Landmark = "Police Station", AvailableFoodPackets = 20, FoodType = "Both", RequiredVolunteers = 3, Date = "07/02/2020" };

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateOutlet(outlet ot)
        {
            throw new NotImplementedException();
        }
    
}
}
