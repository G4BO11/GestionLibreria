using Microsoft.AspNetCore.Mvc;

namespace GestionLibreriaPrueba.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
