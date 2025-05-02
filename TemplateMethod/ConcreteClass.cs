
namespace TemplateMethod;

public class ConcreteClass : AbstractClass
{
    protected override void Step2()
    {
        Console.WriteLine("Executing ConcreteClass.Step2...");
    }

    protected override void Step4()
    {
        Console.WriteLine("Executing ConcreteClass.Step4...");
    }
}