using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IBedroomFactory
    {
        IBed CreateBed();
        IBedSideTable CreateBedSideTable();
        IWardrobe CreateWardrobe();
    }
}
