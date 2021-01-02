using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers =  ArrayCreator.Create(10, 33);

            foreach(string name in strings)
            {
                Console.WriteLine(name);
            }

            foreach(int num in integers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
