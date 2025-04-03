
using Decorator.Services.Interfaces;

namespace Decorator.Services;
public class RuleService : IRuleService
{
    public void execute(int ruleId)
    {
        Console.WriteLine($"Executing rule_{ruleId}...");
    }
}