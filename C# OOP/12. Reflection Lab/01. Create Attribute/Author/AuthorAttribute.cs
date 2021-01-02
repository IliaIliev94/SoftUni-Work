using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Create_Attribute.Author
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
