using System;

namespace StrategyPattern
{
    class Quack : IQuackBehavior
    {
        public void PerformQuack()
        {
            // Implements duck quacking
            Console.WriteLine("Quack quack");
        }
    }
}
