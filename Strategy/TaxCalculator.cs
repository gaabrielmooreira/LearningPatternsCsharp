
namespace Strategy;

public class TaxCalculator
{
    public ITaxStrategy _taxStrategy;

    public TaxCalculator(ITaxStrategy taxStrategy)
    {
        _taxStrategy = taxStrategy;
    }

    public decimal Calculate(decimal value)
    {   
        return _taxStrategy.Calculate(value);
    }
}