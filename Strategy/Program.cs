
using Strategy;

TaxCalculator taxCalculator = new TaxCalculator();
Console.WriteLine(taxCalculator.Calculate(1000M));
taxCalculator.SetStrategy(new ConcreteTaxStrategy2());
Console.WriteLine(taxCalculator.Calculate(1000M));