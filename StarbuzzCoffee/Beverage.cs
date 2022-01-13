namespace StarbuzzCoffee;

public abstract class Beverage
{
    public virtual string Description { get; protected init; } = "Unknown Beverage";
    public abstract double Cost();
}