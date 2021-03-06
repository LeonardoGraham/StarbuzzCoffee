namespace StarbuzzCoffee;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage;
    public abstract override string Description { get; }
}