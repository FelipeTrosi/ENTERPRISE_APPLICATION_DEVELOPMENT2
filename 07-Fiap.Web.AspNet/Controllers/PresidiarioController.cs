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
        private ICelaRepository _celaRepository;

        public PresidiarioController(IPresidiarioRepository repository, ICelaRepository celaRepository)
        {
            _repository = repository;
            _celaRepository = celaRepository;
        }
       

        //Cadastrar
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _celaRepository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");
            return View();
          
        }

        private void CarregarCelas()
        {
            var lista = _celaRepository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            if (ModelState.IsValid)
            {
                _repository.Cadastrar(presidiario);
                _repository.Salvar();
                return RedirectToAction("Listar");
            }
            else
            {
                CarregarCelas();
                return View();
            }
            
        }
        

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {            
            return View(_repository.Listar());
        }

        //Definir Saida
        [HttpPost]
        public IActionResult DefinirSaida(int codigo)
        {
             var presidiario = _repository.BuscarPorCodigo(codigo);
            presidiario.SaidaTemporaria = true;
            _repository.Atualizar(presidiario);
            _repository.Salvar();
            return RedirectToAction("Detalhar","Cela", new { codigo = presidiario.CelaId});
        }
    }
}