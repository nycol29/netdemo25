using Microsoft.AspNetCore.Mvc;

namespace netdemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensaje = "Bienvenido a la Veterinaria ";
            return View();
        }
    }
}
