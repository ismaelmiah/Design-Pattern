namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public void PerformQuack()
        {
            QuackBehavior.PerformQuack();
        }
        // Concrete Strategies implement the algorithm while following the base
        // Strategy interface. The interface makes them interchangeable in the
        // Context.
        public abstract void SetFlyBehavior(IFlyBehavior flyBehavior);
        public abstract void SetQuackBehavior(IQuackBehavior quackBehavior);
        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.PerformFly();
        }

        public void PerformSwim()
        {
            Console.WriteLine("All ducks swim, even decoys");
        }
    }
}
