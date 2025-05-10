
public class BehaviorVisitor : IBehaviorVisitor
{
    public void Visitor(ComponentA componentA)
    {
        Console.WriteLine("Doing some auxiliar behavior for the ComponentA");
    }

    public void Visitor(ComponentB componentB)
    {
        Console.WriteLine("Doing some auxiliar behavior for the ComponentB");
    }
}