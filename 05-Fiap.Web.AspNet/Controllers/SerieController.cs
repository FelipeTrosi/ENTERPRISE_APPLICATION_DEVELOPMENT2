using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

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

        private static IList<Serie> _lista = new List<Serie>();

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Serie serie)
        {
            _lista.Add(serie);
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