using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Persistence
{
    public class BancoContext : DbContext
    {
        public DbSet<Serie> Series { get; set; }

        //Construtor
        public BancoContext(DbContextOptions o) : base (o)
        {
            
        }

    }
}
