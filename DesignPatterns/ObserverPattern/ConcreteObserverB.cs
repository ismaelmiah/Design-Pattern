// The Subject owns some important state and notifies observers when the
// state changes.
using ObserverPattern;

class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine($"ConcreteObserverB: Reacted to the event. Subject state: {((Subject)subject).State}");
    }
}
