
namespace TemplateMethod;

public class ConcreteClass2 : AbstractClass
{
    protected override void Step2()
    {
        Console.WriteLine("Executing ConcreteClass2.Step2...");
    }

    protected override void Step3()
    {
        Console.WriteLine("Executing ConcreteClass2.Step3...");
    }

    protected override void Step4()
    {
        Console.WriteLine("Executing ConcreteClass2.Step4...");
    }
}