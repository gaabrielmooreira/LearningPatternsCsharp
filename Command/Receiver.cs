
namespace Command;

public class Receiver
{
    private int _value;

    public Receiver(int initialValue)
    {
        this._value = initialValue;
    }

    public void DoSum(int valueToIncrease)
    {
        this._value = this._value + valueToIncrease;
    }


    public void DoSubtraction(int valueToDecrease)
    {
        this._value = this._value - valueToDecrease;
    }

    public void PrintValue()
    {
        Console.WriteLine($"Receiver :: Value :: {this._value}");
    }
}