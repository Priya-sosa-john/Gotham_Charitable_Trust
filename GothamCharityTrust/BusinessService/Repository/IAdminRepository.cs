using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Repository
{
    public interface IAdminRepository
    {
        bool SaveChanges();
        IEnumerable<Admins> GetAllAdmins();
        Admins AdminsById(int id);

        void CreateAdmin(Admins ad);
    
        void DeleteAdmin(Admins ad);
    }
}
