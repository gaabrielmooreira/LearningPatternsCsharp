
namespace Command;

public class DecreaseCommand : ICommand
{
    
    private Receiver _receiver;
    private int _valueToDecrease;
    private int _backup = 0;
    public DecreaseCommand(Receiver receiver, int valueToDecrease)
    {   
        _receiver = receiver;
        _valueToDecrease = valueToDecrease;
    }
    public void Execute()
    {   
        _backup = _valueToDecrease;
        _receiver.DoSubtraction(_valueToDecrease);
    }

    public void Undo() 
    {
        if (_backup == 0 )
        {
            return;
        }

        _receiver.DoSum(_backup);
        _backup = 0;
    }
}