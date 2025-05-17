
public class SomeObject
{
    private State? _state = null;
    public SomeObject(State state)
    {
        ChangeState(state);
    }

    public void ChangeState(State state)
    {
        Console.WriteLine($"SomeObject: Change to {state.GetType().Name}.");
        _state = state;
        _state.SetSomeObject(this);
    }

    public void RequestSomething()
    {
        _state?.HandleSomething();
    }

    public void RequestSomethingElse()
    {
        _state?.HandleSomethingElse();
    }
}