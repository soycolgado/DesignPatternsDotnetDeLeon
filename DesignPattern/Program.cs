// using DesignPattern.FactoryPattern;

// SaleFactory storeSaleFactory = new StoreSaleFactory(10);
// SaleFactory internetSaleFactory = new InternetSaleFactory(2);
//
// ISale sal1 = storeSaleFactory.GetSale();
// sal1.Sell(15);
//
// ISale sal2 = internetSaleFactory.GetSale();
// sal2.Sell(15);

// using DesignPattern.DependencyInjection;

// var beer = new Beer("Pikantus", "Edinger");
// var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
// drinkWithBeer.Build();

using System.Runtime.CompilerServices;
using DesignPattern.Models;
using DesignPattern.RepositoryPattern;

using (var context = new DesignPatternsContext())
{
    var beerRepository = new Repository<Beer>(context);
    var beer = new Beer() {Name = "Corona", Style = "Pilsner"};
    beerRepository.Add(beer);
    beerRepository.Save();

    foreach (var b in beerRepository.Get())
    {
        Console.WriteLine($"{b.BeerId} - {b.Name}");
    }
}

// using (var context = new DesignPatternsContext())
// {
//     var beerRepository = new BeerRepository(context);
//     var beer = new Beer();
//     beer.Name = "Corona";
//     beer.Style = "Pilsner";
//     beerRepository.Add(beer);
//     beerRepository.Save();
//
//     var beers = beerRepository.Get();
//     foreach (var b in beers)
//     {
//         System.Console.WriteLine(b.Name); ;
//     }
    // var beers = context.Beers.ToList();

    // foreach (var beer in beers)
    // {
    //     System.Console.WriteLine($"Name: {beer.Name} - Style: {beer.Style}");

    // }
// }