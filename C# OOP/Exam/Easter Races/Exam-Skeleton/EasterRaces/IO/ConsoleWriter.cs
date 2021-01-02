namespace EasterRaces.IO
{
    using System;
    using System.IO;
    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            File.AppendAllText("../../../output.txt", message + Environment.NewLine);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}