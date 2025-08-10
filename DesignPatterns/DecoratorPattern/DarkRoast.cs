namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }
        public override double GetCost()
        {
            return 2.99;
        }
    }
}
