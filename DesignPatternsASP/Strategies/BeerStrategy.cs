using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;

namespace DesignPatternsASP.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerViewModel.Name;
            beer.Style = beerViewModel.Style;
            beer.BrandId = (Guid)beerViewModel.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
