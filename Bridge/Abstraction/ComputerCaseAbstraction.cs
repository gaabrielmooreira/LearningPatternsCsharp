using Bridge.Implementation.Interfaces;

namespace Bridge.Abstraction
{
    public class ComputerCaseAbstraction
    {
        private readonly IComputerCase _computerCase;

        public ComputerCaseAbstraction(IComputerCase computerCase)
        {
            _computerCase = computerCase;
        }

        public void PowerButton()
        {
            if (_computerCase.IsTurnedOn())
            {
                _computerCase.TurnOff();
            } else 
            {
                _computerCase.TurnOn();
            }
        }

        public void ResetButton()
        {
            if (_computerCase.IsTurnedOn())
            {
                _computerCase.TurnOff(force: true);
                _computerCase.TurnOn();
            } else 
            {
                _computerCase.TurnOn();
            }
        }
    }
}