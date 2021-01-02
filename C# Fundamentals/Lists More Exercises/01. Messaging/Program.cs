using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> message = Console.ReadLine().ToList();
            string newMessage = "";
            for (int i = 0; i < nums.Count; i++)
            {
                int element = nums[i];
                int sum = 0;
                while (element != 0)
                {
                    sum += element % 10;
                    element /= 10;
                }
                newMessage += message[sum % message.Count];
                message.RemoveAt(sum % message.Count);
            }
            Console.WriteLine(newMessage);
        }
    }
}
