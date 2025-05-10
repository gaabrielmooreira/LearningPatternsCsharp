

public class EventPublisher : IEventPublisher
{
    private readonly Dictionary<string, List<IEventSubscriber>> _subscribers = new Dictionary<string, List<IEventSubscriber>>();
    public void AddSubscriber(string eventType, IEventSubscriber eventSubscriber)
    {
        List<IEventSubscriber>? _eventSubscribers = _subscribers.GetValueOrDefault(eventType);
        if (_eventSubscribers is null)
        {
            _subscribers.Add(eventType, new List<IEventSubscriber> { eventSubscriber });
            return;
        }
        _eventSubscribers.Add(eventSubscriber);       
    }

    public void RemoveSubscriber(string eventType, IEventSubscriber eventSubscriber)
    {
        List<IEventSubscriber>? _eventSubscribers = _subscribers.GetValueOrDefault(eventType);
        if (_eventSubscribers is not null)
        {
            _eventSubscribers.Remove(eventSubscriber); 
        }
    }

    public void Notify(string eventType, Event evt)
    {
        Console.WriteLine("EventPublisher: Notifying subscribers...");
        List<IEventSubscriber>? _eventSubscribers = _subscribers.GetValueOrDefault(eventType);
        if (_eventSubscribers is null) 
        {
            return;
        }

        foreach (var eventSubscriber in _eventSubscribers)
        {
            eventSubscriber.Update(evt);
        }
    }
}