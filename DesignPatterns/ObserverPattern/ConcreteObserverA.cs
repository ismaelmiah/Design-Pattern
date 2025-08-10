// Concrete Observers react to the updates issued by the Subject they had
// been attached to.
using ObserverPattern;

class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine($"ConcreteObserverA: Reacted to the event. Subject state: {((Subject)subject).State}");
    }
}
