namespace SystemTypeMethods
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class Program
    {
        public static void Main()
        {
            Type personType = typeof(Person);

            // Type Info
            Console.WriteLine($"FullName: {personType.FullName}");
            Console.WriteLine($"Namespace: {personType.Namespace}");
            Console.WriteLine($"Name: {personType.Name}");
            Console.WriteLine($"Assembly.FullName: {personType.Assembly.FullName}");
            Console.WriteLine($"BaseType: {personType.BaseType}");
            Console.WriteLine($"Interfaces: {string.Join(", ", personType.GetInterfaces().ToList())}");
            Console.WriteLine(new string('-', 60));

            // Fields Info
            FieldInfo nullField = personType.GetField("age"); // not found, null
            Console.WriteLine($"Searching for 'age': {nullField}");
            FieldInfo privateField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine($"Searching for non-public instance 'age': {privateField}");
            FieldInfo[] fields = personType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine($"All fields: {string.Join(", ", fields.ToList())}");
            Console.WriteLine(new string('-', 60));

            // Methods Info
            MethodInfo whoAmIMethod = personType.GetMethod("WhoAmI");
            Console.WriteLine($"Searching for 'WhoAmI': {whoAmIMethod}");
            MethodInfo obsoleteMethod = personType.GetMethod("ObsoleteMethod", BindingFlags.Static);
            Console.WriteLine($"Searching for static 'ObsoleteMethod': {obsoleteMethod}");
            MethodInfo[] methods = personType.GetMethods();
            Console.WriteLine($"Public methods: {string.Join(", ", methods.ToList())}");
            Console.WriteLine(new string('-', 60));

            // Properties Info
            PropertyInfo nameProperty = personType.GetProperty("Name");
            Console.WriteLine($"Searching for 'Name': {nameProperty}");
            PropertyInfo protectedInternalProperty = personType.GetProperty(
                "MyProtectedInternalProperty",
                BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine($"Searching for 'MyProtectedInternalProperty': {protectedInternalProperty}");
            PropertyInfo[] properties = personType.GetProperties();
            Console.WriteLine($"All properties: {string.Join(", ", properties.ToList())}");
            Console.WriteLine(new string('-', 60));

            // Constructors Info
            ConstructorInfo constructorInfo = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            Console.WriteLine($"Searching for .ctor(string, int): {constructorInfo}");
            ConstructorInfo protectedConstructor = personType.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                new Type[] { },
                null);
            Console.WriteLine($"Searching for non-public .ctor(): {protectedConstructor}");
            ConstructorInfo[] constructors = personType.GetConstructors();
            Console.WriteLine($"All public constructors: {string.Join(", ", constructors.ToList())}");
            Console.WriteLine(new string('-', 60));

            // Members Info
            MemberInfo[] membersInfo = personType.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            Console.WriteLine("All members");
            foreach (var memberInfo in membersInfo)
            {
                Console.WriteLine($"- {memberInfo.MemberType}: {memberInfo}");
            }

            Console.WriteLine(new string('-', 60));

            // Search members with given attribute
            var attributeInfo = personType
                .GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .Where(x => x.GetCustomAttributes(typeof(ObsoleteAttribute)).Any());
            Console.WriteLine("Members with ObsoleteAttribute: " + string.Join(", ", attributeInfo.ToList()));
        }
    }
}
