using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Models;
using Exercicio_PS.Persistence;

namespace Exercicio_PS.Repository
{
    public class GeneroRepository : IGeneroRepository
    {
        private GameStoreContext _context;
        public GeneroRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void Atualizar(Genero genero)
        {
            _context.Generos.Update(genero);   
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            var lista = _context.Generos.ToList();
            return lista;
        }

        public void Remover(int id)
        {
            var genero = _context.Generos.Find(id);
            _context.Generos.Remove(genero);
        }
    }
}
