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

        //LISTAR
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
            return RedirectToAction("Cadastrar");
        }
    }
}