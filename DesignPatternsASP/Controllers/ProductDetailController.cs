using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsASP.Controllers;

using biblioteca.Earn;

public class ProductDetailController : Controller
{
    private EarnFactory _localEarnFactory;
    private EarnFactory _foreignEarnFactory;

    public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
    {
        _localEarnFactory = localEarnFactory;
        _foreignEarnFactory = foreignEarnFactory;
    }
    // GET
    public IActionResult Index(decimal total)
    {
        // LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
        // ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

        var localEarn = _localEarnFactory.GetEarn();
        var foreignEarn = _foreignEarnFactory.GetEarn();
        ViewBag.totalLocal = total + localEarn.Earn(total);
        ViewBag.totalForeign = total + foreignEarn.Earn(total);
        return View();
    }
}