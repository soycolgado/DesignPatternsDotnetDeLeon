using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;
using DesignPatternsASP.Strategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsASP.Controllers;

public class BeerController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public BeerController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    public IActionResult Index()
    {
        IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                           select new BeerViewModel
                                           {
                                               Id = d.BeerId,
                                               Name = d.Name,
                                               Style = d.Style
                                           };
        return View("Index", beers);
    }

    [HttpGet]
    public IActionResult Add()
    {
        this.GetBrandsData();
        // var brands = _unitOfWork.Brands.Get();
        // ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Add(FormBeerViewModel beerVM)
    {
        if (!ModelState.IsValid)
        {
            this.GetBrandsData();
            // var brands = _unitOfWork.Brands.Get();
            // ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
            return View("Add", beerVM);
        }

        var context = beerVM.BrandId == null ?
            new BeerContext(new BeerWithBrandStrategy()) :
            new BeerContext(new BeerStrategy());

        context.Add(beerVM, _unitOfWork);

        
        return RedirectToAction("Index");
    }

    #region HELPERS

    private void GetBrandsData()
    {
        var brands = _unitOfWork.Brands.Get();
        ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
    }

    #endregion
}