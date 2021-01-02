using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentSystem.Entities
{
    public class Command
    {
        public string Name { get; private set; }
        public string[] Arguments { get; private set; }

        public static Command Parse(string text)
        {
            var parts = text.Split();

            if (parts.Length < 1)
            {
                return null;
            }
            return new Command
            {
                Name = parts[0],
                Arguments = parts.Skip(1).ToArray()

            };
        }
    }
}
