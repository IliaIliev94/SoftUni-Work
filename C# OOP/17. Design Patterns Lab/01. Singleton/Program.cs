using System;

namespace _01._Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            var db1 = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;
        }
    }
}
