// using DesignPattern.FactoryPattern;

// SaleFactory storeSaleFactory = new StoreSaleFactory(10);
// SaleFactory internetSaleFactory = new InternetSaleFactory(2);
//
// ISale sal1 = storeSaleFactory.GetSale();
// sal1.Sell(15);
//
// ISale sal2 = internetSaleFactory.GetSale();
// sal2.Sell(15);

using DesignPattern.DependencyInjection;

var beer = new Beer("Pikantus", "Edinger");
var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
drinkWithBeer.Build();