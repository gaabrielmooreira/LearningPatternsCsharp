using ChainOfResponsability.Interfaces;

namespace ChainOfResponsability.Handlers;

public class SafeHandler : AbstractHandler
{
    public override object? Handle(object request) 
    {
        if (string.Equals(request.ToString(), "safe", StringComparison.OrdinalIgnoreCase)) 
        {
            return $"Request is safe";
        }  

        return base.Handle(request);
    }
}
