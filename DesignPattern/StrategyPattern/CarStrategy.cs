using System;

namespace DesignPattern.StrategyPattern;

public class CarStrategy : IStrategy
{
    public void Run()
    {
        System.Console.WriteLine("Soy un auto y me muevo con 4 llantas");
    }
}
