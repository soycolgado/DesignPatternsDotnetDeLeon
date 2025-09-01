using System;

namespace DesignPattern.StatePattern;

public class DebtorState : IState
{
    public void Action(CustomerContext customerContext, decimal amount)
    {
        Console.WriteLine("No puedes comprar porque eres un deudor");
    }
}
