
namespace Command;

public class Invoker
{
    List<ICommand> _commands;
    List<ICommand> _historyExecutes = new List<ICommand>();
    public Invoker(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void ExecuteCommands()
    {
        foreach(ICommand command in _commands)
        {
            command.Execute();
            _historyExecutes.Add(command);
        }
    }

    public void Undo()
    {
        while (_commands.Count != 0)
        {
            ICommand lastCommand = _commands[_commands.Count - 1];
            lastCommand.Undo();
            _commands.RemoveAt(_commands.Count - 1);
        }
    }
}