
public class ConcreteSubscriber2 : IEventSubscriber
{
    public void Update(Event evt)
    {
        if (evt.GetState() == EventStateEnum.STARTED)
        {
            Console.WriteLine("ConcreteSubscriber2 reacted to start event");
        }

        if (evt.GetState() == EventStateEnum.STOPPED)
        {
            Console.WriteLine("ConcreteSubscriber2 reacted to stop event");
        }
    }
}