namespace InstancesAndInvocations
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class Program
    {
        public static void Main()
        {
            Type personType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == "Person");

            // Create instance by calling the constructor method
            Type[] constructorArgs = { typeof(string), typeof(int) };
            ConstructorInfo ctor = personType?.GetConstructor(constructorArgs);
            object[] constructorParams = { "Viktor Dakov", 22 };
            var instanceWithCtor = ctor?.Invoke(constructorParams) as IPerson;
            Console.WriteLine(instanceWithCtor);

            // Create instance with Activator.CreateInstance
            object[] myConstructorParams = { "Nikolay Kostov", 29 };
            var instance = Activator.CreateInstance(personType, myConstructorParams) as Person;
            Console.WriteLine(instance);

            // Invoke method Eat
            MethodInfo eatMethod = typeof(Person).GetMethod("Eat");
            object eatMethodResult = eatMethod.Invoke(instance, new object[] { "Burger" });
            Console.WriteLine(eatMethodResult);

            // Work with get and set
            var propertyName = personType.GetProperty("Name");
            object nameValue = propertyName.GetValue(instance);
            Console.WriteLine(nameValue);
            propertyName.SetValue(instance, "Ivaylo Kenov");
            nameValue = propertyName.GetValue(instance);
            Console.WriteLine(nameValue);
        }
    }
}
