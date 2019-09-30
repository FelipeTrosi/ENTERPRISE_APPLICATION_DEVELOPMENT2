using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;

namespace _07_Fiap.Web.AspNet.Repository
{
    public class PresidiarioRepository : IPresidiarioRepository
    {

        private PresidioContext _context;

        public PresidiarioRepository(PresidioContext context)
        {
            _context = context;
        }

        public void Atualizar(Presidiario presidiario)
        {
            _context.Presidiarios.Update(presidiario);
        }

        public IList<Presidiario> BuscarPor(Expression<Func<Presidiario, bool>> filtro)
        {
            return _context.Presidiarios.Where(filtro).ToList();
        }

        public void Cadastrar(Presidiario presidiario)
        {
            _context.Presidiarios.Add(presidiario);
        }

        public IList<Presidiario> Listar()
        {
            return _context.Presidiarios.ToList();
        }

        public void Remover(int codigo)
        {
            var presidiario = _context.Presidiarios.Find(codigo);
            _context.Presidiarios.Remove(presidiario);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
