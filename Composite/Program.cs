using Composite.Components;
using Composite.Components.Parameters;

Box initialComponent = new Box("1");
initialComponent.Add(new Item("1"));

Box box2 = new Box("2");
box2.Add(new Item("5"));
box2.Add(new Item("6"));
box2.Add(new Item("7"));
box2.Add(new Item("8"));
box2.Add(new Item("9"));

Box box3 = new Box("3");
box3.Add(new Item("10"));
box3.Add(new Item("11"));
box3.Add(new Item("12"));

box2.Add(box3);
initialComponent.Add(box2);
initialComponent.Add(new Item("2"));
initialComponent.Add(new Item("3"));
initialComponent.Add(new Item("4"));

initialComponent.execute(new Parameters());



