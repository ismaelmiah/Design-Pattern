namespace ObserverPattern
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}