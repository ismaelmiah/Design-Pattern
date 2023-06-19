using System;

namespace StrategyPattern
{
    class FlyWithWings : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can fly with wings");
        }
    }
}
