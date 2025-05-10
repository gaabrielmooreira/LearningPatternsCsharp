
public class ComponentB : IComponent
{
    public void AcceptBehaviorVisitor(IBehaviorVisitor behaviorVisitor)
    {
        behaviorVisitor.Visitor(this);
    }
}