using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Repository
{
    public class SqlVolunteerRepository : IVolunteerRepository
    {
        private readonly GothamContext _context;
        public SqlVolunteerRepository(GothamContext context)
        {
            _context = context;
        }
        public void CreateVolunteer(Volunteers volunteers)
        {
            if (volunteers == null)
            {
                throw new ArgumentNullException(nameof(volunteers));
            }
            _context.Volunteers.Add(volunteers);
        }

        public void DeleteVolunteer(Volunteers volunteers)
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

        public void UpdateVolunteer(Volunteers volunteers)
        {
            throw new NotImplementedException();
        }

        public Volunteers GetVolunteersById(int id)
        {
            return _context.Volunteers.FirstOrDefault(s => s.id == id);
        }
    }
}
