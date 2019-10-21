using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_PS.Repository;
using Microsoft.AspNetCore.Mvc;

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



        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}