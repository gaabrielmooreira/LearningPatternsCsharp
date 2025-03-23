using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class VintageBed : IBed
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
