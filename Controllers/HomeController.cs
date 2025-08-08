using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Dictionary<string, List<Pelicula>> _peliculasPorCategoria = new()
        {
            ["Acción"] = new List<Pelicula>
            {
                new() { Titulo = "Jurassic World: El renacer", Director = "Gareth Edwards", Anio = 2025 },
                new() { Titulo = "Night Carnage", Director = "Thomas J. Churchill", Anio = 2025 },
                new() { Titulo = "Superman", Director = "Thomas Ubiedal", Anio = 2025 },
            },
            ["Drama"] = new List<Pelicula>
            {
                new() { Titulo = "Karate Kid: Legends", Director = "Jonathan Entwistle", Anio = 2025 },
                new() { Titulo = "Mi año en Oxford", Director = "Iain Morris", Anio = 2025},
            },
            ["Terror"] = new List<Pelicula>
            {
                new() { Titulo = "Hook", Director = "Andrea M. Catinella", Anio = 2025 },
                new() { Titulo = "Together", Director = "Michael Shanks", Anio = 2025 },
            }
        };

        public IActionResult Index()
        {
            var categorias = _peliculasPorCategoria.Keys.ToList();
            return View(categorias);
        }

        public IActionResult ListaPeliculas(string categoria)
        {
            if (string.IsNullOrEmpty(categoria) || !_peliculasPorCategoria.ContainsKey(categoria))
                return NotFound();

            var peliculas = _peliculasPorCategoria[categoria];
            ViewBag.Categoria = categoria;
            return View(peliculas);
        }

        public static void AgregarPelicula(Deseada sugerencia)
        {
            var nueva = new Pelicula
            {
                Titulo = sugerencia.Titulo,
                Director = sugerencia.Director,
                Anio = sugerencia.Año,
                Categoria = sugerencia.Categoria
            };

            if (_peliculasPorCategoria.ContainsKey(sugerencia.Categoria))
                _peliculasPorCategoria[sugerencia.Categoria].Add(nueva);
        }
    }
}
