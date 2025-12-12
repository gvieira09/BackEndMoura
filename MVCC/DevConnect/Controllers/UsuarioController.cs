

using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevConnect.Controllers
{

    public class UsuarioController : Controller
    {

        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext
        context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerflUrl = file.FileName;

            }
            else
            {
                novoUsuario.FotoPerflUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);

                await _context.SaveChangesAsync();
                
                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                 ViewBag.UsuarioNovoCadastrado = "";
               

               return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View(); 
            }

            return View();
        }


        public IActionResult Perfil()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}