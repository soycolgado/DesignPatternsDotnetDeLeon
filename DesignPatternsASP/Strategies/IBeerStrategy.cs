using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;

namespace DesignPatternsASP.Strategies;

public interface IBeerStrategy
{
    public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork);
    
}