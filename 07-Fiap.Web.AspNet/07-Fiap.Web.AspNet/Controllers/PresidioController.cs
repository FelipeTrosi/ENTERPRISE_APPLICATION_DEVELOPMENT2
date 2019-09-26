using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class PresidioController : Controller
    {
        private PresidioContext _context;
        
        public PresidioController(PresidioContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            var lista = _context.Celas.ToList();
            ViewBag.celas = new SelectList(lista,"CelaId","Nome");
            return View();
        }
    }
}