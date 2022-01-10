namespace StarbuzzCoffee;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage { get; init; }
    public new abstract string Description { get; }
}