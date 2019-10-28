using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Models;
using Exercicio_PS.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_PS.Repository
{
    public class JogoRepository : IJogoRepository
    {
        private GameStoreContext _context;

        public JogoRepository(GameStoreContext context)
        {
            _context = context;
        }
       
        public void Atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
        }

        public Jogo Buscar(int codigo)
        {
            var jogo = _context.Jogos.Include(g => g.Genero)
                                        .Where(g => g.JogoId == codigo)
                                        .FirstOrDefault();
            return jogo;
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public void Commit()
        {
            _context.SaveChanges();            
        }

        public IList<Jogo> Listar()
        {
            var lista = _context.Jogos.Include(g => g.Genero).ToList();
            return lista;
        }

        public void Remover(int codigo)
        {
            var jogo = _context.Jogos.Find(codigo);
            _context.Jogos.Remove(jogo);
        }
    }
}
