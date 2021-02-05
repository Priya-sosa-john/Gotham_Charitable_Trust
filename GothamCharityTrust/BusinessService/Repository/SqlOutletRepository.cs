using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Repository
{
    public class SqlOutletRepository : IOutletRepository
    {
        private readonly GothamContext _context;
        public SqlOutletRepository(GothamContext context)
        {
            _context = context;
        }
        public void CreateOutlet(Outlets outlets)
        {
            if (outlets == null)
            {
                throw new ArgumentNullException(nameof(outlets));
            }
            _context.Outlets.Add(outlets);
        }

        public void DeleteOutlet(Outlets outlets)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Outlets> GetAllOutletDetails()
        {
            return _context.Outlets.ToList();
        }

        public Outlets GetOutletDetailsByName(string outletname)
        {
            return _context.Outlets.FirstOrDefault(s => s.outletname == outletname);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOutlet(Outlets outlets)
        {
            throw new NotImplementedException();
        }
    }
}
