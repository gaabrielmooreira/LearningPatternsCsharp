
using TemplateMethod;

ClientCode(new ConcreteClass());
Console.WriteLine("\n");
ClientCode(new ConcreteClass2());

static void ClientCode(AbstractClass cls)
{
    cls.TemplateMethod();
}