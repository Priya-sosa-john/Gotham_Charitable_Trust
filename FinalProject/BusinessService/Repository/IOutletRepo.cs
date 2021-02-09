using DataService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public interface IOutletRepo
    {
        bool SaveChanges();
        IEnumerable<outlet> GetAllOutlets();
        outlet GetOutletById(int id);
        void CreateOutlet(outlet ot);
        void UpdateOutlet(outlet ot);
        void DeleteOutlet(outlet ot);
    }
}
