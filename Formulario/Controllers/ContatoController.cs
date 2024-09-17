using Formulario.Models;
using Formulario.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Formulario.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio) 
        { 
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirmar()
        {
            return View();
        }

        public IActionResult Salvo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                contato.Preco = contato.CalcularPreco();
            }
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Salvo");
        }
    }
}
