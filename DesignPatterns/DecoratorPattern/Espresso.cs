namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }
        public override double GetCost()
        {
            return 1.99;
        }
    }
}
