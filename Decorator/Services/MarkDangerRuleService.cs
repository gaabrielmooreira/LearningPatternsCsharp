
using Decorator.Services.Interfaces;

public class MarkDangerRuleService : IRuleService
{
    IRuleService _ruleService;
    public MarkDangerRuleService(IRuleService ruleService)
    {
        _ruleService = ruleService;
    }
    
    public void execute(int ruleId)
    {
        _ruleService.execute(ruleId);
        Console.WriteLine($"Marking as danger rule_{ruleId}...");
    }
}