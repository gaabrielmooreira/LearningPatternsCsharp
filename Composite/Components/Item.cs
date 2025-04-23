using System.Text;
using Composite.Interfaces;

namespace Composite.Components;

public class Item : IComponent
{
    private string name = "";

    public Item(string name)
    {
        this.name = name;
    }

    public void execute(IParameters parameters) 
    {
        this.PrintItem(parameters);
    }

    private void PrintItem(IParameters parameters)
    {
        var sb = new StringBuilder();
        for (int i = 0; i <= parameters.GetBoxLevel(); i++)
        {
            sb.Append('#');
        }
        Console.WriteLine($"{sb} Item {this.name}");
    }
}