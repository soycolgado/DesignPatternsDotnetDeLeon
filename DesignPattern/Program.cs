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

// using System.Runtime.CompilerServices;
// using DesignPattern.Models;
// using DesignPattern.RepositoryPattern;
// using DesignPattern.UnitOfWorkPattern;

// using (var context = new DesignPatternsContext())
// {
//     var unitOfWork = new UnitOfWork(context);
//     var beers = unitOfWork.Beers;
//     var beer = new Beer()
//     {
//         Name = "Fuller",
//         Style = "Porter"
//     };
//     beers.Add(beer);

//     var brands = unitOfWork.Brands;
//     var brand = new Brand()
//     {
//         Name = "Fuller"
//     };
//     brands.Add(brand);
//     unitOfWork.Save();
// }

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

// using DesignPattern.StrategyPattern;
//
// var context = new Context(new CarStrategy());
// context.Run();
// context.Strategy = new MotoStrategy();
// context.Run();

using DesignPattern.BuilderPattern;

var builder = new PreparedAlcoholicDrinkConcreteBuilder();
var barmanDirector = new BarmanDirector(builder);
barmanDirector.PreparePiñaColada();

var preparedDrink = builder.GetPreparedDrink();
Console.WriteLine(preparedDrink.Result);
