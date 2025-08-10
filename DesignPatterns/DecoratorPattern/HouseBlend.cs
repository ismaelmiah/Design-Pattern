namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "House Blend Coffee";
        }
        public override double GetCost()
        {
            return 0.89;
        }
    }
}
