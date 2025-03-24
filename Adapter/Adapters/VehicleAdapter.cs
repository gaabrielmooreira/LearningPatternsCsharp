using Adapter.Models.Interfaces;
using Adapter.Models;

namespace Adapter.Adapters
{
    public class VehicleAdapter : IVehicle
    {
        Car _car;

        public VehicleAdapter(Car car)
        {
            _car = car;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Vehicle: Car, Name: {_car.Model}, Engine: {_car.Engine}");
        }

        public void PrintName()
        {
            Console.WriteLine(_car.Model);
        }
    }
}
