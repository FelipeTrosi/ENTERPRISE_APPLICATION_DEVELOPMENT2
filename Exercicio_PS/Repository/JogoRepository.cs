using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Models;
using Exercicio_PS.Persistence;

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

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public IList<Jogo> Listar()
        {
            var lista = _context.Jogos.ToList();
            return lista;
        }

        public void Remover(int codigo)
        {
            var jogo = _context.Jogos.Find(codigo);
            _context.Jogos.Remove(jogo);
        }
    }
}
