using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsASP.Controllers;

using biblioteca.Earn;

public class ProductDetailController : Controller
{
    private EarnFactory _localEarnFactory;

    public ProductDetailController(LocalEarnFactory localEarnFactory)
    {
        _localEarnFactory = localEarnFactory;
    }
    // GET
    public IActionResult Index(decimal total)
    {
        // LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
        ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);
        var localEarn = _localEarnFactory.GetEarn();
        var foreignEarn = foreignEarnFactory.GetEarn();
        ViewBag.totalLocal = total + localEarn.Earn(total);
        ViewBag.totalForeign = total + foreignEarn.Earn(total);
        return View();
    }
}