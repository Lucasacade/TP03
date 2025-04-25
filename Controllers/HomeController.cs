using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Dictionary<int, Disco> discos = new Dictionary<int, Disco>();
        ViewBag.discos = MusicStore.InicializarDiscos();
        return View();
    }
    public IActionResult SelectDisco(int IDdisco)
    {
        Dictionary<int, Disco> discos = new Dictionary<int, Disco>();
        discos = MusicStore.InicializarDiscos();
        if(discos.ContainsKey(IDdisco))
        {
            ViewBag.disco = discos[IDdisco];
        }
        return View("Disco.cshtml");
    }

}
