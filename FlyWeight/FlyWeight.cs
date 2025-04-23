
using System.Text.Json;

namespace FlyWeight;
public class FlyWeight
{
    private Mouse _sharedState;

    public FlyWeight(Mouse mouse)
    {
        this._sharedState = mouse;
    }

    public void Operation(Mouse uniqueState)
    {
        string s = JsonSerializer.Serialize(_sharedState);
        string u = JsonSerializer.Serialize(uniqueState);
        Console.WriteLine($"FlyWeight: shared {s}, unique {u} state.");
    }
}