
namespace Mediator;

public class ConcreteMediator : IMediator
{
    private ComponentA _compA;
    private ComponentB _compB;

    public ConcreteMediator(ComponentA componentA, ComponentB componentB)
    {
        _compA = componentA;
        _compA.SetMediator(this);
        _compB = componentB;
        _compB.SetMediator(this);
    }

    public void Notify(Component component, string evt)
    {
        if (component == _compA && evt == "someevent")
        {
            ReactSomeEventA();
            return;
        }

        if (component == _compA && evt == "anotherevent")
        {
            ReactAnotherEventA();
            return;
        }

        if (component == _compB && evt == "someevent")
        {
            ReactSomeEventB();
            return;
        }


        if (component == _compB && evt == "anotherevent")
        {
            ReactAnotherEventB();
            return;
        }
    }

    private void ReactSomeEventA()
    {
        Console.WriteLine("SomeEventA");
    }

    private void ReactAnotherEventA()
    {
        Console.WriteLine("AnotherEventA");
    }

    private void ReactSomeEventB()
    {
        Console.WriteLine("SomeEventB");
    }
    
    private void ReactAnotherEventB()
    {
        Console.WriteLine("AnotherEventB");
    }
}