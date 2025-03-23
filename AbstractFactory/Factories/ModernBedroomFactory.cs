using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ModernBedroomFactory : IBedroomFactory
    {
        public IBed CreateBed()
        {
            return new ModernBed();
        }
        public IBedSideTable CreateBedSideTable() 
        {
            return new ModernBedSideTable();
        }
        public IWardrobe CreateWardrobe() 
        {
            return new ModernWardrobe();
        }
    }
}
