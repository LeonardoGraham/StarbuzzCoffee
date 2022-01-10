namespace StarbuzzCoffee;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) 
    {
        Beverage = beverage;
    }

    public override string Description => Beverage.Description + ", Whip";

    public override double Cost()
    {
        return Beverage.Cost() + .10;
    }
}