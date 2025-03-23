using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(":::::::: VINTAGE ::::::::");

            var vintageBedroomFactory = new VintageBedroomFactory();
            Console.WriteLine(vintageBedroomFactory.CreateBed());
            Console.WriteLine(vintageBedroomFactory.CreateBedSideTable());
            Console.WriteLine(vintageBedroomFactory.CreateWardrobe());
            Console.Write("\n");

            Console.WriteLine(":::::::: MODERN ::::::::");

            var modernBedroomFactory = new ModernBedroomFactory();
            Console.WriteLine(modernBedroomFactory.CreateBed());
            Console.WriteLine(modernBedroomFactory.CreateBedSideTable());
            Console.WriteLine(modernBedroomFactory.CreateWardrobe());
        }
    }
}


