namespace StarbuzzCoffee;

public abstract class Beverage
{
    public string Description { get; protected init; } = "Unknown Beverage";
    public abstract double Cost();
}