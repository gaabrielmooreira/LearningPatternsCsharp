using ChainOfResponsability.Interfaces;

namespace ChainOfResponsability.Handlers;

public class BoomHandler : AbstractHandler
{
    public override object? Handle(object request) 
    {
        if (string.Equals(request.ToString(), "boom", StringComparison.OrdinalIgnoreCase)) 
        {
            return $"Request is boom";
        }  

        return base.Handle(request);
    }
}
