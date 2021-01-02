using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public interface IInputOutputProvider
    {
        string GetInput();
        void ShowOutput(string data);
    }
}
