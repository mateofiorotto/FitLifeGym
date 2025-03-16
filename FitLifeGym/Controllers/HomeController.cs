using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitLifeGymGym.Models;
using System.Xml.Linq;

namespace FitLifeGymGym.Controllers;

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
    public IActionResult Shop()
    {
        return View();
    }
    public IActionResult About(string name, int numTimes = 1)
    {
        ViewData["Members"] = name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
