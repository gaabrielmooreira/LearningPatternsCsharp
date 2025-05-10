
IEventPublisher eventPublisher = new EventPublisher();
Event evt = new Event(eventPublisher);

ConcreteSubscriber concrete1 = new ConcreteSubscriber();
ConcreteSubscriber2 concrete2 = new ConcreteSubscriber2();
eventPublisher.AddSubscriber("start", concrete1);
eventPublisher.AddSubscriber("stop", concrete1);
eventPublisher.AddSubscriber("start", concrete2);
eventPublisher.AddSubscriber("stop", concrete2);

evt.Start();
evt.Stop();