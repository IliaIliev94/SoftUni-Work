using System;
using System.Collections.Generic;

namespace _07._Military_Elite
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IPrivate> privates = new List<IPrivate>();
            while(!command.Equals("End"))
            {
                string[] data = command.Split();
                if(data[0].Equals("Private"))
                {
                    IPrivate @private = new Private(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]));
                    Console.WriteLine(@private);
                    privates.Add(@private);
                }
                else if(data[0].Equals("LieutenantGeneral"))
                {
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]));
                    for(int i = 5; i < data.Length; i++)
                    {
                        int index = privates.FindIndex(x => x.Id == int.Parse(data[i]));
                        if(index != - 1)
                        {
                            lieutenantGeneral.Add(privates[index]);
                        }
                        
                    }
                    Console.Write(lieutenantGeneral);

                }
                else if(data[0].Equals("Engineer"))
                {
                    try
                    {
                        IEngineer engineer = new Engineer(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]), data[5]);
                        for (int i = 6; i < data.Length; i += 2)
                        {
                            IRepair repair = new Repair(data[i], int.Parse(data[i + 1]));
                            engineer.Add(repair);
                        }
                        Console.Write(engineer);
                    }
                    catch
                    {

                    }
                }
                else if(data[0].Equals("Commando"))
                {
                    try
                    {
                        ICommando commando = new Commando(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]), data[5]);
                        for (int i = 6; i < data.Length; i += 2)
                        {
                            try
                            {
                                IMission mission = new Mission(data[i], data[i + 1]);
                                commando.Add(mission);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                        Console.Write(commando);
                    }
                    catch
                    {
                    }
                    
                }
                else if(data[0].Equals("Spy"))
                {
                    ISpy spy = new Spy(int.Parse(data[1]), data[2], data[3], int.Parse(data[4]));
                    Console.WriteLine(spy);
                }
                command = Console.ReadLine();
            }
        }
    }
}
