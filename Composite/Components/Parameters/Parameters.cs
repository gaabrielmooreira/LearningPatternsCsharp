using Composite.Interfaces;

namespace Composite.Components.Parameters;

public class Parameters : IParameters
{
    private int _boxLevel = 0;
    private const int ONE_LEVEL = 1;

    public void AddBoxLevel() 
    {
        _boxLevel += ONE_LEVEL;
    }

    public void RemoveBoxLevel() 
    {
        if (_boxLevel > 0) 
        {
            _boxLevel -= ONE_LEVEL;
        }
    }

    public int GetBoxLevel() 
    {
        return _boxLevel;
    }
}