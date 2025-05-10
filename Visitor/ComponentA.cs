
public class ComponentA : IComponent
{
    public void AcceptBehaviorVisitor(IBehaviorVisitor behaviorVisitor)
    {
        behaviorVisitor.Visitor(this);
    }
}