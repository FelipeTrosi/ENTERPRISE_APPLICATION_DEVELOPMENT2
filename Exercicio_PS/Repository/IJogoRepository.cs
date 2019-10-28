using Exercicio_PS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_PS.Repository
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        void Atualizar(Jogo jogo);
        void Remover(int codigo);
        IList<Jogo> Listar();
        void Commit();
        Jogo Buscar(int codigo);
    }
}
