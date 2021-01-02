using System;
using System.IO;


namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var streamReader = new StreamReader("../../../input.txt");
            int counter = 0;
            using(streamReader)
            {
                using(var streamWriter = new StreamWriter("../../../output.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var input =streamReader.ReadLine();
                        if (counter % 2 == 0)
                        {
                            streamWriter.WriteLine(Reverse(ReplaceChar(input)));
                        }
                        counter++;
                    }
                }
                
            }
        }
        static string ReplaceChar(string s)
        {
            string result = new string("");
            foreach(char character in s)
            {
                if(character == '-' || character == ',' || character == '.' || character == '!' || character == '?')
                {
                    result += '@';
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
        static string Reverse(string s)
        {
            string[] words = s.Split();
            string result = "";
            for(int i = words.Length - 1; i >= 0; i--)
            {
                if(i != words.Length - 1)
                {
                    result += " ";
                }
                result += words[i];
            }
            return result;
        }
    }
}
