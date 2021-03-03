namespace GenericsDemo
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            // Instance of generic class
            var type = typeof(DbSet<>);
            var genericType = type.MakeGenericType(new[] { typeof(string) });
            var instance = Activator.CreateInstance(genericType) as DbSet<string>;
            Console.WriteLine(instance.Count);

            // Invocation of generic method
            var personType = typeof(Person);
            var personInstance = Activator.CreateInstance(personType);
            personType.GetMethod("WhoAmI")?.MakeGenericMethod(typeof(string)).Invoke(
                personInstance,
                new object[] { string.Empty });
        }
    }
}
