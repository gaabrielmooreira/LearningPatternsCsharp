

namespace Strategy;

public class ConcreteTaxStrategy : ITaxStrategy
{
    const decimal TAX_MULTIPLY = 0.8M;
    public decimal Calculate(decimal value)
    {
        return value * TAX_MULTIPLY;
    }
}