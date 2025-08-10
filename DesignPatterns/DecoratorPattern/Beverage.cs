namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }

        public abstract double GetCost();
    }
}
