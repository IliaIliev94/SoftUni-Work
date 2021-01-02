using System;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while(!command.Equals("Complete"))
            {
                string[] c = command.Split();
                if(c[0].Equals("Make") && c[1].Equals("Upper"))
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (c[0].Equals("Make") && c[1].Equals("Lower"))
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (c[0].Equals("GetDomain"))
                {
                    string temp = "";
                    for (int i = input.Length - int.Parse(c[1]); i < input.Length; i++)
                    {
                        temp += input[i];
                    }
                    Console.WriteLine(temp);
                }
                else if (c[0].Equals("GetUsername"))
                {
                    int index = input.IndexOf("@");
                    if (index == -1)
                    {
                        Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        string temp = new string("");
                        for(int i = 0; i < index; i++)
                        {
                            temp += input[i];
                        }
                        Console.WriteLine(temp);
                    }
                }
                else if (c[0].Equals("Replace"))
                {
                    char compare = char.Parse(c[1]);
                    string temp = new string("");
                    for(int i = 0; i < input.Length; i++)
                    {
                        if(compare == input[i])
                        {
                            temp += '-';
                        }
                        else
                        {
                            temp += input[i];
                        }
                    }
                    input = temp;
                    Console.WriteLine(input);
                }
                else
                {
                    int[] ascii = new int[input.Length];
                    for(int i = 0; i < input.Length; i++)
                    {
                        ascii[i] = (int)input[i];
                    }
                    Console.WriteLine(string.Join(" ", ascii));
                }
                command = Console.ReadLine();
            }
        }
    }
}
