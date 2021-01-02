using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public interface ILogData
    {
        public void PrintData(ILogger logger);
    }
}
