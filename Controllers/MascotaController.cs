using Microsoft.AspNetCore.Mvc;
using netdemo.Models;
using System.Collections.Generic;

namespace netdemo.Controllers
{
    public class MascotaController : Controller  // 👈 nombre correcto
    {
        private static List<Mascota> _mascotas = new List<Mascota>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(_mascotas);
        }

        [HttpPost]
        public IActionResult Index(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                mascota.Id = _mascotas.Count + 1;
                _mascotas.Add(mascota);
                ModelState.Clear();
            }

            return View(_mascotas);
        }
    }
}
