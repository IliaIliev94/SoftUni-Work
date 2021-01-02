using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while(!command.Equals("find"))
            {
                StringBuilder temp = new StringBuilder();
                if (command.Length > nums.Length)
                {
                    for (int i = 0, j = 0; i < command.Length; i++, j++)
                    {
                        temp.Append((char)(command[i] - nums[j % nums.Length]));
                    }
                }
                else
                {
                    for (int i = 0, j = nums.Length - 1; i < command.Length; i++, j--)
                    {
                        temp.Append((char)(command[i] - nums[j]));
                        if (j == 0)
                        {
                            j += nums.Length;
                        }
                    }
                }
                int index = temp.ToString().IndexOf('&');
                int lastIndex = temp.ToString().LastIndexOf('&');
                string item = temp.ToString().Substring(index + 1, lastIndex - index - 1);
                index = temp.ToString().IndexOf('<');
                lastIndex = temp.ToString().IndexOf('>');
                string location = temp.ToString().Substring(index + 1, lastIndex - index - 1);
                Console.WriteLine($"Found {item} at {location}");
                command = Console.ReadLine();
            }
                
        }
    }
}
