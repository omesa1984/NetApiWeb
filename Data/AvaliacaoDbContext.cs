using AvaliacaoNetApiWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class AvaliacaoDbContext : DbContext
    {

        public AvaliacaoDbContext(DbContextOptions<AvaliacaoDbContext> opt) : base(opt)
        {

        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<People> Peoples { get; set; }
    }
}
