using Builder.Models;

namespace Builder.Builders.Interfaces
{
    public interface IComputerBuilder<T>
    {
        T GetResult();
        void Reset();
        void SetCPU(string cpuDetails);
        void SetMemory(string memoryDetails);
        void SetGPU(string gpuDetails);
    }
}
