using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class VintageBedroomFactory : IBedroomFactory
    {
        public IBed CreateBed()
        {
            return new VintageBed();
        }
        public IBedSideTable CreateBedSideTable() 
        {
            return new VintageBedSideTable();
        }
        public IWardrobe CreateWardrobe() 
        {
            return new VintageWardrobe();
        }
    }
}
