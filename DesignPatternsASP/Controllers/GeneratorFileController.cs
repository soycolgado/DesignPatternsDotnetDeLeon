using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        // GET: GeneratorFileController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            
        }

    }
}
