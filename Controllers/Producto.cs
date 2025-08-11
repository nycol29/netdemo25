using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers
{
    public class ProductoController : Controller
    {
        // Simularemos una lista en memoria
        private static List<Producto> _productos = new List<Producto>();

        // Muestra lista y formulario juntos
        public IActionResult Index()
        {
            return View(_productos);
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = _productos.Count + 1;
                _productos.Add(producto);
                return RedirectToAction("Index");
            }
            return View("Index", _productos);
        }
    }
}
