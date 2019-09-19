using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CondominioController : Controller
    {
        private CondominioContext _context;


        public CondominioController(CondominioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //LISTAR
        [HttpGet]
        public IActionResult Listar()
        {
            //include -> inclui o relacionamento na pesquisa
            return View(_context.Condominios.Include(c => c.Sindico).ToList());
        }


        //CADASTRAR
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Condominio condominio)
        {
            _context.Condominios.Add(condominio);
            _context.SaveChanges();
            TempData["mensagem"] = "CADASTRADO";
            return RedirectToAction("Listar");
        }


        //EDITAR
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //include -> inclui o relacionamento na pesquisa
            var condominio = _context.Condominios.Include(c => c.Sindico)
                .Where(c => c.CondominioId == id).FirstOrDefault();
            return View(condominio);
        }

        [HttpPost]
        public IActionResult Editar(Condominio condominio)
        {
            _context.Condominios.Update(condominio);
            _context.SaveChanges();
            TempData["mensagem"] = "Editado com sucesso";
            return RedirectToAction("Listar");
        }

        //EXCLUIR
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            //include -> inclui o relacionamento na pesquisa
            var condominio = _context.Condominios.Find(id);
            _context.Condominios.Remove(condominio);
            _context.SaveChanges();
            TempData["mensagem"] = "Excluido";
            return RedirectToAction("Listar");
        }

        //PESQUISAR
        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa)
        {
            //include -> inclui o relacionamento na pesquisa
            var lista = _context.Condominios.Where(
                churros => churros.Nome.Contains(termoPesquisa))
                .Include(c => c.Sindico).ToList();
            return View("Listar",lista);
        }    

    }
}