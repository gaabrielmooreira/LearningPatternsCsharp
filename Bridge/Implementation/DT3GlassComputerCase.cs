using Bridge.Implementation.Interfaces;

namespace Bridge.Implementation
{
    public class DT3GlassComputerCase : IComputerCase
    {
        private bool _isTurnedOn = false;

        public bool IsTurnedOn()
        {
            return _isTurnedOn;
        }

        public void TurnOff(bool force)
        {
            if (force == true) {
                this.ForceTurnOff();
                return;
            }

            // Do something
            Console.WriteLine($"{this.GetType()} turn off.");
            _isTurnedOn = false;
        }

        public void TurnOn()
        {
            // Do something
            Console.WriteLine($"{this.GetType()} turn on.");
            _isTurnedOn = true;
        }

        private void ForceTurnOff()
        {
            // Do something
            Console.WriteLine($"{this.GetType()} forced to turn off.");
        }
    }
}