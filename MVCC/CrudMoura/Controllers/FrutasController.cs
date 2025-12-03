using Microsoft.AspNetCore.Mvc;

using CrudMoura.Models;
namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;
        public static List<Frutas> ListaDeFrutas = new List<Frutas>
        {
            new Frutas{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Frutas{Id = 2, Nome = "Abacaxi", Preco = 6.99f, Quantidade = 15, Categoria = "Citrico"},
            new Frutas{Id = 3, Nome = "Maracuja", Preco = 3.99f, Quantidade = 50, Categoria = "Tropical"}
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarFrutas()
        {
            ViewBag.Frutas = ListaDeFrutas;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarFrutas(Frutas frutaCadastrada)
        {
            frutaCadastrada.Id = ListaDeFrutas.Max(f => f.Id) + 1;

            ListaDeFrutas.Add(frutaCadastrada);

            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}