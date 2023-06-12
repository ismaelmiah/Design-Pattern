// Concrete Observers react to the updates issued by the Subject they had
// been attached to.
using ObserverPattern;

class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if (((Subject)subject).State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}
