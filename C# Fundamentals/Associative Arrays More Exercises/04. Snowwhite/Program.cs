using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalHats = new Dictionary<string, int>();
            string command = Console.ReadLine();
            int count = 0;
            while(!command.Equals("Once upon a time"))
            {
                string[] info = command.Split(" <:> ");
                string name = info[0];
                string hatColor = info[1];
                int physics = int.Parse(info[2]);
                bool addDwarf = true;
                if (!dwarfs.ContainsKey(hatColor))
                {
                    Dictionary<string, int> newDwarf = new Dictionary<string, int>();
                    newDwarf.Add(name, physics);
                    dwarfs.Add(hatColor, newDwarf);
                }
                else
                {
                    if (!dwarfs[hatColor].ContainsKey(name))
                    {
                        dwarfs[hatColor].Add(name, physics);
                    }
                    else if (physics > dwarfs[hatColor][name])
                    {
                        dwarfs[hatColor][name] = physics;
                        addDwarf = false;
                    }
                    else
                    {
                        addDwarf = false;
                    }
                }
                if (addDwarf)
                {
                    count++;
                    if (!totalHats.ContainsKey(hatColor))
                    {
                        totalHats.Add(hatColor, 1);
                    }
                    else
                    {
                        totalHats[hatColor]++;
                    }
                }
                command = Console.ReadLine();
            }

            List<string> temp = new List<string>();

            string[] max = new string[4];
            max[2] = "0";
            max[3] = "0";
            
            for (int i = 0; i < count; i++)
            {
                foreach (var item in dwarfs)
                {
                    foreach (var mini in item.Value)
                    {

                        if (mini.Value > int.Parse(max[2]))
                        {
                            max[0] = item.Key;
                            max[1] = mini.Key;
                            max[2] = mini.Value.ToString();
                            max[3] = totalHats[item.Key].ToString();
                        }
                        else if (mini.Value == int.Parse(max[2]))
                        {
                            if (totalHats[item.Key] > int.Parse(max[3]))
                            {
                                max[0] = item.Key;
                                max[1] = mini.Key;
                                max[2] = mini.Value.ToString();
                                max[3] = totalHats[item.Key].ToString();
                            }
                        }
                    }
                }
                temp.Add(max[0]);
                temp.Add(max[1]);
                temp.Add(max[2]);
                max[2] = "0";
                max[3] = "0";

                dwarfs[max[0]].Remove(max[1]);

                if (dwarfs[max[0]].Count < 1)
                {
                    dwarfs.Remove(max[0]);
                }
            }
            
            for (int i = 0; i < temp.Count; i+=3)
            {
                Console.WriteLine($"({temp[i]}) {temp[i + 1]} <-> {temp[i + 2]}");
            }
        }
    }
}
