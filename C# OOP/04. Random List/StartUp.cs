using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList myList = new RandomList();
            myList.Add("Ivan");
            myList.Add("Pesho");
            Console.WriteLine(myList.RandomString());
        }
    }
}
