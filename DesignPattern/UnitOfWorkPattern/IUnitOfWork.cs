namespace DesignPattern.UnitOfWorkPattern;

using Models;
using RepositoryPattern;

public interface IUnitOfWork
{
    public IRepository<Beer> Beers { get; }
    public IRepository<Brand> Brands { get; }
    public void Save();
}