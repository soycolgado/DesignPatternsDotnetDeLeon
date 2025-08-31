﻿using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;

namespace DesignPatternsASP.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;

        public IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            this._strategy.Add(beerVM, unitOfWork);
        }



    }
}
