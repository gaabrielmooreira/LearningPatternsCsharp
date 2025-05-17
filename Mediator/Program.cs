
using Mediator;

var componentA = new ComponentA();
var componentB = new ComponentB();

new ConcreteMediator(componentA, componentB);

componentA.SomeEvent();
componentB.SomeEvent();
componentA.AnotherEvent();
componentB.SomeEvent();
componentB.AnotherEvent();