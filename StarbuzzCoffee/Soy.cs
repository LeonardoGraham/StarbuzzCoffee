namespace StarbuzzCoffee;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) 
    {
        Beverage = beverage;
    }

    public override string Description => Beverage.Description + ", Soy";

    public override double Cost()
    {
        return Beverage.Cost() + .15;
    }
}