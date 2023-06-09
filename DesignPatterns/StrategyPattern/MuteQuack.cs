using System;

namespace StrategyPattern
{
    class MuteQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            // Do nothing - can't quack
            Console.WriteLine("Can't quack");
        }
    }
}
