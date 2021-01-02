using System;

namespace _01._Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList test = new LinkedList(new[] { 1, 2, 3, 7, 9, 10, 12 });

            test.RemoveLast();
            test.RemoveFirst();
            test.Remove(7);

            test.ForEach(x => Console.WriteLine(x.Value));

            Console.WriteLine(test.Count);

            int[] myArray = test.ToArray();

            Console.WriteLine(string.Join(" ", myArray));

        }

        public static void Double(Node test)
        {
            test.Value = test.Value * 2;
        }
    }
}
