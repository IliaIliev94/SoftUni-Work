using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            StringBuilder result = new StringBuilder();
            Type type = Type.GetType(className);
            Hacker construct = (Hacker)Activator.CreateInstance(type);
            result.AppendLine($"Class under investigation: {type.Name}");
            foreach(string field in fields)
            {
                FieldInfo info = type.GetField(field, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                result.AppendLine($"{info.Name} = {info.GetValue(construct)}");
            }
            return result.ToString();
        }
    }
}
