using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Contacts
{
    public interface ILogFile
    {
        int Size { get; }
        void Write(string error);
    }
}
