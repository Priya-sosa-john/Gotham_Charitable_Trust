using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;
using System.Linq;

namespace TrustBusinessLayer.Repository
{
    public class SqlAdminRepo : IAdminRepo
    {
        private readonly GothamContext _context;

        public SqlAdminRepo(GothamContext context)
        {
            _context = context;
        }

        public Admins AdminsById(int ID)
        {
            return _context.Admins.FirstOrDefault(x => x.ID == ID);
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

        public void UpdateAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }
    }
}
