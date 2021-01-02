using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int num;
            string message = "";
            for (int i = 0; i < lines; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 10)
                {
                    switch(num)
                    {
                        case 2:
                            message += "a";
                            break;
                        case 3:
                            message += "d";
                            break;
                        case 4:
                            message += "g";
                            break;
                        case 5:
                            message += "j";
                            break;
                        case 6:
                            message += "m";
                            break;
                        case 7:
                            message += "p";
                            break;
                        case 8:
                            message += "t";
                            break;
                        case 9:
                            message += "w";
                            break;
                        case 0:
                            message += " ";
                            break;
                        default:
                            message += "";
                            break;
                    }
                }
                else if (num > 10 && num < 100)
                {
                    switch (num)
                    {
                        case 22:
                            message += "b";
                            break;
                        case 33:
                            message += "e";
                            break;
                        case 44:
                            message += "h";
                            break;
                        case 55:
                            message += "k";
                            break;
                        case 66:
                            message += "n";
                            break;
                        case 77:
                            message += "q";
                            break;
                        case 88:
                            message += "u";
                            break;
                        case 99:
                            message += "x";
                            break;
                        case 0:
                            message += " ";
                            break;
                        default:
                            message += "";
                            break;
                    }
                }
                else if (num > 100 & num < 1000)
                {
                    switch (num)
                    {
                        case 222:
                            message += "c";
                            break;
                        case 333:
                            message += "f";
                            break;
                        case 444:
                            message += "i";
                            break;
                        case 555:
                            message += "l";
                            break;
                        case 666:
                            message += "o";
                            break;
                        case 777:
                            message += "r";
                            break;
                        case 888:
                            message += "v";
                            break;
                        case 999:
                            message += "y";
                            break;
                        case 0:
                            message += " ";
                            break;
                        default:
                            message += "";
                            break;
                    }
                }
                else
                {
                    switch(num)
                    {
                        case 7777:
                            message += "s";
                            break;
                        default:
                            message += "z";
                            break;
                    }
                }
            }
            Console.WriteLine(message);
        }
    }
}
