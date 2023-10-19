using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalErrors.Models;

namespace PersonalErrors.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

  [HttpPost]
    [Route("guardarUsuario")]
    public IActionResult GuardarUsuario(User NuevoUser)
    {
        // si todos los datos fueron validados
        if (ModelState.IsValid)
        {

            

            return RedirectToAction("Privacy");
        };
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
