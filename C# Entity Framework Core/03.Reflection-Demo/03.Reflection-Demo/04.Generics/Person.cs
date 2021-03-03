namespace GenericsDemo
{
    using System;

    public class Person
    {
        public void WhoAmI<T>(T item)
        {
            Console.WriteLine(item.GetType());
        }
    }
}
