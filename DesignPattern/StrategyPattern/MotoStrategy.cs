using System;

namespace DesignPattern.StrategyPattern;

public class MotoStrategy : IStrategy
{
    public void Run()
    {
        System.Console.WriteLine("Soy una moto y me muevo con 2 llantas");
    }
}
