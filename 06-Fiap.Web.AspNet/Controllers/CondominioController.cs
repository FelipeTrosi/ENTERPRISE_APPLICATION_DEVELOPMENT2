using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

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
            return View(_context.Condominios.ToList());
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
            var condominio = _context.Condominios.Find(id);
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
            var lista = _context.Condominios.Where(
                churros => churros.Nome.Contains(termoPesquisa)).ToList();
            return View("Listar",lista);
        }    

    }
}