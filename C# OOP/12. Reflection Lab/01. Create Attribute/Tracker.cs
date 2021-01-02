using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using _01._Create_Attribute.Author;

namespace _01._Create_Attribute
{
    public class Tracker
    {
        public void PrintMthodsByAuthor()
        {
            var type = typeof(TestClass);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public
                | BindingFlags.Static).Where(x => x.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute))).ToArray();
            foreach(var method in methods)
            {
                AuthorAttribute attribute = (AuthorAttribute)method.GetCustomAttribute(typeof(AuthorAttribute));
                Console.WriteLine($"Method: {method.Name} Author:{attribute.Name}");
            }
        }
    }
}
