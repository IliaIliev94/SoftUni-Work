using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class SimpleLayout : ILayout
    {
        private const string DefaultFormat = "{0} - {1} - {2}";
        public string Format => DefaultFormat;
    }
}
