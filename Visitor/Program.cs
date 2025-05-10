
IBehaviorVisitor behaviorVisitor = new BehaviorVisitor();
IComponent componentA = new ComponentA();
IComponent componentB = new ComponentB();

componentA.AcceptBehaviorVisitor(behaviorVisitor);
componentB.AcceptBehaviorVisitor(behaviorVisitor);