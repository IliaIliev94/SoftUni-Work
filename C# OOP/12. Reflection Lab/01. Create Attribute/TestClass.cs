using _01._Create_Attribute.Author;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Create_Attribute
{
    [Author("Pesho")]
    public class TestClass
    {
        public string Name { get; set; }
        public TestClass(string name)
        {
            this.Name = name;
        }

        [Author("Gosho")]
        public void WhoAmI()
        {
            Console.WriteLine(this.Name);
        }
    }
}
