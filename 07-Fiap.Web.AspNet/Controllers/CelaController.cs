using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using _07_Fiap.Web.AspNet.Repository;
using _07_Fiap.Web.AspNet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class CelaController : Controller
    {
        private ICelaRepository _repository;
        private IPresidiarioRepository _presidiarioRepository;

        public CelaController(ICelaRepository repository, IPresidiarioRepository presidiarioRepository)
        {
            _repository = repository;
            _presidiarioRepository = presidiarioRepository;

        }

        //CADASTRO
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            if (ModelState.IsValid)
            {
                _repository.Cadastrar(cela);
                _repository.Salvar();
                TempData["msg"] = "Cadastrada com Sucesso ";
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }            
        }

        //LISTAR
        [HttpGet]
        public IActionResult Listar()
        {           
            return View(_repository.Listar());
        }

        //DETALHES
        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            //Pesquisar a cela
            var cela = _repository.BuscarPorCodigo(codigo);
            //Listar presidiarios da cela
            var presidiarios = _presidiarioRepository.BuscarPor(p => p.CelaId == codigo);
            //Objeto que possui todas informações da tela
            var viewModel = new DetalheCelaViewModel()
            {
                Cela = cela,
                Presidiarios = presidiarios,
                QuantidadePresidiarios = presidiarios.Count,
                Ocupacao = (presidiarios.Count * 100) / cela.QuantidadeMaxima

            };
            return View(viewModel);
        }

    }
}