using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using _07_Fiap.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class PresidiarioController : Controller
    {
        private IPresidiarioRepository _repository;

        public PresidiarioController(IPresidiarioRepository repository)
        {
            _repository = repository;
        }

        //Cadastrar
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _repository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            _repository.Cadastrar(presidiario);
            _repository.Salvar();
            return View();
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {            
            return View(_repository.Listar());
        }
    }
}