public class AnotherState : State
{
    public override void HandleSomething()
    {
        Console.WriteLine("AnotherState: HandleSomething");
    }

    public override void HandleSomethingElse()
    {
        Console.WriteLine("AnotherState: HandleSomethingElse");
    }
}