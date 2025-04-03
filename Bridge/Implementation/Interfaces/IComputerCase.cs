
namespace Bridge.Implementation.Interfaces
{
    public interface IComputerCase
    {
        bool IsTurnedOn();
        void TurnOn();
        void TurnOff(bool force = false);
    }
}