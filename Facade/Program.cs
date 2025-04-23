using Facade;
using Facade.Interfaces;

IJsonFacade jsonFacade = new JsonFacade();

jsonFacade.DeserializeJson();
jsonFacade.SerializeJson();
