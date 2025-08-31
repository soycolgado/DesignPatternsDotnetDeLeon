namespace DesignPatterns.Repository;

using Models.Data;

public interface IUnitOfWork
{
    public IRepository<Beer> Beers { get; }
    public IRepository<Brand> Brands { get; }
    public void Save();
}