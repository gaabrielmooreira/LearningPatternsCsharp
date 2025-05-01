
namespace Command;

public class IncreaseCommand : ICommand
{
    private Receiver _receiver;
    private int _valueToIncrease;
    private int _backup = 0;
    public IncreaseCommand(Receiver receiver, int valueToIncrease)
    {   
        _receiver = receiver;
        _valueToIncrease = valueToIncrease;
    }
    public void Execute()
    {   
        _backup = _valueToIncrease;
        _receiver.DoSum(_valueToIncrease);
    }

    public void Undo() 
    {
        if (_backup == 0)
        {
            return;
        }

        _receiver.DoSubtraction(_backup);
        _backup = 0;
    }
}