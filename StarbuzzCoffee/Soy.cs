namespace StarbuzzCoffee;

public class Soy : CondimentDecorator
{
    public override string Description => Beverage.Description + ", Soy";
    
    public Soy(Beverage beverage) 
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .15;
    }
}