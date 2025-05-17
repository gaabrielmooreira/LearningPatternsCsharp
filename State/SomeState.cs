
public class SomeState : State
{
    public override void HandleSomething()
    {
        Console.WriteLine("SomeState: HandleSomething");
    }

    public override void HandleSomethingElse()
    {
        Console.WriteLine("SomeState: HandleSomethingElse");
    }
}