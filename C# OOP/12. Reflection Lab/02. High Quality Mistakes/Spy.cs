using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

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

        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder result = new StringBuilder();
            Type type = Type.GetType(className);
            Hacker hacker = (Hacker)Activator.CreateInstance(typeof(Hacker));
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach(var field in fields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => !x.GetGetMethod(true).IsPublic);
            foreach(var property in properties)
            {
                result.AppendLine($"{property.GetGetMethod(true).Name} have to be public!");
            }
            properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(property => property.GetSetMethod(true).IsPublic);
            foreach (var property in properties)
            {
                result.AppendLine($"{property.GetSetMethod(true).Name} have to be public!");
            }
            return result.ToString();
        }
    }
}
