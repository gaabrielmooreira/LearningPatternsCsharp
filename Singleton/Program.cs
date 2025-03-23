using System.Text.Json;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Console.WriteLine($"Is same instance? {singleton1 == singleton2}");
        }
    }

    public sealed class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

}

