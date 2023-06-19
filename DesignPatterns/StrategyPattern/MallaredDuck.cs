using System;

namespace StrategyPattern
{
    class MallaredDuck : Duck
    {
        public override void Display()
        {
            // Implement custom display behavior
            throw new NotImplementedException();
        }

        public override void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public override void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}
