using System;

namespace _03._Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day.Equals("Friday"))
            {
                switch(type)
                {
                    case "Students":
                        price = 8.45;
                        break;
                    case "Business":
                        price = 10.90;
                        break;
                    case "Regular":
                        price = 15;
                        break;
                }
            }
            else if (day.Equals("Saturday"))
            {
                switch(type)
                {
                    case "Students":
                        price = 9.80;
                        break;
                    case "Business":
                        price = 15.60;
                        break;
                    case "Regular":
                        price = 20;
                        break;
                }
            }
            else if (day.Equals("Sunday"))
            {
                switch(type)
                {
                    case "Students":
                        price = 10.46;
                        break;
                    case "Business":
                        price = 16;
                        break;
                    case "Regular":
                        price = 22.50;
                        break;
                    
                }
            }
            double totalPrice = price * people;
            if (type.Equals("Students") && people >= 30)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (type.Equals("Business") && people >= 100)
            {
                totalPrice = totalPrice - (price * 10);
            }
            else if (type.Equals("Regular") && (people >= 10 && people <= 20))
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
            }
            Console.WriteLine($"Total price: {totalPrice.ToString("0.00")}");
        }
    }
}
