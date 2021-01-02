using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using _01._Logger.Contacts;

namespace _01._Logger
{
    public class LogFile : ILogFile
    {
        public int Size
        {
            get
            {
                return Characters.ToString().Select(x => (int)x).Sum();
            }
        }
        private StringBuilder Characters { get; set; }

        public LogFile()
        {
            this.Characters = new StringBuilder();
            Empty();
        }

        public void Write(string error)
        {
            string path = "text.txt";
            File.AppendAllText(path, error);
            Characters.Append(error);
        }

        private void Empty()
        {
            string path = "text.txt";
            File.WriteAllText(path, String.Empty);
        }
    }
}
