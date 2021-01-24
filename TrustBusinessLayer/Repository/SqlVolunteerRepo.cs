using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class SqlVolunteerRepo : IVolunteerRepo
    {
        private readonly GothamContext _context;

        public SqlVolunteerRepo(GothamContext context)
        {
            _context = context;
        }

        public void CreateVolunteer(Volunteers vol)
        {
            if (vol == null)
            {
                throw new ArgumentNullException(nameof(vol));
            }
            _context.Volunteers.Add(vol);
        }

        public void DeleteVolunteer(Volunteers vol)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteers> GetAllVolunteers()
        {
            return _context.Volunteers.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateVolunteer(Volunteers vol)
        {
            throw new NotImplementedException();
        }

        public Volunteers VolunteersByOutlet(string Outlet)
        {
            return _context.Volunteers.FirstOrDefault(s => s.OutletChoice == Outlet);
        }
    }
}
