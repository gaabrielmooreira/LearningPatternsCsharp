using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class VintageBedSideTable : IBedSideTable
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
