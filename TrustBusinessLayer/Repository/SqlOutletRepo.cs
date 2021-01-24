using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class SqlOutletRepo : IOutletRepo
    {
        private readonly GothamContext _context;

        public SqlOutletRepo(GothamContext context)
        {
            _context = context;
        }

        public void CreateOutlet(Outlets od)
        {
            if (od == null)
            {
                throw new ArgumentNullException(nameof(od));
            }
            _context.Outlets.Add(od);
        }

        public void DeleteOutlet(Outlets od)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Outlets> GetAllOutletDetails()
        {
            return _context.Outlets.ToList();
        }

        public Outlets OutletDetailsByName(string OutletName)
        {
            return _context.Outlets.FirstOrDefault(s => s.OutletName == OutletName);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOutlet(Outlets od)
        {
            throw new NotImplementedException();
        }
    }
}
