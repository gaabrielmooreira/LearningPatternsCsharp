using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class ModernBedSideTable : IBedSideTable
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
