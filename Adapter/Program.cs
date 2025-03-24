using Adapter.Models.Interfaces;
using Adapter.Models;
using Adapter.Adapters;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(){
                Model = "Tesla",
                Engine = "400"
            };
            IVehicle vehicleAdaptee = new VehicleAdapter(car);
            
            vehicleAdaptee.PrintName();
            vehicleAdaptee.PrintDetails();
        }
    }
}