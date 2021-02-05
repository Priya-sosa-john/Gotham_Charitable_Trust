using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public interface IOutletRepository
    {
        bool SaveChanges();
        IEnumerable<Outlets> GetAllOutletDetails();
        Outlets GetOutletDetailsByName(string outletname);

        void CreateOutlet(Outlets outlets);
        void UpdateOutlet(Outlets outlets);
        void DeleteOutlet(Outlets outlets);
    }
}
