
namespace Mediator;

public class ComponentA(IMediator? mediator = null) : Component(mediator)
{
    public void SomeEvent()
    {
        _mediator?.Notify(this, "someevent");
    }

    public void AnotherEvent()
    {
        _mediator?.Notify(this, "anotherevent");
    }
}