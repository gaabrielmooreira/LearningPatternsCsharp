using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class ModernBed : IBed
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
