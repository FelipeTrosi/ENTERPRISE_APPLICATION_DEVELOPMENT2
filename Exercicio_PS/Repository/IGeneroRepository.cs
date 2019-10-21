using Exercicio_PS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_PS.Repository
{
    public interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        void Atualizar(Genero genero);
        void Remover(int id);
        IList<Genero> Listar();
    }
}
