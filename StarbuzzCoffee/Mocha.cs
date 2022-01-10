namespace StarbuzzCoffee;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) 
    {
        Beverage = beverage;
    }

    public override string Description => Beverage.Description + ", Mocha";

    public override double Cost()
    {
        return Beverage.Cost() + .20;
    }
}
