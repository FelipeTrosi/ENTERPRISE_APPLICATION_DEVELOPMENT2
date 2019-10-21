using Exercicio_PS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_PS.Persistence
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext(DbContextOptions o) : base(o)
        {

        }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
