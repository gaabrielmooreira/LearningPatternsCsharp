public interface IEventPublisher
    {
        void AddSubscriber(string eventType, IEventSubscriber eventSubscriber);
        void RemoveSubscriber(string eventType, IEventSubscriber eventSubscriber);
        void Notify(string eventType, Event evt);
    }