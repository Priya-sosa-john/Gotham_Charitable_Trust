using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public class AdminsRepository : IAdminRepository
    {
        public Admins AdminsById(int id)
        {
            return new Admins { id = 2, email = "abs@gmail.com", password = "achu@21" };
        }
    

        public void CreateAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admins> GetAllAdmins()
        {
            var admins = new List<Admins>
            {
                new Admins{ id = 1,  email = "adv@gmail.com", password = "priya@04"},
                new Admins{ id = 2, email = "abs@gmail.com", password = "achu@21" }
             };

            return admins;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
