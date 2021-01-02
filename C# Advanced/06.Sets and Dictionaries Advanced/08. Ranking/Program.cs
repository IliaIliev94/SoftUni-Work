using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> exams = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userScores = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> maxPoints = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while(!input.Equals("end of contests"))
            {
                string[] data = input.Split(":");
                string contest = data[0];
                string password = data[1];
                if(!userScores.ContainsKey(contest))
                {
                    exams.Add(contest, password);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while(!input.Equals("end of submissions"))
            {
                string[] data = input.Split("=>");
                string exam = data[0];
                string password = data[1];
                string user = data[2];
                int number = int.Parse(data[3]);
                if(exams.ContainsKey(exam) && exams[exam] == password)
                {
                    
                    if(userScores.ContainsKey(user))
                    {
                        if(userScores[user].ContainsKey(exam))
                        {
                            if(number > userScores[user][exam])
                            {
                                int temp = userScores[user][exam];
                                userScores[user][exam] = number;
                                number -= temp;
                            }
                            else
                            {
                                number = 0;
                            }
                        }
                        else
                        {
                            userScores[user].Add(exam, number);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> result = new Dictionary<string, int>();
                        result.Add(exam, number);
                        userScores.Add(user, result);
                    }
                    
                    if(maxPoints.ContainsKey(user))
                    {
                        maxPoints[user] += number;
                    }
                    else
                    {
                        maxPoints.Add(user, number);
                    }
                }
                input = Console.ReadLine();
            }
            userScores = userScores.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string bestCandidate = new string("");
            long score = 0;

            foreach(var item in maxPoints)
            {
                if(item.Value > score)
                {
                    bestCandidate = item.Key;
                    score = item.Value;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {score} points.");
            Console.WriteLine("Ranking:");
            foreach(var item in userScores)
            {
                Console.WriteLine(item.Key);
                Dictionary<string, int> temp = item.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach(var exam in temp)
                {
                    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                }
            }
        }
    }
    
}
