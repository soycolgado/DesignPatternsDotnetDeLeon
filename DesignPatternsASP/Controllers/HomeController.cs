using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignPatternsASP.Models;

namespace DesignPatternsASP.Controllers;

using biblioteca;
using Configuration;
using Microsoft.Extensions.Options;

public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;

    public HomeController(IOptions<MyConfig> config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro en index");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro en privacy");
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}