using System;

namespace StrategyPattern
{
    class Squeak : IQuackBehavior
    {
        public void PerformQuack()
        {
            //rubber duckie squeak
            Console.WriteLine("Squeak squeak");
        }
    }
}
