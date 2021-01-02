using System;
using System.Text.RegularExpressions;
namespace _01._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string pattern = @"(?<dollars>[\$]*)(?<a>[@]*)(?<hash>[#]*)(?<upper>[\^]*)";
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                if (input[i].Length == 20)
                {
                    string firstHalf = input[i].Substring(0, input[i].Length / 2);
                    string secondHalf = input[i].Substring(input[i].Length / 2, input[i].Length / 2);
                    MatchCollection firstMatch = Regex.Matches(firstHalf, pattern);
                    MatchCollection secondMatch = Regex.Matches(secondHalf, pattern);
                    bool isJackpotLeft = false;
                    bool isJackpotRight = false;
                    string symbolLeft = "";
                    string symbolRight = "";
                    int lengthLeft = 0;
                    int lengthRight = 0;
                    foreach(Match match in firstMatch)
                    {
                        if (match.Groups["dollars"].Length >= 10)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "$";
                            lengthLeft = 10;
                        }
                        else if (match.Groups["a"].Length >= 10)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "@";
                            lengthLeft = 10;
                        }
                        else if (match.Groups["hash"].Length >= 10)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "#";
                            lengthLeft = 10;
                        }
                        else if (match.Groups["upper"].Length >= 10)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "^";
                            lengthLeft = 10;
                        }
                        else if (match.Groups["dollars"].Length >= 6 && match.Groups["dollars"].Length <= 9)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "$";
                            lengthLeft = match.Groups["dollars"].Length;
                        }
                        else if (match.Groups["a"].Length >= 6 && match.Groups["a"].Length <= 9)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "@";
                            lengthLeft = match.Groups["a"].Length;
                        }
                        else if (match.Groups["hash"].Length >= 6 && match.Groups["hash"].Length <= 9)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "#";
                            lengthLeft = match.Groups["hash"].Length;
                        }
                        else if (match.Groups["upper"].Length >= 6 && match.Groups["upper"].Length <= 9)
                        {
                            isJackpotLeft = true;
                            symbolLeft = "^";
                            lengthLeft = match.Groups["upper"].Length;
                        }

                    }
                    foreach(Match match in secondMatch)
                    {
                        if (match.Groups["dollars"].Length >= 10)
                        {
                            isJackpotRight = true;
                            symbolRight = "$";
                            lengthRight = 10;
                        }
                        else if (match.Groups["a"].Length >= 10)
                        {
                            isJackpotRight = true;
                            symbolRight = "@";
                            lengthRight = 10;
                        }
                        else if (match.Groups["hash"].Length >= 10)
                        {
                            isJackpotRight = true;
                            symbolRight = "#";
                            lengthRight = 10;
                        }
                        else if (match.Groups["upper"].Length >= 10)
                        {
                            isJackpotRight = true;
                            symbolRight = "^";
                            lengthRight = 10;
                        }
                        else if (match.Groups["dollars"].Length >= 6 && match.Groups["dollars"].Length <= 9)
                        {
                            isJackpotRight = true;
                            symbolRight = "$";
                            lengthRight = match.Groups["dollars"].Length;
                        }
                        else if (match.Groups["a"].Length >= 6 && match.Groups["a"].Length <= 9)
                        {
                            isJackpotRight = true;
                            symbolRight = "@";
                            lengthRight = match.Groups["a"].Length;
                        }
                        else if (match.Groups["hash"].Length >= 6 && match.Groups["hash"].Length <= 9)
                        {
                            isJackpotRight = true;
                            symbolRight = "#";
                            lengthRight = match.Groups["hash"].Length;
                        }
                        else if (match.Groups["upper"].Length >= 6 && match.Groups["upper"].Length <= 9)
                        {
                            isJackpotRight = true;
                            symbolRight = "^";
                            lengthRight = match.Groups["upper"].Length;
                        }
                    }
                    if ((isJackpotLeft && isJackpotRight) && (symbolLeft == symbolRight) && (lengthLeft == 10 && lengthRight == 10))
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {lengthLeft}{symbolLeft} Jackpot!");
                    }
                    else if ((isJackpotLeft && isJackpotRight) && (symbolLeft == symbolRight) && (lengthLeft >= 6 && lengthRight >= 6))
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {(int)Math.Min(lengthLeft, lengthRight)}{symbolLeft}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }
    }
}
