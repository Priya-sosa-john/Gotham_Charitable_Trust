using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class GothamContext : DbContext
    {
        public GothamContext(DbContextOptions<GothamContext> opt) : base(opt)
        {

        }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Volunteers> Volunteers { get; set; }
        public DbSet<Foods> Foods { get; set; }

        public DbSet<Outlets> Outlets { get; set; }
    }
}

