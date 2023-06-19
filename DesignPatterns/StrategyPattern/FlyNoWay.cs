using System;

namespace StrategyPattern
{
    class FlyNoWay : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
