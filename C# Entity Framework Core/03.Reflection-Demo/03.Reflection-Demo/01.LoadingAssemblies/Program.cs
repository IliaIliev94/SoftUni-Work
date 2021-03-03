namespace LoadingAssemblies
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    using LoadingAssemblies.Extension;

    public static class Program
    {
        public static void Main()
        {
            // Example with Assembly.Load(name)
            Assembly assemblyLoad = Assembly.Load("01.LoadingAssemblies");

            // Example with Assembly.LoadFrom(path)
            Assembly assemblyLoadFrom = Assembly.LoadFrom("01.LoadingAssemblies.dll");

            // Difference between Calling and Executing Assembly
            Console.WriteLine($"LoadingAssemblies Executing Assembly: {Assembly.GetExecutingAssembly().FullName}");
            Console.WriteLine($"LoadingAssemblies Calling Assembly: {Assembly.GetCallingAssembly().FullName}");
            Console.WriteLine($"LoadingAssemblies Entry Assembly: {Assembly.GetEntryAssembly()?.FullName}");
            Console.WriteLine(new string('-', 60));
            var assemblyExtension = new Information().GetInfo();
            Console.WriteLine(assemblyExtension);
            Console.WriteLine(new string('-', 60));

            // Already loaded assembly
            Console.WriteLine(typeof(object).Assembly.FullName);
            Console.WriteLine(typeof(Regex).Assembly.FullName);
            Console.WriteLine(Assembly.Load(new AssemblyName("netstandard")).FullName);
            Console.WriteLine(Assembly.Load(new AssemblyName("netstandard")).Location);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("References:");
            foreach (var assembly in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                Console.WriteLine("- " + assembly.FullName);
            }

            Console.WriteLine(new string('-', 60));

            Console.WriteLine("All .NET Standard references:");
            foreach (var assembly in Assembly.Load(new AssemblyName("netstandard")).GetReferencedAssemblies()) // System.Runtime
            {
                Console.WriteLine("- " + assembly.FullName);
            }

            Console.WriteLine(new string('-', 60));
        }
    }
}
