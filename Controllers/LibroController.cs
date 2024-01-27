using Microsoft.AspNetCore.Mvc;

namespace GestionLibreriaPrueba.Controllers
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
