using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Lizard reptile = new Lizard("Pesho");
            Console.WriteLine(reptile.Name);
        }
    }
}