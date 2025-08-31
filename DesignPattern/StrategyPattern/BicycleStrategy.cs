using System;

namespace DesignPattern.StrategyPattern;

public class BicycleStrategy : IStrategy
{
    public void Run()
    {
        System.Console.WriteLine("Soy una bicicleta y pedaleo");
    }
}
