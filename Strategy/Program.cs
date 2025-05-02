
using Strategy;

TaxCalculator taxCalculator = new TaxCalculator(new ConcreteTaxStrategy());
Console.WriteLine(taxCalculator.Calculate(1000M));

TaxCalculator taxCalculator2 = new TaxCalculator(new ConcreteTaxStrategy2());
Console.WriteLine(taxCalculator2.Calculate(1000M));