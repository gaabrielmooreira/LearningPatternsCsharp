
public class ConcreteSubscriber : IEventSubscriber
{
    public void Update(Event evt)
    {
        if (evt.GetState() == EventStateEnum.STARTED)
        {
            
            Console.WriteLine("ConcreteSubscriber reacted to start event");
        }

        if (evt.GetState() == EventStateEnum.STOPPED)
        {
            Console.WriteLine("ConcreteSubscriber reacted to stop event");
        }
    }
}