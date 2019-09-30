using _07_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.Web.AspNet.Persistence
{
    public class PresidioContext : DbContext
    {
        public PresidioContext(DbContextOptions o) : base(o) { }
        public DbSet<Cela> Celas {get; set; }
        public DbSet<Presidiario> Presidiarios { get; set; }
    }
}
