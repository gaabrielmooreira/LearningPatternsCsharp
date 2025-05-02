
namespace Strategy;

public class TaxCalculator
{
    public ITaxStrategy _taxStrategy = new ConcreteTaxStrategy();

    public void SetStrategy(ITaxStrategy taxStrategy)
    {
        _taxStrategy = taxStrategy;
    }

    public decimal Calculate(decimal value)
    {   
        return _taxStrategy.Calculate(value);
    }
}