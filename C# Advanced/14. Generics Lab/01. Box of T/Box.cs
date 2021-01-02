using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> Collection { get; set; }

        public int Count
        {
            get
            {
                return this.Collection.Count;
            }
        }
        public Box()
        {
            this.Collection = new List<T>();
        }

        public void Add(T element)
        {
            this.Collection.Add(element);
        }

        public T Remove()
        {
            T result = Last();
            this.Collection.Remove(result);
            return result;
        }

        public T Last()
        {
            return this.Collection[this.Collection.Count - 1];
        }
    }
}
