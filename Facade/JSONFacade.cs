using Facade.Interfaces;

namespace Facade;

public class JsonFacade : IJsonFacade
{
    private readonly ThirdPartyLibrary _thirdPartylibrary = new ThirdPartyLibrary();

    public JsonFacade() 
    {
    }

    public void SerializeJson()
    {
        _thirdPartylibrary.JsonSerializer();
    }
    
    public void DeserializeJson() 
    {
        _thirdPartylibrary.JsonDeserializer();
    }
}