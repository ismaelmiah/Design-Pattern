namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;
        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }
        public override double GetCost()
        {
            return _beverage.GetCost();
        }
    }

    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 0.10;
        }
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 0.20;
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 0.15;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 0.25;
        }
    }
}
