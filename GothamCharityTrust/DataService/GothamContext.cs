using DataService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService
{
    public class GothamContext: DbContext
    {
        public GothamContext(DbContextOptions<GothamContext> opt) : base(opt)
        {

        }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Volunteers> Volunteers { get; set; }
        public DbSet<Outlets> Outlets { get; set; }
    }
}
