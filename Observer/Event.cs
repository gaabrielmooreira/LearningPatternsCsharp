
public class Event
{
    private readonly IEventPublisher _eventPublisher;
    private EventStateEnum _state = EventStateEnum.STOPPED;
    public Event(IEventPublisher eventPublisher)
    {
        _eventPublisher = eventPublisher;
    }

    public void Start()
    {
        _state = EventStateEnum.STARTED;
        Console.WriteLine("Event started");
        _eventPublisher.Notify("start", this);
    }

    public void Stop()
    {
        _state = EventStateEnum.STOPPED;
        Console.WriteLine("Event stopped");
        _eventPublisher.Notify("stop", this);
    }

    public EventStateEnum GetState()
    {
        return _state;
    }
}

public enum EventStateEnum
{
    STOPPED,
    STARTED,
}