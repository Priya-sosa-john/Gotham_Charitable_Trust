using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public interface IOutletRepo
    {
        bool SaveChanges();
        IEnumerable<Outlets> GetAllOutletDetails();
        Outlets OutletDetailsByName(string OutletName);

        void CreateOutlet(Outlets od);
        void UpdateOutlet(Outlets od);
        void DeleteOutlet(Outlets od);
    }
}
