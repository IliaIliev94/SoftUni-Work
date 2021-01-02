using System;
using System.IO;
using System.Text;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream("../../../img.jpg", FileMode.Open);
            int counter = 0;
            using(fileStream)
            {

                using(var fileStream2 = new FileStream("../../../copy.jpg", FileMode.Create))
                {
                    byte[] temp = new byte[fileStream.Length];
                    fileStream.Read(temp, 0, (int)fileStream.Length);
                    fileStream2.Write(temp, 0, temp.Length);
                }
            }
        }
    }
}
