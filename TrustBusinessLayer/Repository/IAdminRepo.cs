using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public interface IAdminRepo
    {
        bool SaveChanges();
        IEnumerable<Admins> GetAllAdmins();
        Admins AdminsById(int ID);

        void CreateAdmin(Admins ad);
        void UpdateAdmin(Admins ad);
        void DeleteAdmin(Admins ad);
    }
}
