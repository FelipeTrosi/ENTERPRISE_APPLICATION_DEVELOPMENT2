using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class DiretorController : Controller
    {
        private BancoContext _context;

        public IActionResult Cadastrar(Diretor diretor)
        {
            return View();
        }
    }
}