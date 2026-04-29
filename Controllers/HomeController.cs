using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01bis_ALFIE_FAINSCHTEIN.Models;

namespace TP01bis_ALFIE_FAINSCHTEIN.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Complejo complejo = new Complejo();
       Dictionary<int, Cabaña> cabañas = complejo.devolverComplejo();
       ViewBag.cabañas = cabañas;   
        return View();
    }
    public IActionResult selectCabaña(int ID)
    {
        Complejo complejo = new Complejo();
       ViewBag.cabaña = complejo.obtenerCabaña(ID);   
        return View("infoCabaña");
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
