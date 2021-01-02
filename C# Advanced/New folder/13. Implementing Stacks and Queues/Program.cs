using System;

namespace _13._Implementing_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();
            myList.Add(2);
            myList.Add(3);
            myList.Add(5);
            myList.Add(4);
            myList.Insert(1, 5);
            Console.WriteLine(myList.Contains(2));
            myList.Swap(0, 1);
            Console.WriteLine(myList.Find(2));
            myList.Reverse();
            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
