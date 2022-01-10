using StarbuzzCoffee;

public abstract class CondimentDecorator : Beverage
{
    private Beverage _beverage;

    public abstract string Beverage { get; set; }
}