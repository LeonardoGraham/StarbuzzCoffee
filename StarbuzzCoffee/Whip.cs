namespace StarbuzzCoffee;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
        Beverage = beverage;
    }

    public override string Description
    {
        get => Beverage.Description + ", Whip";
    }

    public override double Cost()
    {
        return Beverage.Cost() + .10;
    }
}