
public abstract class State
{
        protected SomeObject? _obj;

        public void SetSomeObject(SomeObject obj)
        {
            _obj = obj;
        }

        public abstract void HandleSomething();

        public abstract void HandleSomethingElse();
}