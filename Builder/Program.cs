using Builder.Builders;
using Builder.Models;
using System.Text.Json;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DesktopBuilder builder = new DesktopBuilder();
            builder.SetCPU("AMD Ryzen 5 7600X");
            builder.SetMemory("Kingston 16GB");
            builder.SetGPU("GIGABYTE RTX 4060 8GB");
            Desktop desktop = builder.GetResult();

            Console.WriteLine($"Desktop made with builder: {JsonSerializer.Serialize(desktop)}");
        }
    }
}