using Microsoft.AspNetCore.Mvc;

namespace netdemo.Controllers
{
    public class RazaPerroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
