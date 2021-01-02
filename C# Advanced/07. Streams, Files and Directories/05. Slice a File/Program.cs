using System;
using System.IO;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = new StreamReader("../../../input.txt");
            string s = "";
            using(fileStream)
            {
                while(!fileStream.EndOfStream)
                {
                    s += fileStream.ReadLine();
                }
            }
            int length = s.Length / 4;
            int counter = 0;

            for(int i = 1; i <= 4; i++)
            {
                var writer = new StreamWriter("../../../text" + i + ".txt");
                try
                {
                    string text = "";
                    if (s.Length - (counter + length) != 1)
                    {
                        text = s.Substring(counter, length);
                    }
                    else
                    {
                        text = s.Substring(counter, length + 1);
                    }

                    writer.Write(text);
                    counter += length;
                }
                finally
                {
                    writer.Close();
                }
                

            }

            
        }
    }
}
