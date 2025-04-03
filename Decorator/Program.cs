using Decorator.Services;
using Decorator.Services.Interfaces;

// Client code

IRuleService ruleService = new RuleService();
ruleService = new MarkDangerRuleService(ruleService);
ruleService = new NotifyRuleService(ruleService);
ruleService.execute(4);