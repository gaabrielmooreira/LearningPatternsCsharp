using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders
{
    public class DesktopBuilder : IComputerBuilder<Desktop>
    {
        private Desktop _result = new Desktop();

        public void Reset()
        {
            _result = new Desktop();
        }

        public void SetCPU(string cpuDetails)
        {
            _result.CPU = cpuDetails;
        }

        public void SetMemory(string memoryDetails)
        {
            _result.Memory = memoryDetails;
        }

        public void SetGPU(string gpuDetails)
        {
            _result.GPU = gpuDetails;
        }

        public Desktop GetResult()
        {
            return _result;
        }
    }
}