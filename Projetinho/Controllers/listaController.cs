using Microsoft.AspNetCore.Mvc;

namespace Projetinho.Controllers
{
    public class listaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
         public IActionResult Editar()
        {
            return View();
        }

         public IActionResult Apagar()
        {
            return View();
        }

    }
}
