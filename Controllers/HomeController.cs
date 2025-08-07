using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    public IActionResult Index()
    {
        return View();
    }

    
    [HttpPost]
    public IActionResult Index(Jugador jugador)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Mensaje = $"GRACIAS \"{jugador.Nombre.ToUpper()}\" POR HABERTE REGISTRADO A NUESTRO JUEGO DE LOL";
        }

        return View(jugador);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
