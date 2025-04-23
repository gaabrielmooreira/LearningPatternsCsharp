using FlyWeight;

var factory = new FlyWeightFactory(
    new Mouse { Company = "Logitech", Model = "G301", Color = "pink" },
    new Mouse { Company = "Logitech", Model = "G303", Color = "black" },
    new Mouse { Company = "Logitech", Model = "G703", Color = "red" },
    new Mouse { Company = "BenQ", Model = "Zowie EC2", Color = "red" },
    new Mouse { Company = "BenQ", Model = "Zowie EC3", Color = "white" }
);
factory.listFlyweights();

addMouseToFlyWeight(factory, new Mouse {
    NumberOfSeries = "123021X",
    Company = "Logitech",
    Model = "GPRO",
    Color = "black",
    WarrantYears = 3,
});

addMouseToFlyWeight(factory, new Mouse {
    NumberOfSeries = "164521U",
    Company = "Logitech",
    Model = "G703",
    Color = "red",
    WarrantYears = 3,
});

factory.listFlyweights();

static void addMouseToFlyWeight(FlyWeightFactory factory, Mouse mouse)
{
    Console.WriteLine("\nClient: Adding a mouse to FlyWeight.");

    var flyweight = factory.GetFlyweight(new Mouse {
        Color = mouse.Color,
        Company = mouse.Company,
        Model = mouse.Model
    });

    flyweight.Operation(mouse);
}