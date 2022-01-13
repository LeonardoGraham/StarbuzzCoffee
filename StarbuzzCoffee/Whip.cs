namespace StarbuzzCoffee;

public class Whip : CondimentDecorator
{
    public override string Description => Beverage.Description + ", Whip";
    
    public Whip(Beverage beverage) 
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .10;
    }
}