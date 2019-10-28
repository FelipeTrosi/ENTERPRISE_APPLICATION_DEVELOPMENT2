using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Models;
using Exercicio_PS.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_PS.Controllers
{
    public class GeneroController : Controller
    {
        private IJogoRepository _jogoRepository;
        private IGeneroRepository _generoRepository;

        public GeneroController(IJogoRepository jogoRepository, IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
            _jogoRepository = jogoRepository;
        }

        //CADASTRO
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Genero genero)
        {
            TempData["msg"] = "Cadastrado com sucesso";
            _generoRepository.Cadastrar(genero);
            _generoRepository.Commit();
            return RedirectToAction("Cadastrar");
        }
    }
}