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
            return RedirectToAction("Listar");
        }
    }
}