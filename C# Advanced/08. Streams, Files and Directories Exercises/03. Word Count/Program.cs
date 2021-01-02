using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            string[] wordsToCompare = File.ReadAllLines("../../../words.txt");

            string[] text = File.ReadAllLines("../../../text.txt");

            foreach(string line in text)
            {
                string[] lineWords = line.Split(new string[] { " ", ",", ".", "?", "!", "-"}, StringSplitOptions.RemoveEmptyEntries);

                foreach(string word in lineWords)
                {
                    if(wordsToCompare.Contains(word.ToLower()))
                    {
                        if(wordCounter.ContainsKey(word.ToLower()))
                        {
                            wordCounter[word.ToLower()]++;
                        }
                        else
                        {
                            wordCounter.Add(word.ToLower(), 1);
                        }
                    }
                }
            }
            string[] lines = new string[wordsToCompare.Length];
            int counter = 0;
            foreach(var item in wordCounter)
            {
                lines[counter] = item.Key + " - " + item.Value;
                counter++;
            }
            File.WriteAllLines("../../../actualResults.txt", lines);
            wordCounter = wordCounter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            counter = 0;
            foreach(var item in wordCounter)
            {
                lines[counter] = item.Key + " - " + item.Value;
                counter++;
            }
            File.WriteAllLines("../../../expectedResult.txt", lines);
        }
    }
}
