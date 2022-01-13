namespace StarbuzzCoffee;

public class Decaff : Beverage
{
    public Decaff()
    {
        Description = "Decaff Coffee";
    }
    public override double Cost()
    {
        return 1.05;
    }
}