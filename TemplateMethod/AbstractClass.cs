
namespace TemplateMethod;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        this.Step1();
        this.Step2();
        this.Step3();
        this.Step4();
    }

    protected virtual void Step1()
    {
        Console.WriteLine("Executing BasicStep1...");
    }

    protected abstract void Step2();
    protected virtual void Step3()
    {
        Console.WriteLine("Executing BasicStep3...");
    }
    protected abstract void Step4();
}