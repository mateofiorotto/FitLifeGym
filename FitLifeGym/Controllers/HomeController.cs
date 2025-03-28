using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitLifeGym.Models;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using FitLifeGym.Data;

namespace FitLifeGym.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FitLifeGymContext _context;

    public HomeController(FitLifeGymContext context, ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Shop(string searchString)
    {

        return View(await _context.Product.ToListAsync());
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    //404
    public IActionResult Error(int? statusCode = null)
    {
        if (statusCode.HasValue)
        {
            if (statusCode == 404 || statusCode == 500)
            {
                var viewName = statusCode.ToString();
                return View(viewName);
            }
        }

        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
