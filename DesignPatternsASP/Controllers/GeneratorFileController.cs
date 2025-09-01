using biblioteca.Generator;
using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {

        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(d => d.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);
                if (optionFile == 1)
                {
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                }
                else
                {
                    generatorDirector.CreateSimplePipeGenerator(content, path);
                }

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();

                
                return Json("Archivo generado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
