// The Subject owns some important state and notifies observers when the
// state changes.
using ObserverPattern;

class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if (((Subject)subject).State is 0 or >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
