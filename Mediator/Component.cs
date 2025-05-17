
namespace Mediator;

public abstract class Component
{
    protected IMediator? _mediator;

    public Component(IMediator? mediator)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}