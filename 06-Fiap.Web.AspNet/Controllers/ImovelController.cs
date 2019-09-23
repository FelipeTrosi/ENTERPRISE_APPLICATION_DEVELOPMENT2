using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class ImovelController : Controller
    {
        private CondominioContext _context;

        public ImovelController(CondominioContext context)
        {
            _context = context;
        }
        private void CarregarSelectCondominio()
        {
            var condominios = _context.Condominios.ToList();
            ViewBag.condominios = new SelectList(condominios, "CondominioId", "Nome");
        }

        //CADASTRAR
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var condominios = _context.Condominios.ToList();
            ViewBag.condominios = new SelectList(condominios, "CondominioId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Imovel imovel)
        {
            _context.Add(imovel);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }


        //LISTAR
        [HttpGet]
        public IActionResult Listar(int termoBusca)
        {
            CarregarSelectCondominio();
            return View(_context.Imoveis.Include(c => c.Condominio)
                    .Where(i => i.CondominioId == termoBusca || termoBusca == 0).ToList());
        }

        //EDITAR
        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarSelectCondominio();

            var imovel = _context.Imoveis.Include(c => c.Condominio)
                .Where(i => i.ImovelId == id ).FirstOrDefault();
            return View(imovel);
        }


        [HttpPost]
        public IActionResult Editar(Imovel imovel)
        {
            _context.Imoveis.Update(imovel);
            _context.SaveChanges();
            TempData["mensagem"] = "Editado com sucesso";
            return RedirectToAction("Listar");
        }

        //EXCLUIR
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var imovel = _context.Imoveis.Find(id);
            _context.Imoveis.Remove(imovel);
            _context.SaveChanges();
            TempData["mensagem"] = "Excluido";
            return RedirectToAction("Listar");

        }
      
       
    }
}