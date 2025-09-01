using System;

namespace DesignPattern.StatePattern;

public interface IState
{
    public void Action(CustomerContext customerContext, decimal amount);

}
