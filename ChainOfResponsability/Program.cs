using ChainOfResponsability.Handlers;

var validatorHandler = new ValidatorHandler();
var boomHandler = new BoomHandler();
var safeHandler = new SafeHandler();

validatorHandler.SetNext(boomHandler).SetNext(safeHandler);
var result = validatorHandler.Handle(1);
if (result != null)
{
    Console.WriteLine(result);
}

var result2 = validatorHandler.Handle("boom");
if (result2 != null)
{
    Console.WriteLine(result2);
}

var result3 = validatorHandler.Handle("safe");
if (result3 != null)
{
    Console.WriteLine(result3);
}

var result4 = boomHandler.Handle(4);
if (result4 != null)
{
    Console.WriteLine(result4);
} else 
{
    Console.WriteLine("Result4 is null");
}