using DesignPattern.FactoryPattern;

SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory internetSaleFactory = new InternetSaleFactory(2);

ISale sal1 = storeSaleFactory.GetSale();
sal1.Sell(15);

ISale sal2 = internetSaleFactory.GetSale();
sal2.Sell(15);
