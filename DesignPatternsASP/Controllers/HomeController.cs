using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignPatternsASP.Models;

namespace DesignPatternsASP.Controllers;

using biblioteca;
using Configuration;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using Microsoft.Extensions.Options;

public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;
    private readonly IRepository<Beer> _repository;

    public HomeController(
        IOptions<MyConfig> config,
        IRepository<Beer> repository)
    {
        _config = config;
        _repository = repository;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro en index");
        IEnumerable<Beer> lst = _repository.Get();
        return View("Index", lst);
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