namespace DesignPattern.UnitOfWorkPattern;

using Models;
using RepositoryPattern;

public class UnitOfWork: IUnitOfWork
{
    private readonly DesignPatternsContext _context;
    public IRepository<Beer> _beers;
    public IRepository<Brand> _brands;

    public IRepository<Beer> Beers
    {
        get
        {
            return _beers == null ? _beers = new Repository<Beer>(_context) : _beers;
        }
    }

    public IRepository<Brand> Brands
    {
        get
        {
            return _brands == null ? _brands = new Repository<Brand>(_context) : _brands;
        }
    }

    public UnitOfWork(DesignPatternsContext context)
    {
        _context = context;
    }
    
    public void Save()
    {
        _context.SaveChanges();
    }
}