using System.Text;
using Composite.Interfaces;

namespace Composite.Components
{
    public class Box : IComponent
    {
        private string name = "";
        private List<IComponent> children = new List<IComponent>(); 

        public Box(string name) 
        {
            this.name = name;
        }

        public void execute(IParameters parameters) 
        {
            this.PrintBox(parameters);
        
            parameters.AddBoxLevel();
            foreach (var child in children)
            {
                child.execute(parameters);
            }
            parameters.RemoveBoxLevel();
        }

        public void Add(IComponent component)
        {
            children.Add(component);
        }

        public void Remove(IComponent component)
        {
            children.Remove(component);
        }

        private void PrintBox(IParameters parameters) 
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= parameters.GetBoxLevel(); i++)
            {
                sb.Append('#');
            }
            Console.WriteLine($"{sb} Box {name}");
        }
    }
}