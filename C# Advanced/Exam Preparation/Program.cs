using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> isCrafted = new Dictionary<string, bool>()
            {
                {"Doll", false },
                {"Wooden train", false },
                {"Teddy bear", false },
                {"Bicycle", false }
            };
            Dictionary<string, int> craftedTimes = new Dictionary<string, int>();
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> magicValues = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            bool crafted = false;
            while(materials.Count > 0 && magicValues.Count > 0)
            {
                int material = materials.Peek();
                int magicValue = magicValues.Peek();

                int result = material * magicValue;
                if(result < 0)
                {
                    int sum = materials.Pop() + magicValues.Dequeue();
                    materials.Push(sum);
                }
                else if(result == 0)
                {
                    if(material == 0)
                    {
                        materials.Pop();
                    }
                    if(magicValue == 0)
                    {
                        magicValues.Dequeue();
                    }
                }
                else
                {
                    if(result == 150 || result == 250 || result == 300 || result == 400)
                    {
                        string toy = "";
                        if (result == 150)
                        {
                            isCrafted["Doll"] = true;
                            toy = "Doll";
                        }
                        else if (result == 250)
                        {
                            isCrafted["Wooden train"] = true;
                            toy = "Wooden train";
                        }
                        else if (result == 300)
                        {
                            isCrafted["Teddy bear"] = true;
                            toy = "Teddy bear";
                        }
                        else if (result == 400)
                        {
                            isCrafted["Bicycle"] = true;
                            toy = "Bicycle";
                        }
                        materials.Pop();
                        magicValues.Dequeue();
                        if(craftedTimes.ContainsKey(toy))
                        {
                            craftedTimes[toy]++;
                        }
                        else
                        {
                            craftedTimes.Add(toy, 1);
                        }
                    }
                    else
                    {
                        magicValues.Dequeue();
                        materials.Push(materials.Pop() + 15);
                    }
                }
                if((isCrafted["Doll"] && isCrafted["Wooden train"]) || (isCrafted["Teddy bear"] && isCrafted["Bicycle"]))
                {
                    crafted = true;
                }
            }

            if(crafted)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if(materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if(magicValues.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicValues)}");
            }

            craftedTimes = craftedTimes.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var toy in craftedTimes)
            {
                if(toy.Value > 0)
                {
                    Console.WriteLine($"{toy.Key}: {toy.Value}");
                }
            }
        }
    }
}
