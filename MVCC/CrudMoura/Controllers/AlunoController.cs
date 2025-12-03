using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;


namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "Gustavo", Cpf = 50408858818, Endereco = "Nova Heliopolis" }
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            ViewBag.Aluno = ListaDeAlunos;
            return View();
        }

        public IActionResult CadastroAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno alunoCadastrado)
        {
            alunoCadastrado.Id = ListaDeAlunos.Max(a => a.Id) + 1;
            ListaDeAlunos.Add(alunoCadastrado);

            return RedirectToAction(nameof(ListarAlunos));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
