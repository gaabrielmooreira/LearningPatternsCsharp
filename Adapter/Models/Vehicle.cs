using Adapter.Models.Interfaces;

namespace Adapter.Models
{
    public class Vehicle : IVehicle
    {
        public string? Name { get; set; }
        public string? Details { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(this.Details);
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }

    }
}