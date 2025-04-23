
namespace FlyWeight;
public class FlyWeightFactory
{
    private List<Tuple<FlyWeight, string>> flyweights = new List<Tuple<FlyWeight, string>>();

    public FlyWeightFactory(params Mouse[] args)
    {
        foreach (var elem in args)
        {
            flyweights.Add(new Tuple<FlyWeight, string>(new FlyWeight(elem), this.getKey(elem)));
        }
    }

    public string getKey(Mouse key)
    {
        List<string> elements = new List<string>() 
        {
            key.Company,
            key.Model,
            key.Color,
        };
        
        elements.Sort();
        return string.Join("_", elements);
    }

    public FlyWeight GetFlyweight(Mouse sharedState)
    {
        string key = this.getKey(sharedState);

        if (flyweights.Where(t => t.Item2 == key).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            this.flyweights.Add(new Tuple<FlyWeight, string>(new FlyWeight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }
        return this.flyweights.Where(t => t.Item2 == key).First().Item1;
    }

    public void listFlyweights()
    {
        var count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}