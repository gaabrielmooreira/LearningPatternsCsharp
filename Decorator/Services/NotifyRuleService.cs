
using Decorator.Services.Interfaces;

public class NotifyRuleService : IRuleService
{
    IRuleService _ruleService;
    public NotifyRuleService(IRuleService ruleService)
    {
        _ruleService = ruleService;
    }
    
    public void execute(int ruleId)
    {
        _ruleService.execute(ruleId);
        Console.WriteLine($"Notifying by e-mail the rule_{ruleId}...");
    }
}