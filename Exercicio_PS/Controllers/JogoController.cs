using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Models;
using Exercicio_PS.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exercicio_PS.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _jogoRepository;
        private IGeneroRepository _generoRepository;      

        public JogoController(IJogoRepository jogoRepository, IGeneroRepository celaRepository)
        {
            _jogoRepository = jogoRepository;
            _generoRepository = celaRepository;
        }

        //LISTA DE GENEROS
        public void CarregarGeneros()
        {
            var lista = _generoRepository.Listar();
            ViewBag.generos = new SelectList(lista, "GeneroId", "Nome");
        }
        
        //CADASTRO
        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarGeneros();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _jogoRepository.Cadastrar(jogo);
            _jogoRepository.Commit();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Listar");
        }

        //LISTAR
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _jogoRepository.Listar();
            return View(lista);
        }

        //ATUALIZAR
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var jogo = _jogoRepository.Buscar(id);            
            return View(jogo);
        }
    }
}