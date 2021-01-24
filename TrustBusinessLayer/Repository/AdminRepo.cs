using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class AdminRepo : IAdminRepo
    {
        public IEnumerable<Admins> GetAllAdmins()
        {
            var admins = new List<Admins>
            {
                new Admins{ ID = 1, Name = "John", Address = "Banglore", Email = "adv@gmail.com", Phone = 7895321145},
                new Admins{ ID = 2, Name = "Peter", Address = "Kerala", Email = "abs@gmail.com", Phone = 9851321145 }
        };

            return admins;
        }


        public Admins AdminsById(int Id)
        {
            return new Admins { ID = 1, Name = "John", Address = "Banglore", Email = "adv@gmail.com", Phone = 7895321145 };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void CreateAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmin(Admins ad)
        {
            throw new NotImplementedException();
        }
    }
}
