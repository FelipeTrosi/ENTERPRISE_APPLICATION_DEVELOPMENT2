using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persistence
{
    public class CondominioContext: DbContext
    {
        public CondominioContext(DbContextOptions o) : base(o) { }

        public DbSet<Condominio> Condominios { get; set; }

    }
}
