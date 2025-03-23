using System.Text.Json;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car()
            {
                Wheels = "G",
                Engine = new Engine()
                {
                    Name = "Exemplo",
                    SerialNumber = 400
                }
            };
            Console.WriteLine(JsonSerializer.Serialize(car));
            Console.WriteLine(":::::::::: CLONE :::::::::");
            var carClone = car.Clone();
            Console.WriteLine(JsonSerializer.Serialize(carClone));
        }
    }
}

public class Car : ICloneable
{
    public string Wheels { get; set; }
    public Engine Engine { get; set; }
    public object Clone()
    {
        return new Car()
        {
            Wheels = this.Wheels,
            Engine = new Engine()
            {
                Name = this.Engine.Name,
                SerialNumber = this.Engine.SerialNumber
            }
        };
    }
}

public class Engine
{
    public string Name { get; set; }
    public int SerialNumber { get; set; }
}
