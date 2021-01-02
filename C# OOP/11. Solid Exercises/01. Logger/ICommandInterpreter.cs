using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public interface ICommandInterpreter
    {
        public void Execute(ILogger logger, string error, string dateTime, string message);
    }
}
