using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers
{
    public class DeseadasController : Controller
    {
        public IActionResult Crear()
        {
            // Paso las categorías al dropdown
            ViewBag.Categorias = new List<string> { "Drama", "Terror", "Acción" };
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Deseada pelicula)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categorias = new List<string> { "Drama", "Terror", "Acción" };
                return View(pelicula);
            }

            // Agregamos la película sugerida a la lista de HomeController
            HomeController.AgregarPelicula(pelicula);

            return RedirectToAction("Agradecimiento");
        }

        public IActionResult Agradecimiento()
        {
            return View();
        }
    }
}
