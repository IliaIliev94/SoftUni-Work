using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter command)
        {
            this.commandInterpreter = command;
        }
        public void Run()
        {
            
            while(true)
            {
                string command = Console.ReadLine();
                string result = this.commandInterpreter.Read(command);
                if(result != null)
                {
                    Console.WriteLine(this.commandInterpreter.Read(command));
                    command = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
