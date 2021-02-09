using DataService;
using DataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Repository
{
    public class SqlOutletRepo : IOutletRepo
    {
        private readonly GothamDbContext _context;

        public SqlOutletRepo(GothamDbContext context)
        {
            _context = context;
        }

        public void CreateOutlet(outlet ot)
        {
            if (ot == null)
            {
                throw new ArgumentNullException(nameof(ot));
            }
            _context.outlets.Add(ot);
        }

        public void DeleteOutlet(outlet ot)
        {
            if (ot == null)
            {
                throw new ArgumentNullException(nameof(ot));
            }
            _context.outlets.Remove(ot);
        }

        public IEnumerable<outlet> GetAllOutlets()
        {
            return _context.outlets.ToList();
        }

        public outlet GetOutletById(int id)
        {
            return _context.outlets.FirstOrDefault(p => p.OutletId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOutlet(outlet ot)
        {
            //Nothing
        }
    }
}
