using ChainOfResponsability.Interfaces;

namespace ChainOfResponsability.Handlers;

public class ValidatorHandler : AbstractHandler
{
    public override object? Handle(object request) 
    {
        if (request.GetType() != typeof(string)) 
        {
            return $"Request type [{request.GetType()}] isn't string";
        }  

        return base.Handle(request);
    }
}
