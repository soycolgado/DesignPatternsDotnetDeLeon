using System;
using DesignPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.RepositoryPattern;

public class BeerRepository : IBeerRepository
{
    private DesignPatternsContext _context;

    public BeerRepository(DesignPatternsContext context)
    {
        this._context = context;
    }
    public void Add(Beer data)
    {
        this._context.Beers.Add(data);
    }

    public void Delete(int id)
    {
        var beer = this._context.Beers.Find(id);
        this._context.Beers.Remove(beer);
    }

    public IEnumerable<Beer> Get()
    {
        return this._context.Beers.ToList();
    }

    public Beer Get(int id)
    {
        return this._context.Beers.Find(id);
    }

    public void Update(Beer data)
    {
        this._context.Entry(data).State = EntityState.Modified;
    }

    public void Save()
    {
        this._context.SaveChanges();
    }
}
