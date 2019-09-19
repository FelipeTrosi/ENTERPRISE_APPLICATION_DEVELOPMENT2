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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CondominioConstrutora>()
                .HasKey(c => new { c.ConstrutoraId, c.CondominioId });
            
            //Configurar o relacionamento com o condominio
            modelBuilder.Entity<CondominioConstrutora>()
                .HasOne(c => c.Condominio)
                .WithMany(c => c.CondominioConstrutoras)
                .HasForeignKey(c => c.CondominioId);
            
            //Configurar o relacionamento com a construtora
            modelBuilder.Entity<CondominioConstrutora>()
                .HasOne(c => c.Construtora)
                .WithMany(c => c.CondominioConstrutoras)
                .HasForeignKey(c => c.ConstrutoraId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Construtora> Construtoras { get; set; }
        public DbSet<Sindico> Sindicos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
    }
}
