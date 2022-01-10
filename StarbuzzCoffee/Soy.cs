namespace StarbuzzCoffee;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
        Beverage = beverage;
    }

    public override string Description
    {
        get => Beverage.Description + ", Soy";
    }

    public override double Cost()
    {
        return Beverage.Cost() + .15;
    }
}