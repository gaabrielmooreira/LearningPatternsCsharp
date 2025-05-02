

namespace Strategy;

public class ConcreteTaxStrategy2 : ITaxStrategy
{
    const decimal TAX_MULTIPLY = 0.7M;
    public decimal Calculate(decimal value)
    {
        return value * TAX_MULTIPLY;
    }
}