using Command;

Receiver receiver = new Receiver(150);
List<ICommand> commands = new List<ICommand> 
{ 
    new IncreaseCommand(receiver, 100), 
    new DecreaseCommand(receiver, 10) 
};
Invoker invoker = new Invoker(commands);
invoker.ExecuteCommands();
receiver.PrintValue();

invoker.Undo();
receiver.PrintValue();