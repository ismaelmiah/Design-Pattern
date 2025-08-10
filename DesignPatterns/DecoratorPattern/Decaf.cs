namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf Coffee";
        }
        public override double GetCost()
        {
            return 2.49;
        }
    }
}
