using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                bool isCorrect = true;
                for (int j = 0; j < usernames[i].Length; j++)
                {
                    if (!char.IsLetter(usernames[i][j]) && !char.IsDigit(usernames[i][j]) && usernames[i][j] != '-' && usernames[i][j] != '_')
                    {
                        isCorrect = false;
                    }
                }
                if (isCorrect && (usernames[i].Length >= 3 && usernames[i].Length <= 16))
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
    }
}
