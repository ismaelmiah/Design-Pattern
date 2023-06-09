using System;

namespace StrategyPattern
{
    class FlyBehavior : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
