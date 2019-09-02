using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {
        //tipo o "em", vai acessar as coisas no banco
        private BancoContext _context;

      
        //O Context será instanciado pelo framework
        public SerieController(BancoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Editar(Serie serie)
        {
            //atualiza no banco
            _context.Attach(serie).State = EntityState.Modified;
            _context.SaveChanges();
            //Mensagem de suecesso para tela
            TempData["msg"] = "Atualizado";
            //Redirect para o método de listagem 
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var serie = _context.Series.Find(id);
            return View(serie);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Series.ToList());
        }

        [HttpPost]
        public IActionResult Cadastrar(Serie serie)
        {
            _context.Series.Add(serie);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}