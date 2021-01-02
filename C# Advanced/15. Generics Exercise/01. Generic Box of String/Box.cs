using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
    class Box<T>
    {
        public T Name { get; set; }

        public Box(T input)
        {
            this.Name = input;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Name}";
        }
    }
}
