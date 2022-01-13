namespace StarbuzzCoffee;

public class Mocha : CondimentDecorator
{
    public override string Description => Beverage.Description + ", Mocha";
    
    public Mocha(Beverage beverage) 
    {
        Beverage = beverage;
    }
    
    public override double Cost()
    {
        return Beverage.Cost() + .20;
    }
}
