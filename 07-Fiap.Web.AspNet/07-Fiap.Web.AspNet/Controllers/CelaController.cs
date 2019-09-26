using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class CelaController : Controller
    {
        private PresidioContext _context;

        public CelaController(PresidioContext contexto)
        {
            _context = contexto;
        }

        //CADASTRO
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            _context.Celas.Add(cela);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrada com Sucesso ";
            return RedirectToAction("Listar");
        }

        //LISTAR
        public IActionResult Listar(Cela cela)
        {           
            return View(_context.Celas.ToList());
        }
    }
}