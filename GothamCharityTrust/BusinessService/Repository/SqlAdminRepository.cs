using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Repository
{
    public class SqlAdminRepository : IAdminRepository
    {
        private readonly GothamContext _context;

        public SqlAdminRepository(GothamContext context)
        {
            _context = context;
        }
        public Admins AdminsById(int id)
        {
            return _context.Admins.FirstOrDefault(x => x.id == id);
        }

        public void CreateAdmin(Admins ad)
        {
            if (ad == null)
            {
                throw new ArgumentNullException(nameof(ad));
            }
            _context.Admins.Add(ad);
        }

        public void DeleteAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admins> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
